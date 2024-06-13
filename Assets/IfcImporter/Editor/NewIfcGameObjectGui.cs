using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IfcToolkit {

/// <summary>Class that adds IFC GameObject creation functionality to the Unity editor top menu bar. </summary>
public class NewIfcGameObjectGui : EditorWindow
{

    [MenuItem("GameObject/IFC object/Generic object")]
    static void GenericObject()
    {
        System.Random random = new System.Random();
        Dictionary<string,string> propertyDict = new Dictionary<string, string>(){
            {"PsetName", "PSet_Generic_Specification"},
            {"Id", IfcAttributes.GenerateIfcId(random)},
            {"property1", "property value 1"},
            {"property2", "property value 2"}
        };
        NewIfcGameObject.InstantiateIfcGameObject("IfcProduct", "Generic IFC object", random, propertyDict);
    }
}
}
