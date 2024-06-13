using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IfcToolkit {

/// <summary>IFC GameObject component for storing Ifc header data such as IFC schema, author and design software. </summary>
/// <remarks>This script stores IFC header data and returns values based on header name.
/// It is attached to the ifc root gameobject by IfcXmlParser.cs .</remarks>
public class IfcHeader : MonoBehaviour
{
    public List<string> headers = new List<string>();
    public List<string> values = new List<string>();

    // Return corresponding value for header name
    public string Find(string name){
        for(int i = 0; i < headers.Count; i++){
            if(headers[i] == name){
                return values[i];
            }
        }
        return null;
    }
}
}
