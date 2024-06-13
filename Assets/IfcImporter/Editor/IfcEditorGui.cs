using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IfcToolkit {

/// <summary>Class that adds IFC GameObject editing functionality to the Unity editor top menu bar. </summary>
public class IfcEditorGui : MonoBehaviour
{
    [MenuItem("Edit/Mark changed IfcGameObject properties")]
    public static void MarkChangedIfcObjectProperties(){
        foreach (Transform t in Selection.transforms){
            if(t.GetComponent<IfcAttributes>()){
                string id = t.GetComponent<IfcAttributes>().Find("id");
                //Add id to IfcFile.changedTransformsById
                t.GetComponentInParent<IfcFile>().changedIfcPropertiesById.Add(id);
                Debug.Log(id + " added to ifc root IfcFile.changedIfcPropertiesById");
            }
        }
    }
}
}
