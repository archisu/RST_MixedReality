using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IfcToolkit {
public class IfcComponentGui : MonoBehaviour
{
    // Start is called before the first frame update
}

/// <summary>A class that changes the UI of IfcAttributes components in the Unity editor inspector. </summary>
[CustomEditor(typeof(IfcAttributes))]
public class IfcAttributeGui : Editor
{
    new IfcAttributes target;

    public override void OnInspectorGUI()
    {
        target = (IfcAttributes)base.target;

        for(int i = 0; i < target.attributes.Count; i++){
            //Write attributes to editor gui & enable editing the original value
            target.values[i] = EditorGUILayout.TextField(target.attributes[i], target.values[i]);
        }
    }
}

/// <summary>A class that changes the UI of IfcHeader components in the Unity editor inspector. </summary>
[CustomEditor(typeof(IfcHeader))]
public class IfcHeaderGui : Editor
{
    new IfcHeader target;

    public override void OnInspectorGUI()
    {
        target = (IfcHeader)base.target;

        for(int i = 0; i < target.headers.Count; i++){
            //Write header to editor gui & enable editing the original value
            target.values[i] = EditorGUILayout.TextField(target.headers[i], target.values[i]);
        }
    }
}

/// <summary>A class that changes the UI of IfcMaterials components in the Unity editor inspector. </summary>
[CustomEditor(typeof(IfcMaterials))]
public class ifcMaterialGui : Editor
{
    new IfcMaterials target;

    public override void OnInspectorGUI()
    {
        target = (IfcMaterials)base.target;

        for(int i = 0; i < target.materials.Count; i++){
            //Write materials to editor gui & enable editing the thicknessess
            target.thicknesses[i] = EditorGUILayout.TextField(target.materials[i], target.thicknesses[i]);
        }
    }
}

/// <summary>A class that changes the UI of IfcProperties components in the Unity editor inspector. </summary>
[CustomEditor(typeof(IfcProperties))]
public class IfcPropertyGui : Editor
{
    new IfcProperties target;

    public override void OnInspectorGUI()
    {
        target = (IfcProperties)base.target;

        EditorGUI.indentLevel++;
        for(int i = 0; i < target.properties.Count; i++){
            if(target.properties[i] == "PsetName"){
                //Write IfcPropertySet name
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(target.nominalValues[i], "");
                EditorGUI.indentLevel++;
            }
            else{
                //Write properties to editor gui & enable editing the original value
                target.nominalValues[i] = EditorGUILayout.TextField(target.properties[i], target.nominalValues[i]);
            }
        }
        EditorGUI.indentLevel--;
        
        if(GUI.changed){
            target.MarkChangedIfcProperties();
        }
    }
}

/// <summary>A class that changes the UI of IfcQuantities components in the Unity editor inspector. </summary>
[CustomEditor(typeof(IfcQuantities))]
public class IfcQuantityGui : Editor
{
    new IfcQuantities target;

    public override void OnInspectorGUI()
    {
        target = (IfcQuantities)base.target;

        for(int i = 0; i < target.quantities.Count; i++){
            //Write quantities to editor gui & enable editing the original value
            target.values[i] = EditorGUILayout.TextField(target.quantities[i], target.values[i]);
        }
    }
}

/// <summary>A class that changes the UI of IfcTypes components in the Unity editor inspector. </summary>
[CustomEditor(typeof(IfcTypes))]
public class IfcTypesGui : Editor
{
    new IfcTypes target;

    public override void OnInspectorGUI()
    {
        target = (IfcTypes)base.target;

        for(int i = 0; i < target.types.Count; i++){
            //Write types to editor gui & enable editing the original value
            target.values[i] = EditorGUILayout.TextField(target.types[i], target.values[i]);
        }
    }
}

}
