using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Linq;

namespace IfcToolkit {

/// <summary>Class containing functions for importing IFC files into Unity. </summary>
/*
For all your ifc importing needs.
Usage: 
    1) IfcImporter.RuntimeImport(file_to_import), returns the root GameObject
    2) Also used by various UnityEditor scripts to handle drag and drop files etc
        *The relevant functions are
            -ProcessIfc to generate obj, mtl and xml (runtime) or dae and xml (editor)
            -LoadDae (for saving as a prefab) or ObjectLoader.Load (for runtime imports)
            -IfcXmlParser.parseXmlFile to add the metadata
            -Prefabsaver.SavePrefab to save as prefab. Editor only, deletes GameObject.
    
Rough outline of what calls what:
User
    RuntimeImport
        ProcessIfc
        ObjectLoader.Load
            TreeBuilder.ReconstructTree
        IfcXmlParser.parseXmlFile
        return root_object

UnityEditor's events (drag and drop files etc)
    IfcProcessor.OnPreProcess
        ProcessIfc
    IfcProcessor.OnPostProcess
        LoadDae
        IfcXmlParser.parseXml
        PrefabSaver.savePrefab

UnityEditor's menu Assets->Import IFC
    IfcEditorExtension.OnGUI
        ProcessIfc
        LoadDae
        IfcXmlParser.parseXml
        PrefabSaver.savePrefab
*/
public class IfcImporter : MonoBehaviour
{
    /// <summary>The main user interface of IfcImporter, used to import an IFC file into Unity on runtime.</summary>
    /// <param name="inputFile">File path to an IFC file relative to project root. If the file is in the project root folder, the filepath is just the name of the IFC file + the .ifc extension. </param>
    /// <param name="options"> Optional IFC import options. </param>
    /// <returns>IFC hierarchy root GameObject. </returns>
    public static GameObject RuntimeImport(string inputFile, IfcSettingsOptionHolder options = null) {
        if (options == null) {
            options = new IfcSettingsOptionHolder();
        }
        bool editor = false;
        ProcessIfc(inputFile, options, editor);
        string resourceName = System.IO.Path.GetFileNameWithoutExtension(inputFile);
        string assetPath = "Assets/IfcImporter/Resources/";
        string outputFile = assetPath + resourceName;
        GameObject root_object = ObjectLoader.Load (assetPath, resourceName + "_obj.obj", options);
        //Add the metadata
        string xml_path = assetPath +resourceName + "_xml.xml";
        IfcXmlParser.parseXmlFile(xml_path, root_object, options);

        //Store filename in Ifc File component
        IfcFile ifcFile = root_object.AddComponent<IfcFile>() as IfcFile;
        ifcFile.ifcFileName = resourceName;
        ifcFile.ifcFilePath = inputFile;
        ifcFile.geometryFileFormat = "OBJ";

        if (!options.keepOriginalPositionEnabled) {
            MoveToOrigin(root_object);
        }
        if (!options.keepOriginalPositionForPartsEnabled) {
            MovePartsToOrigin(root_object);
        }

        return root_object;
    }

