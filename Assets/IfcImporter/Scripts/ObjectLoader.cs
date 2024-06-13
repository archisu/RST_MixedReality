

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using System.Threading;
using System.Linq;

namespace IfcToolkit {

/// <summary>Class for runtime OBJ importing. </summary>
/// <remarks>This is needed as Unity does not include 3d model importing functionality in builds.
/// Usage: ObjectLoader.Load(string directory_path, string filename), returns the root object.
/// Usually called from IfcImporter.RuntimeImport().</remarks>
public class ObjectLoader : MonoBehaviour {

    /// <summary>Struct for storing the geometric data of an OBJ file. </summary>
    public struct ObjData {
        public string name;
        public string mtllib;       // Related .mtl file
        public List<string> usemtl; // Name of the material that should be used
        public List<Vector3> v;     // Geometric vertices
        public List<Vector3> vn;    // Vertex normals
        public List<Vector2> vt;    // Texture vertices
        public List<List<int[]>> f; // Face
    }

    /// <summary>Struct for storing the material data of an OBJ file. </summary>
    public struct MtlData {
        public List<string> name;
        public Dictionary<string, Color> kd;
    }
    
    ///<summary>Create a new ObjData structure instance.</summary>
    ///<returns>An empty ObjData structure.</returns>
    private static ObjData NewObjData() {
        ObjData obj = new ObjData ();
        obj.usemtl = new List<string> ();
        obj.v = new List<Vector3> ();
        obj.vn = new List<Vector3> ();
        obj.vt = new List<Vector2> ();
        obj.f = new List<List<int[]>> ();
        return obj;
    }

    ///<summary>Reades the .obj file and store each mesh as a separate ObjData structure.</summary>
    ///<param name="path">The path to the .obj file.</param>
    ///<returns>A list of ObjData structures, with each ObjData representing a single mesh.</returns>
    public static List<ObjData> ReadObjData (string path) {
        string name = "";
        string mtllib = "";
        int vertex_count = 0;

        ObjData obj = NewObjData();
        List<ObjData> objs = new List<ObjData>();
        
        string[] lines = File.ReadAllLines (path);


        foreach (string line in lines) {
            if (line == "" || line.StartsWith ("#"))
                continue;
            string[] token = line.Split (' ');
            //Useful debugging snippet - exclude lines we're not interested in, print the rest
            /*string[] excludes = new string[]{"v", "vn", "s"};
            if (!excludes.Contains(token[0])){
                UnityEngine.Debug.Log(line);
            }*/

            switch (token [0]) {
            case ("o"):
                name = token [1];
                obj.name = name;
                break;
            case ("mtllib"):
                mtllib = token [1];
                obj.mtllib = mtllib;
                break;
            case ("usemtl"):
                obj.usemtl.Add (token [1]);
                obj.f.Add (new List<int[]> ());
                break;
            case ("v"):
                obj.v.Add (new Vector3 (
                    float.Parse (token [1]),
                    float.Parse (token [2]),
                    float.Parse (token [3])));
                break;
            case ("vn"):
                obj.vn.Add (new Vector3 (
                    float.Parse (token [1]),
                    float.Parse (token [2]),
                    float.Parse (token [3])));
                break;
            case ("vt"):
                obj.vt.Add (new Vector3 (
                    float.Parse (token [2]),
                    float.Parse (token [1])));
                break;
            case ("g"):
                //A new groupname means a new part of the building - let's store the previous one and start a new mesh
                objs.Add(obj);
                vertex_count += obj.v.Count;
                obj = NewObjData();
                obj.mtllib = mtllib;
                obj.name = token [1];
                break;
            case ("f"):
                for (int i = 1; i < 4; i += 1) {
                    int[] triplet = Array.ConvertAll (token [i].Split ('/'), x => {
                        if (String.IsNullOrEmpty (x))
                            return 0;
                        return int.Parse (x) - vertex_count;
                    });
                    obj.f [obj.f.Count - 1].Add (triplet);
                }
                break;
            }
        }
        objs.Add(obj);
        //Root object that shouldn't contain anything of value
        objs.RemoveAt(0);
        return objs;
    }

