using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IfcToolkit {

/// <summary>A class that can be stores and finds IFC GameObjects based on id, element type and presentation layer. </summary>
/// <remarks>The component is attached to the IFC root gameobject by IfcXmlParser.cs</remarks>

public class IfcRootLists : MonoBehaviour
{
    // These are populated by IfcXmlParser
    public List<GameObject> ifcGameObject = new List<GameObject>();
    public List<string> ifcId = new List<string>();
    public List<string> ifcElementType = new List<string>();
    public List<string> ifcPresentationLayer = new List<string>();

    ///<summary>Find an IFC GameObject using its ifc id.</summary>
    ///<param name="id">The IFC id of the GameObject.</param>
    ///<returns>The GameObject with the matching IFC id, null if not found.</returns>
    public GameObject FindIfcGameObject(string id){
        for(int i = 0; i < ifcId.Count; i++){
            if(ifcId[i] == id){
                return ifcGameObject[i];
            }
        }
        return null;
    }

    ///<summary>Find all GameObjects with a specific element type.(e.g. IfcWallStandardCase)</summary>
    ///<param name="elementTypeName">The name of the desired element type.</param>
    ///<returns>A list of GameObjects of the chosen element type, empty list if not found.</returns>
    public List<GameObject> FindIfcElementTypeGameObjects(string elementTypeName){
        List<GameObject> elementGameObjects = new List<GameObject>();
        for(int i = 0; i < ifcElementType.Count; i++){
            if(ifcElementType[i] == elementTypeName){
                elementGameObjects.Add( ifcGameObject[i] );
            }
        }
        return elementGameObjects;
    }

    ///<summary>Find all GameObjects on an IFC presentation layer.</summary>
    ///<param name="layerName">The name of the desired layer.</param>
    ///<returns>List of GameObjects of the chosen IFC layer, empty list of not found.</returns>
    public List<GameObject> FindIfcLayerGameObjects(string layerName){
        List<GameObject> layerGameObjects = new List<GameObject>();
        for(int i = 0; i < ifcPresentationLayer.Count; i++){
            if(ifcPresentationLayer[i] == layerName){
                layerGameObjects.Add( ifcGameObject[i] );
            }
        }
        return layerGameObjects;
    }

    ///<summary>Enable or disable ifc GameObjects on an IFC presentation layer.</summary>
    ///<param name="layerName">The name of the layer to enable or disable.</param>
    ///<param name="enabled">A boolean to toggle the layer on or off.</param>
    public void IfcLayerSetActive(string layerName, bool enabled){
        for(int i = 0; i < ifcPresentationLayer.Count; i++){
            if(ifcPresentationLayer[i] == layerName){
                ifcGameObject[i].SetActive(enabled);
            }
        }
    }
    
    ///<summary>Enable or disable ifc GameObjects of named element type (e.g. IfcWallStandardCase).</summary>
    ///<param name="elementTypeName">The name of the element type to enable or disable.</param>
    ///<param name="enabled">A boolean to toggle the element type on or off.</param>
    public void IfcElementTypeSetActive(string elementTypeName, bool enabled){
        for(int i = 0; i < ifcElementType.Count; i++){
            if(ifcElementType[i] == elementTypeName){
                ifcGameObject[i].SetActive(enabled);
            }
        }
    }

}
}