    /// <summary>The alternative user interface of IfcImporter, used to import an IFC file into Unity on runtime via a coroutine.</summary>
    /// <param name="inputFile">File path to an IFC file relative to project root. If the file is in the project root folder, the filepath is just the name of the IFC file + the .ifc extension. </param>
    /// <param name="options"> Optional IFC import options. </param>
    /// <param name="callback"> A callback function that can be used to grab the IFC hierarchy root GameObject outside the function.</param>
    public static IEnumerator RuntimeImportCoroutine(string inputFile, IfcSettingsOptionHolder options = null, Action<GameObject> callback = null) {
        if (options == null) {
            options = new IfcSettingsOptionHolder();
        }
        bool editor = false;
        yield return ProcessIfcCoroutine(inputFile, options, editor);
        string resourceName = System.IO.Path.GetFileNameWithoutExtension(inputFile);
        string assetPath = "Assets/IfcImporter/Resources/";
        string outputFile = assetPath + resourceName;
        yield return ObjectLoader.LoadCoroutine(assetPath, resourceName+"_obj.obj", options, (root_object) => {
            //Add the metadata
            string xml_path = assetPath +resourceName + "_xml.xml";
            IfcXmlParser.parseXmlFile(xml_path, root_object, options);

            //Store filename in Ifc File component
            IfcFile ifcFile = root_object.AddComponent<IfcFile>() as IfcFile;
            ifcFile.ifcFileName = resourceName;
            ifcFile.ifcFilePath = inputFile;
            if (!options.keepOriginalPositionEnabled) {
                MoveToOrigin(root_object);
            }
            if (!options.keepOriginalPositionForPartsEnabled) {
                MovePartsToOrigin(root_object);
            }
            if (callback != null) {
                callback(root_object);
            }
        });
    }

    ///<summary>Moves the Ifc hierarchy closer to origin.</summary>
    ///<remarks>Moves any GameObjects of types "IfcProject" and "IfcSite" to coordinates (0,0,0). Averages out the positions of IfcBuildings and subtracts that from their position.</remarks>
    ///<param name="rootObject">Root object of the IFC hierarchy to be moved.</param>
    public static void MoveToOrigin(GameObject rootObject) {
        IfcRootLists rl = rootObject.GetComponent<IfcRootLists>();
        List<GameObject> to_center = rl.FindIfcElementTypeGameObjects("IfcProject");
        to_center.AddRange(rl.FindIfcElementTypeGameObjects("IfcSite"));
        foreach (GameObject o in to_center) {
            o.transform.localPosition = Vector3.zero;
        }
        List<GameObject> buildings = rl.FindIfcElementTypeGameObjects("IfcBuilding");
        OffsetByAverage(buildings);
    }

    ///<summary>Moves individual parts close to the origin.</summary>
    ///<remarks>For weird IFC-files where all indivdual parts are displaced to Narnia.</remarks>
    ///<param name="rootObject">Root object of the IFC hierarchy with parts to be moved.</param>
    public static void MovePartsToOrigin(GameObject rootObject) {
        IfcRootLists rl = rootObject.GetComponent<IfcRootLists>();
        List<GameObject> to_center = new List<GameObject>(rl.ifcGameObject);
        //We do not want to move IfcProject, IfcSite or IfcBuilding here, just everything else.
        List<GameObject> excluded = rl.FindIfcElementTypeGameObjects("IfcProject");
        excluded.AddRange(rl.FindIfcElementTypeGameObjects("IfcSite"));
        excluded.AddRange(rl.FindIfcElementTypeGameObjects("IfcBuilding"));
        to_center = to_center.Except(excluded).ToList();
        OffsetByAverage(to_center);
    }

    ///<summary>Calculates the average position of the GameObjects, and subtracts it from their positions.</summary>
    ///<param name="to_offset">A list of GameObjects to relocate.</summary>
    private static void OffsetByAverage(List<GameObject> to_offset) {
        if (to_offset.Count > 0) {
            Vector3 offset = Vector3.zero;
            foreach (GameObject o in to_offset) {
                offset += o.transform.localPosition;
            }
            offset = offset / to_offset.Count;
            foreach (GameObject o in to_offset) {
                o.transform.localPosition = o.transform.localPosition - offset;
            }
        }
    }

