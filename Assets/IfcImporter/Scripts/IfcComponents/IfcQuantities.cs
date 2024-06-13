using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IfcToolkit {

/// <summary>IFC GameObject component for storing IFC quantities data such as area, mass or volume. </summary>
public class IfcQuantities : MonoBehaviour
{
    public List<string> quantities = new List<string>();
    public List<string> values = new List<string>();

    ///<summary>Return corresponding value for quantity name.</summary>
    ///<param name="name">The name of the quantity.</param>
    ///<returns>The value of the quantity, null if not found.</returns>
    public string Find(string name){
        for(int i = 0; i < quantities.Count; i++){
            if(quantities[i] == name){
                return values[i];
            }
        }
        return null;
    }
}
}
