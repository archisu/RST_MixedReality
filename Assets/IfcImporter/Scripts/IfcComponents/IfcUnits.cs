using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IfcToolkit {

/// <summary>IFC GameObject component for storing IFC units data such as if length units are in meters, feet or something else. </summary>
/// <remarks>The component It is attached to the ifc root gameobject by IfcXmlParser.cs .</remarks>
public class IfcUnits : MonoBehaviour
{
    /*
    This script stores IFC units data.
    It is attached to the ifc root gameobject by IfcXmlParser.cs
    IFC units describes the units used in the model, such as lengths are in meters
    */
    public List<string> unitType = new List<string>();
    public List<string> unitName = new List<string>();
    public List<string> si_equivalent = new List<string>();

    ///<summary>Return a unit type's name.</summary>
    ///<remarks>For example UnitTypeName("LENGTHUNIT") may return "FOOT".</remarks>
    ///<param name="type">The type of the desired unit.</param>
    ///<returns>The name of the unit for the named unit type, null if not found.</returns>
    public string Find(string type){
        for(int i = 0; i < unitType.Count; i++){
            if(unitType[i] == type){
                return unitName[i];
            }
        }
        return null;
    }

    ///<summary>Return a unit type's divisor to convert it to the international System of Units.</summary>
    ///<remarks>If the unit is foot, the returned SI Equivalent would be "0.30480000000000002".</remarks>
    ///<param name="type">The type of unit we want the SI equivalent of.</param>
    ///<returns>The name of the SI equivalent unit, null if not found.</returns>
    public string FindSIEquivalent(string type){
        for(int i = 0; i < unitType.Count; i++){
            if(unitType[i] == type){
                return si_equivalent[i];
            }
        }
        return null;
    }
}
}
