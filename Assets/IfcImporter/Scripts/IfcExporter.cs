using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using UnityEngine;
using System;

namespace IfcToolkit {

/// <summary>Class containing functions for exporting an IFC GameObject. </summary>
public class IfcExporter : MonoBehaviour
{
    /// <summary>The main user interface of IfcExporter, used to export IFC data from Unity to IFC files. </summary>
    /// <param name="outputFilepath">Filepath of the exported IFC file. For example "E:\my_project\my_file.ifc". Relative paths like "..\my_file.ifc" are also supported.</param>
    /// <param name="ifcRootGameObject">The root GameObject of an IFC model. </param>
    /// <param name="random"> A random number generator used to generate deterministic IFC IDs. </param>
    
    public static void Export(string outputFilepath, GameObject ifcRootGameObject, System.Random random = null) {
        if(random == null){
            random = new System.Random();
        }

        if (ifcRootGameObject.GetComponent<IfcFile>()) {
            // To get decimals with dots instead of commas
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            List<string> lines = GenerateIfcLines(ifcRootGameObject, random);

            File.WriteAllLines(outputFilepath, lines.ToArray());

            // reset cultureInfo
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;

            Debug.Log(Path.GetFullPath(outputFilepath) + " saved");
        }
    }

    /// <summary>The main user interface of IfcExporter, used to export IFC data from Unity to IFC files. </summary>
    /// <remarks>Used as a coroutine as opposed to a regular function.</remarks>
    /// <param name="outputFilepath">Filepath of the exported IFC file. For example "E:\my_project\my_file.ifc". Relative paths like "..\my_file.ifc" are also supported.</param>
    /// <param name="ifcRootGameObject">The root GameObject of an IFC model. </param>
    /// <param name="random"> A random number generator used to generate deterministic IFC IDs. </param>
    
    public static IEnumerator ExportCoroutine(string outputFilepath, GameObject ifcRootGameObject, System.Random random = null) {
        Debug.Log("Exporting "+outputFilepath+", please wait.");
        DateTime starttime = System.DateTime.Now;     // for measuring optimization
        if(random == null){
            random = new System.Random();
        }

        if (ifcRootGameObject.GetComponent<IfcFile>()) {
            // To get decimals with dots instead of commas
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            
            yield return GenerateIfcLinesCoroutine(ifcRootGameObject, random, (lines) => {
                //Callback function to get the output
                // the file is saved to the project root
                File.WriteAllLines(outputFilepath, lines.ToArray());
                Debug.Log(outputFilepath + " saved");
            });

            // reset cultureInfo
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
        }

        DateTime endtime = System.DateTime.Now;       // for measuring optimization
        Debug.Log("Time elapsed: " + (endtime - starttime));
    }

    /// <summary>Generate the lines of an IFC file.</summary>
    /// <param name="ifcRootGameObject">The root GameObject of an IFC model. </param>
    /// <param name="random"> A random number generator used to generate deterministic IFC IDs. </param>
    /// <returns>List of strings representing an Ifc model imported into and edited in Unity. </returns>
    public static List<string> GenerateIfcLines(GameObject ifcRootGameObject, System.Random random){
        IfcFile ifcFile = ifcRootGameObject.GetComponent<IfcFile>();
        string inputFilepath = ifcFile.ifcFilePath;
        string[] inputLines = System.IO.File.ReadAllLines(inputFilepath);
        IfcParser.ParseIfc(ifcFile, inputLines);
        List<string> lines = ProcessParsedLines(ifcFile, ifcRootGameObject, random);
        return lines;
    }

    ///<summary>Takes parsed input lines and produces the desired output.</summary>
    ///<remarks>Contains most of the shared portions of GenerateIfcLines() and GenerateIfcLinesCoroutine().</remarks>
    ///<param name="ifcFile">The IfcFile that containing the parsed input lines.</param>
    ///<param name="ifcRootGameObject">The root GameObject of an IFC model. </param>
    ///<param name="random"> A random number generator used to generate deterministic IFC IDs. </param>
    ///<returns>List of strings representing an Ifc model imported into and edited in Unity. </returns>

