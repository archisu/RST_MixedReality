using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IfcToolkit {

/// <summary>IFC GameObject component for storing Ifc Attributes such as element type, name and id. </summary>
/// <remarks>This script stores IFC attribute data and returns values based on attribute name. 
/// It is attached to IFC gameobject by IfcXmlParser.cs .
/// IFC attribute data should contain information such as: Element type (e.g. IfcWallStandardCase, IfcSlab, IfcWindow, IfcDoor etc.), Unique IFC id, element name </remarks>
[ExecuteInEditMode]
public class IfcAttributes : MonoBehaviour
{
    public List<string> attributes = new List<string>();
    public List<string> values = new List<string>();

    ///<summary>Returns the value of the named attribute.</summary>
    ///<param name="name">Name of the desired attribute.</param>
    ///<returns>Value of the attribute as string.</returns>
    public string Find(string name){
        for(int i = 0; i < attributes.Count; i++){
            if(attributes[i] == name){
                return values[i];
            }
        }
        return null;
    }

    ///<summary>Create a new attribute.</summary>
    ///<param name="attribute">The name of the new attribute.</param>
    ///<param name="value">The value of the new attribute.</param>
    public void AddIfcAttribute(string attribute, string value){
        attributes.Add(attribute);
        values.Add(value);
    }

    ///<summary>Randomly generate a new ID used to identify various IFC entities.</summary>
    ///<param name="random">The random generator used to generate the ID. Can be used to make the function deterministic if desired.</param>
    ///<returns>A 22 character randomly generated string to be used as an ID.</returns>
    public static string GenerateIfcId(System.Random random) {
        // Generate random new IFC id
        string generatedId = "";
        string glyphs= "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";
        for(int i=0; i<22; i++){
            generatedId += glyphs[random.Next(glyphs.Length)];
            //generatedId += glyphs[Random.Range(0, glyphs.Length)];
        }
        // Regenerate id if it already exists
        return generatedId;
    }

    // The following section is for keeping track of moved IFC elements
    public Vector3 startPosition;

    void Start(){
        startPosition = transform.localPosition;
    }

}

}
