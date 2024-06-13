using UnityEngine;
using IfcToolkit;

namespace IfcToolkitDemo {
/// <summary>An example Class that exports an IFC model on Start(). </summary>
public class RuntimeExportDemo : MonoBehaviour
{
    public GameObject ifcRootGameObject; // A reference to a root IFC GameObject in the scene, imported using the IFC importer

    void Start()
    {
        // Export edited IFC model to the Unity project's root directory
        IfcExporter.Export("From_ExporterDemo.ifc", ifcRootGameObject);
    }
}
}
