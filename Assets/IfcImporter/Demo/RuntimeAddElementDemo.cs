using UnityEngine;
using System.Collections.Generic;
using IfcToolkit;

namespace IfcToolkitDemo {
public class RuntimeAddElementDemo : MonoBehaviour
{
    public GameObject ifcRootGameObject;
    public Transform ifcBuildingStorey;
    
    void Start()
    {
        // Create example properties
        System.Random random = new System.Random();
        Dictionary<string,string> propertyDict = new Dictionary<string, string>(){
            {"PsetName", "PSet_Example"},
            {"id", IfcAttributes.GenerateIfcId(random)},
            {"ExampleProperty1", "example value 1"},
            {"ExampleProperty2", "example value 2"}
        };
        Dictionary<string,string> propertyDict2 = new Dictionary<string, string>(){
            {"PsetName", "PSet_Example2"},
            {"id", IfcAttributes.GenerateIfcId(random)},
            {"ExampleProperty1", "example value 1"},
            {"ExampleProperty2", "example value 2"}
        };
        // Create a new IFC cube and give the example properties to it
        GameObject ifcElement1 = NewIfcGameObject.InstantiateIfcGameObject("IfcProduct", "Example IFC cube", random, propertyDict);

        // Place the new cube into the IFC hierarchy
        ifcElement1.transform.parent = ifcBuildingStorey;

        // Create a new generic IFC element
        GameObject ifcElement2 = NewIfcGameObject.InstantiateIfcGameObject("IfcProduct", "Second example IFC cube", random, propertyDict2);

        // Move the new element to distinguish it from the first one
        ifcElement2.transform.position = new Vector3(0f, 7f, 0f);

        // Place the new element into the IFC hierarchy
        ifcElement2.transform.parent = ifcBuildingStorey;

        // Export edited IFC model to the Unity project's root directory
        IfcExporter.Export("From_AddElementDemo.ifc", ifcRootGameObject, random);
    }
}
}