    /// <summary>Generate 3D model from an IFC file. The OBJ file (or DAE in editor mode) is writen to the Assets/IfcImporter/Resources folder.</summary>
    /// <param name="inputFile">File path to an IFC file relative to project root. If the file is in the project root folder, the filepath is just the name of the IFC file + the .ifc extension. </param>
    /// <param name="options"> Optional IFC import options. </param>
    /// <param name="editor"> Optional IFC import options. </param>
    public static void ProcessIfc(string inputFile, IfcSettingsOptionHolder options = null, bool editor = true)
    {
        // TODO: Move imports to this function from generate functions (return output filename from generate)?
        // TODO: See if asynchronously calling generate functions is any faster
        // Add tests for generate functions (e.g. createsfile, createslog, isxml, isdae, logcontainserroriferror)
        if (options == null) {
            options = new IfcSettingsOptionHolder();
        }
        string ifcConvert = FindIfcConvert();
        if (String.IsNullOrEmpty(ifcConvert))
        {
            UnityEngine.Debug.Log("IfcConvert.exe not found! Please add ifc convert to the root of the project!");
            return;
        }
 
        //List<Process> allProcesses = new List<Process>();
        List<Tuple<Process, StringBuilder, StringBuilder>> allProcesses = new List<Tuple<Process, StringBuilder, StringBuilder>>();

        //Create Assets/IfcImporter/Resources folder if it doesn't exist
        System.IO.Directory.CreateDirectory("Assets/IfcImporter/Resources/");
        //Save files under Assets/IfcImporter/Resources so that we can access them later to create the prefab
        string resourceName = System.IO.Path.GetFileNameWithoutExtension(inputFile);
        string assetPath = "Assets/IfcImporter/Resources/";
        string outputFile = assetPath + resourceName;


        //On runtime we want an obj for ease of importing. In editor DAE is preferred for ease of saving prefabs and avoiding bugs with obj import
        if (editor)
            allProcesses.Add(GenerateDAE(ifcConvert, inputFile, outputFile, options));
        else
            allProcesses.Add(GenerateOBJ(ifcConvert, inputFile, outputFile));
        if (!options.parallelProcessingEnabled)
        {
            WaitToFinish(allProcesses);
        }
        //Create .xml
        allProcesses.Add(GenerateXML(ifcConvert, inputFile, outputFile));

        //Wait for the processes to finish
        WaitToFinish(allProcesses);
    }

    /// <summary>Generate 3D model from an IFC file. The OBJ file (or DAE in editor mode) is writen to the Assets/IfcImporter/Resources folder.</summary>
    /// <remarks>This is the coroutine version of this function, to be used with RuntimeImportCoroutine.</remarks>
    /// <param name="inputFile">File path to an IFC file relative to project root. If the file is in the project root folder, the filepath is just the name of the IFC file + the .ifc extension. </param>
    /// <param name="options"> Optional IFC import options. </param>
    /// <param name="editor"> Optional IFC import options. </param>
    public static IEnumerator ProcessIfcCoroutine(string inputFile, IfcSettingsOptionHolder options = null, bool editor = true)
    {
        // TODO: Move imports to this function from generate functions (return output filename from generate)?
        // TODO: See if asynchronously calling generate functions is any faster
        // Add tests for generate functions (e.g. createsfile, createslog, isxml, isdae, logcontainserroriferror)
        string ifcConvert = FindIfcConvert();
        if (String.IsNullOrEmpty(ifcConvert))
        {
            UnityEngine.Debug.Log("IfcConvert.exe not found! Please add ifc convert to the root of the project!");
            yield break;
        }
 
        List<Tuple<Process, StringBuilder, StringBuilder>> allProcesses = new List<Tuple<Process, StringBuilder, StringBuilder>>();

        //Create Assets/IfcImporter/Resources folder if it doesn't exist
        System.IO.Directory.CreateDirectory("Assets/IfcImporter/Resources/");
        //Save files under Assets/IfcImporter/Resources so that we can access them later to create the prefab
        string resourceName = System.IO.Path.GetFileNameWithoutExtension(inputFile);
        string assetPath = "Assets/IfcImporter/Resources/";
        string outputFile = assetPath + resourceName;


        //On runtime we want an obj for ease of importing. In editor DAE is preferred for ease of saving prefabs and avoiding bugs with obj import
        if (editor)
            allProcesses.Add(GenerateDAE(ifcConvert, inputFile, outputFile, options));
        else
            allProcesses.Add(GenerateOBJ(ifcConvert, inputFile, outputFile));
        if (!options.parallelProcessingEnabled)
        {
            yield return WaitToFinishCoroutine(allProcesses);
        }
        //Create .xml
        allProcesses.Add(GenerateXML(ifcConvert, inputFile, outputFile));

        //Wait for the processes to finish
        yield return WaitToFinishCoroutine(allProcesses);
    }


