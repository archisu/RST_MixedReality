using UnityEngine;
using IfcToolkit;

namespace IfcToolkitDemo {
public class RuntimeSimpleExportDemo : MonoBehaviour
{
    // This is a reference to the gameobject of an imported IFC model
    public GameObject ifcRootGameObject;
    
    void Start()
    {
        // Export edited IFC model to the Unity project's root directory 
        IfcExporter.Export("From_SimpleExporterDemo.ifc", ifcRootGameObject);
    }
}
}