    ///<summary>Reades the .obj file and store each mesh as a separate ObjData structure.</summary>
    ///<param name="path">The path to the .obj file.</param>
    ///<param name="callback">A callback function used to access the resulting list of ObjDatas outside the function.</param>
    public static IEnumerator ReadObjDataCoroutine (string path, CultureInfo originalCulture, CultureInfo originalUiCulture, Action<List<ObjData>> callback) {
        string name = "";
        string mtllib = "";
        int vertex_count = 0;
        CultureInfo culture = new CultureInfo("en-US");

        ObjData obj = NewObjData();
        List<ObjData> objs = new List<ObjData>();
        
        string[] lines = File.ReadAllLines (path);


        int j = 0;
        foreach (string line in lines) {
            if (j >= 10000) {
                Thread.CurrentThread.CurrentUICulture = originalUiCulture;
                Thread.CurrentThread.CurrentCulture = originalCulture;
                yield return null;
                originalCulture = Thread.CurrentThread.CurrentCulture;
                originalUiCulture = Thread.CurrentThread.CurrentUICulture;
                Thread.CurrentThread.CurrentUICulture = culture;
                Thread.CurrentThread.CurrentCulture = culture;
                j = 0;
            }
            j++;
            if (line == "" || line.StartsWith ("#"))
                continue;
            string[] token = line.Split (' ');
            //Useful debugging snippet - exclude lines we're not interested in, print the rest
            /*string[] excludes = new string[]{"v", "vn", "s"};
            if (!excludes.Contains(token[0])){
                UnityEngine.Debug.Log(line);
            }*/

            switch (token [0]) {
            case ("o"):
                name = token [1];
                obj.name = name;
                break;
            case ("mtllib"):
                mtllib = token [1];
                obj.mtllib = mtllib;
                break;
            case ("usemtl"):
                obj.usemtl.Add (token [1]);
                obj.f.Add (new List<int[]> ());
                break;
            case ("v"):
                obj.v.Add (new Vector3 (
                    float.Parse (token [1]),
                    float.Parse (token [2]),
                    float.Parse (token [3])));
                break;
            case ("vn"):
                obj.vn.Add (new Vector3 (
                    float.Parse (token [1]),
                    float.Parse (token [2]),
                    float.Parse (token [3])));
                break;
            case ("vt"):
                obj.vt.Add (new Vector3 (
                    float.Parse (token [2]),
                    float.Parse (token [1])));
                break;
            case ("g"):
                //A new groupname means a new part of the building - let's store the previous one and start a new mesh
                objs.Add(obj);
                vertex_count += obj.v.Count;
                obj = NewObjData();
                obj.mtllib = mtllib;
                obj.name = token [1];
                break;
            case ("f"):
                for (int i = 1; i < 4; i += 1) {
                    int[] triplet = Array.ConvertAll (token [i].Split ('/'), x => {
                        if (String.IsNullOrEmpty (x))
                            return 0;
                        return int.Parse (x) - vertex_count;
                    });
                    obj.f [obj.f.Count - 1].Add (triplet);
                }
                break;
            }
        }
        objs.Add(obj);
        //Root object that shouldn't contain anything of value
        objs.RemoveAt(0);
        callback(objs);
    }



    ///<summary>Reads the material data from a .mtl file.</summary>
    ///<param name="path">The path to the .mtl file.</param>
    ///<returns>A MtlData structure containing the material data.</returns>
    public static MtlData ReadMtlData (string path) {
        MtlData mtl = new MtlData ();
        string[] lines = File.ReadAllLines (path);

        mtl.name = new List<string> ();
        mtl.kd = new Dictionary<string, Color> ();
        string currmtl = "";

        foreach (string line in lines) {
            if (line == "" || line.StartsWith ("#"))
                continue;

            string[] token = line.Split (' ');
            switch (token [0]) {

            case ("newmtl"):
                mtl.name.Add (token [1]);
                currmtl = token[1];
                break;
            case ("Kd"): //Color rgb value
                //If we already have an alpha value, use it
                if (mtl.kd.ContainsKey(currmtl)) {
                    mtl.kd[currmtl] = new Color(float.Parse(token[1]), float.Parse(token[2]), float.Parse(token[3]), mtl.kd[currmtl].a);
                }
                else { //New color, use default alpha of 1.0f
                    mtl.kd[currmtl] = new Color(float.Parse(token[1]), float.Parse(token[2]), float.Parse(token[3]), 1.0f);
                }
                break;
            case ("d"): //Color alpha
                //If we already have rgb values, just update alpha
                if (mtl.kd.ContainsKey(currmtl)) {
                    float r = mtl.kd[currmtl].r;
                    float g = mtl.kd[currmtl].g;
                    float b = mtl.kd[currmtl].b;
                    mtl.kd[currmtl] = new Color(r, g, b, float.Parse(token[1]));
                }
                else { //New color
                    mtl.kd[currmtl] = new Color(0,0,0, float.Parse(token[1]));
                }
                break;
            }
        }
        return mtl;
    }

