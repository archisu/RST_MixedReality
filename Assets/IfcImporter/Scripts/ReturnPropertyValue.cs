using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IfcToolkit {


/// <summary>Old class for testing IFC importer. </summary>
public class ReturnPropertyValue : MonoBehaviour
{
    //public string propertyName;
    //public string attributeName;
    //public GameObject element;
    //public GameObject ifcParent;
    //public string ifcId;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(propertyName + ": " + element.GetComponent<ifcProperties>().Property(propertyName));
        //Debug.Log(attributeName + ": " + element.GetComponent<ifcAttributes>().Attribute(attributeName));
        //Debug.Log(element.GetComponent<ifcMaterials>().materials[0]);
        //Debug.Log( ifcParent.GetComponent<ifcRootLists>().FindIfcGameObject(ifcId) );
        //ifcParent.GetComponent<ifcRootLists>().IfcLayerSetActive("A-WALL-MBNI", false);
        //Debug.Log( ifcParent.GetComponent<ifcRootLists>().FindIfcLayerGameObjects("A-ROOF").Count );
        //Debug.Log( ifcParent.GetComponent<ifcRootLists>().FindIfcElementTypeGameObjects("IfcWindow").Count );
        //ifcParent.GetComponent<ifcRootLists>().IfcElementTypeSetActive("IfcWindow", false);

        // IfcUnits myIfcUnits = gameObject.GetComponent<IfcUnits>();
        // Debug.Log(myIfcUnits.UnitTypeName("LENGTHUNIT") + ", 1 to " + myIfcUnits.UnitTypeSIEquivalent("LENGTHUNIT"));
        // Debug.Log(myIfcUnits.UnitTypeName("VOLUMEUNIT") + ", 1 to " + myIfcUnits.UnitTypeSIEquivalent("VOLUMEUNIT"));
        // Debug.Log(myIfcUnits.UnitTypeName("PLANEANGLEUNIT") + ", 1 to " + myIfcUnits.UnitTypeSIEquivalent("PLANEANGLEUNIT"));

        // IfcQuantities myIfcQuantities = gameObject.GetComponent<IfcQuantities>();
        // Debug.Log(myIfcQuantities.Quantity("GrossVolume"));
    }
}
}
