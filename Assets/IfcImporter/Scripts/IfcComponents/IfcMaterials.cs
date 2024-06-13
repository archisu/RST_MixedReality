using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IfcToolkit {

/// <summary>IFC GameObject component for storing IFC materials data. </summary>
/// <remarks> This script stores IfcMaterial, IfcMaterialList and IfcMaterialLayerSetUsage data as material layers.
/// The script also returns values based on material layer name.
/// It is attached to each IFC gameobject with material data by IfcXmlParser.cs .
/// IFC material layers may contain one or more layers with or without thicknessess.</remarks>
public class IfcMaterials : MonoBehaviour
{
    public List<string> materials = new List<string>();
    public List<string> thicknesses = new List<string>();

    ///<summary>Return first thickness for material layer name.</summary>
    ///<param name="name">The name of the material.</param>
    ///<returns>The first thickness of the named material layer.</returns>
    public string Find(string name){
        for(int i = 0; i < materials.Count; i++){
            if(materials[i] == name){
                return thicknesses[i];
            }
        }
        return null;
    }

}
}
