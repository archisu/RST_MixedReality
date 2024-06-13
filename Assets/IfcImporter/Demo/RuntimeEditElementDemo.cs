using UnityEngine;
using IfcToolkit;

namespace IfcToolkitDemo {
public class RuntimeEditElementDemo : MonoBehaviour
{
    public GameObject ifcRootGameObject;
    public GameObject ifcElement;
    void Start()
    {
        // Move the element, this unfortunately does not work properly
        // ifcElement.transform.Translate(Vector3.up * 3, Space.World);

        // Add the changed element's id to changedTransformsById
        string elementId = ifcElement.GetComponent<IfcAttributes>().Find("id");
        ifcRootGameObject.GetComponent<IfcFile>().changedTransformsById.Add(elementId);

        // Change one of the element's properties
        ifcElement.GetComponent<IfcProperties>().ChangeValue("IsExternal", "true");

        // Add the changed element's id to changedIfcPropertiesById
        ifcRootGameObject.GetComponent<IfcFile>().changedIfcPropertiesById.Add(elementId);

        // Export edited IFC model to the Unity project's root directory
        IfcExporter.Export("From_EditElementDemo.ifc", ifcRootGameObject);
    }
}
}
