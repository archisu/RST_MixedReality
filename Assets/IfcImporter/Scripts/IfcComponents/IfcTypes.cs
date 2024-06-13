using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IfcToolkit {

/// <summary>IFC GameObject component for storing IFC types and styles data. </summary>
/// <remarks>The component is attached to each IFC gameobject with type or style data by IfcXmlParser.cs .
/// The information in IFC types and styles is essentially similar to that in IFC property sets.</remarks>
public class IfcTypes : MonoBehaviour
{
    public List<string> types = new List<string>();
    public List<string> values = new List<string>();

    ///<summary>Return corresponding value for type entry name.</summary>
    ///<param name="name">The name of the desired type.</param>
    ///<returns>The value of the type entry, null if not found.</returns>
    public string Find(string name){
        for(int i = 0; i < types.Count; i++){
            if(types[i] == name){
                return values[i];
            }
        }
        return null;
    }
}
}