    ///<summary>Looks for the external IfcConvert program we use to convert ifc to obj/dae/xml.</summary>
    ///<remarks>Will get horribly confused if there's more than one file with IfcConvert in the name.</remarks>
    ///<returns>Returns the path to the IfcConvert program.</returns>
    private static string FindIfcConvert()
    {
        //For Windows: could do "*.exe" to look for exes only. Not really necessary though..
        string[] filePaths = Directory.GetFiles(Directory.GetCurrentDirectory(), "*", SearchOption.AllDirectories);
        foreach (string fp in filePaths)
        {
            if (fp.Contains("IfcConvert"))
            {
                return fp;
            }
        }
        return null;
    }

    /// <summary>Generate a DAE file from an IFC file. </summary>
    /// <param name="ifcConvert">File path to IfcConvert.exe. </param>
    /// <param name="inputFile">File path to an IFC file relative to project root. If the file is in the project root folder, the filepath is just the name of the IFC file + the .ifc extension. </param>
    /// <param name="outputFile">File path for the output DAE file. </param>
    /// <returns>A Tuple containing the process that calls IfcConvert.exe, as well as StringBuilders that receive the process' standard output and error streams. </returns>
    public static Tuple<Process, StringBuilder, StringBuilder> GenerateDAE(string ifcConvert, string inputFile, string outputFile, IfcSettingsOptionHolder options)
    {
        //--use-element-guids so that we can identify the elements later on
        string exclude = "";
        if (options != null && options.exclude_option != "") {
            exclude = " --exclude=entities IfcOpeningElement IfcSpace "+exclude;
        }
        return CallIFCConverter("dae", "--use-element-guids --use-element-hierarchy"+exclude, ifcConvert, inputFile, outputFile);
    }

    /// <summary>Generate a OBJ file from an IFC file. </summary>
    /// <param name="ifcConvert">File path to IfcConvert.exe. </param>
    /// <param name="inputFile">File path to an IFC file relative to project root. If the file is in the project root folder, the filepath is just the name of the IFC file + the .ifc extension. </param>
    /// <param name="outputFile">File path for the output OBJ file. </param>
    /// <returns>A Tuple containing the process that calls IfcConvert.exe, as well as StringBuilders that receive the process' standard output and error streams. </returns>
    public static Tuple<Process, StringBuilder, StringBuilder> GenerateOBJ(string ifcConvert, string inputFile, string outputFile)
    {
        return CallIFCConverter("obj", "--use-element-guids --y-up", ifcConvert, inputFile, outputFile);
    }

    /// <summary>Generate an XML file from an IFC file. </summary>
    /// <param name="ifcConvert">File path to IfcConvert.exe. </param>
    /// <param name="inputFile">File path to an IFC file relative to project root. If the file is in the project root folder, the filepath is just the name of the IFC file + the .ifc extension. </param>
    /// <param name="outputFile">File path for the output XML file. </param>
    /// <returns>A Tuple containing the process that calls IfcConvert.exe, as well as StringBuilders that receive the process' standard output and error streams. </returns>
    public static Tuple<Process, StringBuilder, StringBuilder> GenerateXML(string ifcConvert, string inputFile, string outputFile)
    {
        return CallIFCConverter("xml", "", ifcConvert, inputFile, outputFile);
    }