    public static List<string> ProcessParsedLines(IfcFile ifcFile, GameObject ifcRootGameObject, System.Random random) {
        // Add new IFC GameObjects
        foreach(NewIfcGameObject newIfcGameObject in ifcRootGameObject.transform.GetComponentsInChildren<NewIfcGameObject>()){
            NewIfcGameObject.IfcRowsToIfcFile(ifcRootGameObject, newIfcGameObject.transform.gameObject, random);
        }

        // Applying model changes
        //IfcEditor.UpdateAllIfcPositions(ifcFile); // Uncomment this and the section in IfcEditor.cs to activate experimental feature
        IfcEditor.UpdateIfcProperties(ifcFile, random);

        // Compile the lines into the structure of an IFC file
        List<string> lines = new List<string>();
        string postfix = ifcFile.ifcVersionPostfix;

        // Generate HEADER section
        lines.Add("ISO-10303-21;");
        lines.Add("HEADER;");
        foreach(IfcRow header_row in ifcFile.header_rows){
            lines.Add(header_row.ToString(postfix) + ";" );
        }
        lines.Add("ENDSEC;");
        
        // Generate DATA section
        lines.Add("DATA;");
        foreach(IfcRow r in ifcFile.ref_to_row.Values){
            lines.Add(r.ToString(postfix));
        }
        lines.Add("ENDSEC;");

        // Generate ending line
        lines.Add("END-ISO-10303-21;");
        return lines;
    }

    ///<summary>Finds first spatial structure parent, i.e. building, building storey or space.</summary>
    ///<param name="ifcElement">Any GameObject in an IFC hierarchy.</param>
    ///<returns>The spatial structure GameObject.</returns>
    public static GameObject GetParentSpatialStructure(GameObject ifcElement){
        if(ifcElement.transform.parent == null){
            throw new System.ArgumentException(ifcElement + " does not have a parent.");
        }
        if(ifcElement.transform.parent.GetComponent<IfcAttributes>() == null){
            throw new System.ArgumentException(ifcElement + " parent does not have an IfcAttributes component.");
        }

        // Find the first IfcBuildingStorey or IfcSpace parent of the element
        GameObject parent = ifcElement.transform.parent.gameObject;
        string parentElementType = parent.GetComponent<IfcAttributes>().Find("IfcElementType");
        if(parentElementType != "IfcBuildingStorey" && parentElementType != "IfcSpace" && parentElementType != "IfcBuilding"){
            // recursive loop to find the first grandparent IfcBuildingStorey or IfcSpace
            return GetParentSpatialStructure(parent);
        } else {
            return parent;
        }
    }

    ///<summary>Finds the ifc_reference of the IfcRow corresponding to the spatial structure GameObject.</summary>
    ///<param name="ifcFile">The IfcFile object used to store the IfcRows.</param>
    ///<param name="targetSpatialStructure">The GameObject representing the desired spatial structure such as a room.</param>
    ///<returns>The ifc_reference of the spatial structure, null if not found.</returns>
    public static string GetTargetSpatialStructureReference(IfcFile ifcFile, GameObject targetSpatialStructure){
        //Get Ifc reference to target spatial structure
        string targetSpatialStructureReference = null;
        if(targetSpatialStructure){
            string spatialStructureId = targetSpatialStructure.GetComponent<IfcAttributes>().Find("id");
            targetSpatialStructureReference = ifcFile.id_to_row["'"+spatialStructureId+"'"].ifc_reference;
        }
        return targetSpatialStructureReference;
    }

    /// <summary>Generate the lines of an IFC file.</summary>
    /// <param name="ifcRootGameObject">The root GameObject of an IFC model. </param>
    /// <param name="random"> A random number generator used to generate deterministic IFC IDs. </param>
    /// <returns>List of strings representing an Ifc model imported into and edited in Unity. </returns>
    public static IEnumerator GenerateIfcLinesCoroutine(GameObject ifcRootGameObject, System.Random random, Action<List<string>> callback){
        IfcFile ifcFile = ifcRootGameObject.GetComponent<IfcFile>();
        string inputFilepath = ifcFile.ifcFilePath;
        string[] inputLines = System.IO.File.ReadAllLines(inputFilepath);
        yield return IfcParser.ParseIfcCoroutine(ifcFile, inputLines);
        List<string> lines = ProcessParsedLines(ifcFile, ifcRootGameObject, random);
        callback(lines);
    }


    ///<summary>Get the proper coordinates from the transform of the GameObject and return them as a string.</summary>
    ///<param name="ifcElement">The IfcElement GameObject whose coordinates we are looking for.</param>
    ///<returns>The coordinates of the given GameObject as a string.</returns>
    private static string GetCoordinatesAsString(GameObject ifcElement)
    {
        // Get the proper coordinates from the transform of the GameObject and return them as a string
        // Ex. "(9.0,9.0,9.0)"
        return "("+ifcElement.transform.up.ToString()+","+ifcElement.transform.forward.ToString()+","+ifcElement.transform.right.ToString()+")";
    }


}
}
