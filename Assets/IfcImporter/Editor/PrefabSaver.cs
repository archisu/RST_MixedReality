using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IfcToolkit {

/// <summary>Class for saving prefabs in the editor. </summary>
/// <remarks>Only works in the editor because we use PrefabUtility.
/// Does not like the script created meshes IfcImporter.RuntimeImport() uses.
/// Usage: PrefabSaver.savePrefab() .
/// Usually called from IfcProcessor.OnPostProcess() or IfcEditorExtension.OnGUI() .</remarks>
public class PrefabSaver : MonoBehaviour
{
    ///<summary>Saves the GameObject as a prefab.</summary>
    ///<remarks>Destroys the object after it is saved.</remarks>
    ///<param name="root_object">The root of the GameObject hierarchy to be saved as a prefab.</param>
    ///<param name="assetPath">The folder within the Assets folder the prefab is to be save to, as well as the name of the file without extension.</param>
    public static void savePrefab(GameObject root_object, string assetPath)
    {
        //Save the prefab and get rid of the game object
        string prefab_path =  "Assets/" + System.IO.Path.GetFileNameWithoutExtension(assetPath) + ".prefab";
        PrefabUtility.SaveAsPrefabAsset(root_object, prefab_path);
        AssetDatabase.ImportAsset(prefab_path, ImportAssetOptions.ForceUpdate);
        DestroyImmediate(root_object);
    }
    
}
}