    ///<summary>Creates a GameObject from a .obj file.</summary>
    ///<param name="directory_path">Path to the directory the file is in.</param>
    ///<param name="filename">The name of the .obj file.</param>
    ///<param name="options"> Optional IFC import options. </param>
    ///<returns>A GameObject created from the .obj file.</returns>
    public static GameObject Load (string directory_path, string filename, IfcSettingsOptionHolder options) {
        GameObject root_object = ConstructModel (filename, directory_path, options);
        TreeBuilder.ReconstructTree(root_object);
        return root_object;
    }

    ///<summary>Creates a GameObject from a .obj file.</summary>
    ///<remarks>OBJ files do not contain the original IFC hierarchy. It must be reconstructed later based on a separate XML file.</remarks>
    ///<param name="filename">The name of the .obj file.</param>
    ///<param name="directory_path">The path to the directory the file is in.</param>
    ///<param name="options"> Optional IFC import options. </param>
    ///<returns>A GameObject created from the .obj file.</param>
    private static GameObject ConstructModel (string filename, string directory_path, IfcSettingsOptionHolder options) {
        //Needed to make file IO use correct floating point separators etc regardless of region
        CultureInfo culture = new CultureInfo("en-US");
        CultureInfo originalUiCulture = Thread.CurrentThread.CurrentUICulture;
        CultureInfo originalCulture = Thread.CurrentThread.CurrentCulture;
        Thread.CurrentThread.CurrentUICulture = culture;
        Thread.CurrentThread.CurrentCulture = culture;
        
        GameObject root_object = new GameObject();

        List<ObjData> objs = ReadObjData (directory_path + filename);
        root_object.name = filename.Split ('.')[0];
        MtlData? mtl = null;
        if (objs[0].mtllib != "") {
            //All our materials come from the same .mtl file, so let's just grab the first one
            mtl = ReadMtlData (directory_path + objs[0].mtllib);
        }
        else
        {
            string mtl_default = directory_path + filename.Replace(".obj", ".mtl");
            if (File.Exists(mtl_default))
                mtl = ReadMtlData (mtl_default);
            else
                Debug.Log("Material file not found.");
        }
        
        Mesh[] meshes = PopulateMesh(objs, options);
        
        for (int i = 0; i < objs.Count; i++) {
            GameObject childObject = new GameObject();
            childObject.transform.parent = root_object.transform;
            MeshFilter mf = childObject.AddComponent<MeshFilter> ();
            MeshRenderer mr = childObject.AddComponent<MeshRenderer> ();
            mf.mesh = meshes[i];
            if (mtl != null) {
                Material[] materials = DefineMaterial (objs[i], (MtlData)mtl);
                mr.materials = materials;
            }
            childObject.name = meshes[i].name;
        }

        //reset cultureinfo
        Thread.CurrentThread.CurrentUICulture = originalUiCulture;
        Thread.CurrentThread.CurrentCulture = originalCulture;
        return root_object;
    }

    ///<summary>Creates a GameObject from a .obj file.</summary>
    ///<param name="directory_path">Path to the directory the file is in.</param>
    ///<param name="filename">The name of the .obj file.</param>
    ///<param name="options"> Optional IFC import options. </param>
    ///<param name="callback">A callback function used to access the root GameObject outside the function.</param>
    public static IEnumerator LoadCoroutine (string directory_path, string filename, IfcSettingsOptionHolder options, Action<GameObject> callback) {
        yield return ConstructModelCoroutine(filename, directory_path, options, (root_object) => {
            TreeBuilder.ReconstructTree(root_object);
            callback(root_object);
        });
    }

