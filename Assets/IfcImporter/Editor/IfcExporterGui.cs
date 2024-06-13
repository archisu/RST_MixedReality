using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

using System.IO;

namespace IfcToolkit {

/// <summary>Class for exporting IFC GameObjects from the Unity editor menu bar.</summary>
public class IfcExporterGui : EditorWindow
{
    /// <summary>Export the IFC GameObjects selected in the Unity editor to IFC files. This function is called from the menu bar under "Assets/Export selected IFC...". </summary>
    [MenuItem("Assets/Export selected IFC...")]
    public static void ExportSelectedIFC(){
        bool ifcSelected = false;
        foreach (Transform t in Selection.transforms){

            // IfcRootGameObject selected for export
            if(t.GetComponent<IfcFile>()){
                Debug.Log("Exporting only IFC model");
                IfcExporter.Export("From_UnityEditor.ifc", t.gameObject);
                ifcSelected = true;
            }
        }
        if(!ifcSelected){
            Debug.Log("No IFC selected in the editor! Please select one or more GameObjects containing the IfcFile component.");
        }
    }

}
}
