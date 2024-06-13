using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IfcToolkit {

public class IfcSettingsOptionHolder
{
    public bool meshCollidersEnabled = true;
    public bool materialsEnabled = true;
    public bool propertiesEnabled = true;
    public bool attributesEnabled = true;
    public bool typesEnabled = true;
    public bool headerEnabled = true;
    public bool unitsEnabled = true;
    public bool quantitiesEnabled = true;
    public bool parallelProcessingEnabled = true;
    public bool keepOriginalPositionEnabled = true;
    public bool keepOriginalPositionForPartsEnabled = true;
    public string exclude_option = "";
}

}