    ///<summary>Creates a GameObject from a .obj file.</summary>
    ///<remarks>OBJ files do not contain the original IFC hierarchy. It must be reconstructed later based on a separate XML file.</remarks>
    ///<param name="filename">The name of the .obj file.</param>
    ///<param name="directory_path">The path to the directory the file is in.</param>
    ///<param name="options"> Optional IFC import options. </param>
    ///<param name="callback">A callback function used to access the root GameObject outside the function.</param>
    private static IEnumerator ConstructModelCoroutine (string filename, string directory_path, IfcSettingsOptionHolder options, Action<GameObject> callback) {
        //Needed to make file IO use correct floating point separators etc regardless of region
        CultureInfo culture = new CultureInfo("en-US");
        CultureInfo originalUiCulture = Thread.CurrentThread.CurrentUICulture;
        CultureInfo originalCulture = Thread.CurrentThread.CurrentCulture;
        Thread.CurrentThread.CurrentUICulture = culture;
        Thread.CurrentThread.CurrentCulture = culture;
        
        GameObject root_object = new GameObject();

        yield return ReadObjDataCoroutine(directory_path + filename, originalCulture, originalUiCulture, (objs) => {
            root_object.name = filename.Split ('.')[0];
            MtlData? mtl = null;
            if (objs[0].mtllib != "") {
                //All our materials come from the same .mtl file, so let's just grab the first one
                mtl = ReadMtlData (directory_path + objs[0].mtllib);
            }
            else
            {
                string mtl_default = directory_path + filename.Replace(".obj", ".mtl");
                if (File.Exists(mtl_default))
                    mtl = ReadMtlData (mtl_default);
                else
                    Debug.Log("Material file not found.");
            }
            
            Mesh[] meshes = PopulateMesh(objs, options);
            
            for (int i = 0; i < objs.Count; i++) {
                GameObject childObject = new GameObject();
                childObject.transform.parent = root_object.transform;
                MeshFilter mf = childObject.AddComponent<MeshFilter> ();
                MeshRenderer mr = childObject.AddComponent<MeshRenderer> ();
                mf.mesh = meshes[i];
                if (mtl != null) {
                    Material[] materials = DefineMaterial (objs[i], (MtlData)mtl);
                    mr.materials = materials;
                }
                childObject.name = meshes[i].name;
            }
            //reset cultureinfo
            Thread.CurrentThread.CurrentUICulture = originalUiCulture;
            Thread.CurrentThread.CurrentCulture = originalCulture;
            callback(root_object);
        });
    }


    ///<summary>Creates the meshes the GameObject is made of.</summary>
    ///<param name="objs">The ObjData read from the .obj file.</param>
    ///<param name="options"> Optional IFC import options. </param>
    ///<returns>The created meshes stored in an array.</returns>
    private static Mesh[] PopulateMesh (List<ObjData> objs, IfcSettingsOptionHolder options) {
        Mesh[] meshes = new Mesh[objs.Count];
        //Offset for moving the model closer to origin
        //Depending on the options either Vector3.zero or average vertex position
        Vector3 offset = CalculateOffset(objs, options);
        for (int k = 0; k < objs.Count; k++) {
            ObjData obj = objs[k];
            List<int[]> triplets = new List<int[]> ();
            List<int> submeshes = new List<int> ();
            for (int i = 0; i < obj.f.Count; i += 1) {
                for (int j = 0; j < obj.f [i].Count; j += 1) {
                    triplets.Add (obj.f [i] [j]);
                }
                submeshes.Add (obj.f [i].Count);
            }
            
            

            Vector3[] vertices = new Vector3[triplets.Count];
            Vector3[] normals = new Vector3[triplets.Count];
            Vector2[] uvs = new Vector2[triplets.Count];

            for (int i = 0; i < triplets.Count; i += 1) {
                //Apply offset
                vertices [i] = obj.v [triplets [i] [0] - 1] - offset;
                //Different coordinate systems - flip the x-axis.
                vertices[i][0] = -vertices[i][0];
                normals [i] = obj.vn [triplets [i] [2] - 1];
                if (triplets [i] [1] > 0)
                    uvs [i] = obj.vt [triplets [i] [1] - 1];
            }

            Mesh mesh = new Mesh ();
            mesh.name = obj.name;//groupname;
            mesh.vertices = vertices;
            mesh.normals = normals;
            mesh.uv = uvs;
            mesh.subMeshCount = submeshes.Count;
            int vertex = 0;
            for (int i = 0; i < submeshes.Count; i += 1) {
                int[] triangles = new int[submeshes [i]];
                for (int j = 0; j < submeshes [i]; j += 1) {
                    triangles [j] = vertex;
                    vertex += 1;
                }
                //Meshes are inside out because we flipped the x-axis. This fixes it.
                triangles = triangles.Reverse().ToArray();
                mesh.SetTriangles(triangles, i);
            }
            mesh.RecalculateBounds();
            mesh.Optimize ();
            meshes[k] = mesh;
        }
        return meshes;
    }

