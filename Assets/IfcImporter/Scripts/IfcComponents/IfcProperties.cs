using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IfcToolkit {

/// <summary>IFC GameObject component for storing IFC property set data. </summary>
/// <remarks>This script stores IFC property data and returns values based on property name.
/// It is attached to each IFC gameobject with property data by IfcXmlParser.cs .
/// IFC property data contains a lot of varied information based on the element type, origin software and the designers preferences.
/// A wall may include information such as: load bearing, external structure, fire rating, U-value, assembly code, manufacturer or any other data that the designer chooses to add.
/// </remarks>
public class IfcProperties : MonoBehaviour {
    public List<string> properties = new List<string>();
    public List<string> nominalValues = new List<string>();

    ///<summary>Add a new IfcProperty.</summary>
    ///<param name="property">The name of the property.</param>
    ///<param name="value">The value to be assigned to the property.</param>
    public void AddIfcProperty(string property, string value){
        properties.Add(property);
        nominalValues.Add(value);
    }

    ///<summary>Return corresponding nominalValue for property name.</summary>
    ///<param name="name">The name of the property we are looking for.</param>
    ///<returns>The value of the named property, null if not found.</returns>
    public string Find(string name){
        for(int i = 0; i < properties.Count; i++){
            if(properties[i] == name){
                return nominalValues[i];
            }
        }
        return null;
    }

    ///<summary>Change a property's value.</summary>
    ///<param name="name">The name of the property we want to change.</param>
    ///<param name="value">The new value.</param>
    public void ChangeValue(string name, string value){
        for(int i = 0; i < properties.Count; i++){
            if(properties[i] == name){
                nominalValues[i] = value;
            }
        }
    }

    ///<summary>Mark the IfcProperties component as changed.</summary>
    public void MarkChangedIfcProperties(){
        Transform t = this.transform;
        string id = t.GetComponent<IfcAttributes>().Find("id");
        //Add id to IfcFile.changedTransformsById
        t.GetComponentInParent<IfcFile>().changedIfcPropertiesById.Add(id);
    }
}
}