    /// <summary>Start a process to convert IFC files into other formats. </summary>
    /// <param name="extension">File extension of the output file. </param>
    /// <param name="parameters">IfcConvert.exe command line parametes. </param>
    /// <param name="ifcConvert">File path to IfcConvert.exe. </param>
    /// <param name="inputFile">File path to an IFC file relative to project root. If the file is in the project root folder, the filepath is just the name of the IFC file + the .ifc extension. </param>
    /// <param name="outputFile">File path for the output file. </param>
    /// <returns>A Tuple containing the process that calls IfcConvert.exe, as well as StringBuilders that receive the process' standard output and error streams.</returns>
    public static Tuple<Process, StringBuilder, StringBuilder> CallIFCConverter(string extension, string parameters, string ifcConvert, string inputFile, string outputFile)
    {
        //UnityEngine.Debug.Log("CallIFCCOnverter for " + inputFile + "." + extension);
        inputFile = System.IO.Path.GetFullPath(inputFile);
        outputFile = System.IO.Path.GetFullPath(outputFile)+"_"+extension;
        ifcConvert = System.IO.Path.GetFullPath(ifcConvert);
        inputFile = "\""+inputFile+"\"";
 
        Process ifcConverter = new Process();
        //Number of threads for ifcOpenShell
        int threads = SystemInfo.processorCount;
        //Different handling for Linux and Windows
        //Note: cmd.exe doesn't like single quotes.
        if (IsWindows())
        {
            ifcConverter.StartInfo.FileName = "cmd.exe";
            //We have no way to answer to any confirmation queries, so include -y to deal with them. Otherwise Unity freezes when, for example, the file already exists.
            String args = " /C \"\""+ifcConvert+"\" -y -j " +threads+" "+inputFile+" \""+outputFile+"."+extension+"\""+" "+parameters+" > \""+outputFile+"_log.txt\"\"";
            ifcConverter.StartInfo.Arguments = args;
        }
        if (IsUnix())
        {
            ifcConverter.StartInfo.FileName = "bash";
            String args = " -c '\""+ifcConvert+"\" -y -j "+threads+" "+inputFile+" \""+outputFile+"."+extension+"\" "+parameters+"'";
            ifcConverter.StartInfo.Arguments = args;
            //Redirect output to console
            ifcConverter.StartInfo.UseShellExecute = false;
            ifcConverter.StartInfo.RedirectStandardOutput = true;
            ifcConverter.StartInfo.RedirectStandardError = true;
        }
        ifcConverter.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        StringBuilder output = new StringBuilder();
        StringBuilder error = new StringBuilder();
        ifcConverter.Start();
        ReadProcessOutput(ifcConverter, output, error);
        
        return Tuple.Create(ifcConverter, output, error);

    }

    ///<summary>Create event handlers for reading process output, and start reading.</summary>
    ///<remarks>Process must have UseShellExecute set as false and RedirectStandardOutput and RedirectStandardError set to true. The process must have been started before this function can be called.</remarks>
    ///<param name="process">Process to read output from.</param>
    ///<param name="output">A StringBuilder for storing the standard output in.</param>
    ///<param name="error">A StringBuilder for storing the standard error in.</param>
    public static void ReadProcessOutput(Process process, StringBuilder output, StringBuilder error) {
        if (IsUnix())
        {
            //Line by line event handlers
            process.OutputDataReceived += new DataReceivedEventHandler((s, e) => 
            {
                if (e.Data != null)
                {
                    output.Append(e.Data);
                }
            });
            process.ErrorDataReceived += new DataReceivedEventHandler((s, e) =>
            {
                if (e.Data != null)
                {
                    error.Append(e.Data);
                }
            });
        
            //Line by line output
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        
            /*
            //Full output
            string standard_output = process.StandardOutput.ReadToEnd();
            string standard_error = process.StandardError.ReadToEnd();
            if (standard_output != "")
                UnityEngine.Debug.Log("output: " + standard_output);
            if (standard_error != "")
                UnityEngine.Debug.LogError("errors: " + standard_error);
            */
        }

    }

    /// <summary>Check if the OS is Windows. </summary>
    /// <returns>True if on Windows. </returns>