    ///<summary>Calculates the offset for moving vertices in PopulateMesh.</summary>
    ///<remarks>Depending on the "keepOriginalPositionForPartsEnabled" and "keepOriginalPosition" options either Vector3.zero or the average position of vertices.</remarks>
    ///<param name="objs">The ObjData read from the .obj file.</param>
    ///<param name="options"> Optional IFC import options. </param>
    ///<returns>Vector3 offset for vertices.</returns>
    private static Vector3 CalculateOffset(List<ObjData> objs, IfcSettingsOptionHolder options) {
        //If neither of the do-not-relocate options have been set to false..
        //This is to avoid confusion, since obj has no positions for anything but vertices
        if (options.keepOriginalPositionForPartsEnabled && options.keepOriginalPositionEnabled) {
            return Vector3.zero;
        }
        //If we do want to relocate..
        else {
            Vector3 offset = Vector3.zero;
            int vertex_count = 0;
            foreach(ObjData obj in objs) {
                foreach(Vector3 vertex in obj.v) {
                    vertex_count++;
                    offset += vertex;
                }
            }
            offset = offset / vertex_count;
            return offset;
        }
    }

    ///<summary>Creates the materials used by a mesh.</summary>
    ///<param name="obj">The ObjData corresponding to a mesh.</param>
    ///<param name="mtl">The MtlData naming various colors used by the mesh.</param>
    ///<returns>An array of Materials.</returns>
    private static Material[] DefineMaterial (ObjData obj, MtlData mtl) {

        Material[] materials = new Material[obj.usemtl.Count];
        Material ifcTransparent = Resources.Load("RequiredMaterials/ifcTransparent") as Material;
        Material ifcOpaque = Resources.Load("RequiredMaterials/ifcOpaque") as Material;

        for (int i = 0; i < obj.usemtl.Count; i += 1) {
            string mtl_name = obj.usemtl [i];

            Texture2D texture = new Texture2D (1, 1);
            Color[] cols = texture.GetPixels();
            if (!mtl.kd.ContainsKey(mtl_name)) {
                continue;
            }
            Color mtl_color = mtl.kd[mtl_name];
            for (int j = 0; j < cols.Length; ++j)
            {
                cols[j] = mtl_color;
            } 
            texture.SetPixels(cols);
            texture.Apply();
            //materials [i] = new Material (Shader.Find ("Standard"));
            try{
                if (mtl_color.a < 1.0f) {
                    materials [i] = new Material (ifcTransparent);
                }
                else {
                    materials [i] = new Material (ifcOpaque);
                }
            } catch {
                UnityEngine.Debug.LogError("Can't find ifcTransparent and ifcOpaque materials in the Assets/IfcImporter/Resources/RequiredMaterials folder.");
                throw;
            }
            materials [i].name = mtl_name;
            materials [i].color = mtl_color;
            
            //So this works in editor but not on runtime. BUT! If we save the material generated by this, we can use and recolor that on runtime.
            /*if (mtl_color.a < 1.0f) {
                materials [i].SetFloat("_Mode", 3);
         
                materials [i].SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                materials [i].SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                materials [i].SetInt("_ZWrite", 0);
                materials [i].DisableKeyword("_ALPHATEST_ON");
                materials [i].EnableKeyword("_ALPHABLEND_ON");
                materials [i].DisableKeyword("_ALPHAPREMULTIPLY_ON");
                materials [i].renderQueue = 3000;
         
         
            }*/
            //materials [i].mainTexture = texture;
        }
        return materials;
    }
}
}