    public static bool IsWindows() {
        RuntimePlatform[] windows_platforms = {RuntimePlatform.WindowsPlayer, RuntimePlatform.WindowsEditor};
        return windows_platforms.Contains(Application.platform);
    }

    /// <summary>Check if the OS is Linux or OSX. </summary>
    /// <returns>True if on Linux or OSX. </returns>

    public static bool IsUnix() {
        RuntimePlatform[] unix_platforms = {RuntimePlatform.LinuxPlayer, RuntimePlatform.LinuxEditor, RuntimePlatform.OSXEditor, RuntimePlatform.OSXPlayer};
        return unix_platforms.Contains(Application.platform);
    }

    /// <summary>Wait for a number of processes to finish. </summary>
    /// <param name="processes">The processes to wait for. </param>
    public static void WaitToFinish(List<Tuple<Process, StringBuilder, StringBuilder>> processes)
    {
        foreach(Tuple<Process, StringBuilder, StringBuilder> processInfo in processes)
        {
            Process ifcConverter = processInfo.Item1;
            StringBuilder standard_output = processInfo.Item2;
            StringBuilder standard_error = processInfo.Item3;
            ifcConverter.WaitForExit();
            //Print output - doesn't work in windows
            if (IsUnix()) {
                if (standard_output.ToString() != "")
                    UnityEngine.Debug.Log("output: " + standard_output.ToString());
                if (standard_error.ToString() != "")
                    UnityEngine.Debug.LogError("errors: " + standard_error.ToString());
            }
            //Print an error message if IfcConvert crashed
            if (ifcConverter.ExitCode == 1) {
                UnityEngine.Debug.LogError("IFCOpenShell could not generate something.");
            }
        }
    }

    /// <summary>Wait for a number of processes to finish. </summary>
    /// <param name="processes">A list of Processes to wait for, as well as StringBuilders containing their standard output and error streams. </param>
    public static IEnumerator WaitToFinishCoroutine(List<Tuple<Process, StringBuilder, StringBuilder>> processes) {
        foreach(Tuple<Process, StringBuilder, StringBuilder> processInfo in processes)
        {
            Process ifcConverter = processInfo.Item1;
            StringBuilder standard_output = processInfo.Item2;
            StringBuilder standard_error = processInfo.Item3;
            WaitUntil processFinished = new WaitUntil(() => ifcConverter.HasExited);
            yield return processFinished;
            //Print output - doesn't work in windows
            if (IsUnix()) {
                if (standard_output.ToString() != "")
                    UnityEngine.Debug.Log("output: " + standard_output.ToString());
                if (standard_error.ToString() != "")
                    UnityEngine.Debug.LogError("errors: " + standard_error.ToString());
            }
            if (ifcConverter.ExitCode == 1) {
                UnityEngine.Debug.LogError("IFCOpenShell could not generate something.");
            }
        }
    }

    /// <summary>Instantiate DAE model using IFC file path. </summary>
    /// <param name="inputFile">File path to an IFC file relative to project root. If the file is in the project root folder, the filepath is just the name of the IFC file + the .ifc extension. </param>
    /// <returns>Instantiated DAE GameObject. </returns>
    
    public static GameObject LoadDae(string inputFile)
    {
        //Save files under Assets/IfcImporter/Resources so that we can access them later to create the prefab
        string resourceName = System.IO.Path.GetFileNameWithoutExtension(inputFile);
        string outputFile = "Assets/IfcImporter/Resources/" + System.IO.Path.GetFileNameWithoutExtension(inputFile);
        
        GameObject IfcDaeInstance = null;
        GameObject IfcDae = (GameObject)Resources.Load(resourceName + "_dae");
        
        //Create an instance of it, so that it actually exists in the game world
        IfcDaeInstance = Instantiate(IfcDae);
        
        //Load and parse the xml, with the brand new IfcDaeInstance as the root object
        return IfcDaeInstance;
    }
}
}
