using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using IfcToolkit.IfcSpec;

namespace IfcToolkit {

/// <summary>Class for storing the parsed IFC model IfcRow dictionary as well as data about the imported IFC file. </summary>
public class IfcFile : MonoBehaviour
{
    public string ifcFileName;  // Written in IfcImporter.RuntimeImport() and IfcProcessor.OnPostprocessAllAssets()
    public string ifcFilePath; // Written in IfcImporter.RuntimeImport() and IfcProcessor.OnPostprocessAllAssets()

    public string ifc_version;
    public string ifcVersionPostfix;
    public string geometryFileFormat;
    public string geometricRepresentationContextReference = null;
    public string geometricRepresentationSubContextReference = null;

    // Dictionaries used to find specific IfcRows based on id and ifc_reference.
    public Dictionary<string, IfcRow> id_to_row;
    public Dictionary<string, IfcRow> ref_to_row;   // Find IfcRow by ifc reference
    public List<IfcRow> header_rows; // List for header row strings. Update this to a dict of header classes later
    public Dictionary<string, IfcRelContainedInSpatialStructure_IFC2X3> structure_id_to_ifcrelcontainedinspatialstructure_IFC2X3; // Find IfcRow by structure id. Values are child references.
    public Dictionary<string, IfcRelContainedInSpatialStructure_IFC4> structure_id_to_ifcrelcontainedinspatialstructure_IFC4; // Find IfcRow by structure id. Values are child references.
    public int highest_ifc_reference;    // The highest ifc reference number in the file
    public Dictionary<string, string> space_reference_to_id;
    public List<IfcRelContainedInSpatialStructure_IFC2X3> ifcrelcontainedinspatialstructures_IFC2X3;
    public List<IfcRelContainedInSpatialStructure_IFC4> ifcrelcontainedinspatialstructures_IFC4;
    public Dictionary<string, IfcRelDefinesByProperties_IFC2X3> propertySetReferenceToIfcRelDefinesByProperties_IFC2X3;
    public Dictionary<string, IfcRelDefinesByProperties_IFC4> propertySetReferenceToIfcRelDefinesByProperties_IFC4;

    // Lists for tracking changes to positions and properties Unity
    public HashSet<string> changedTransformsById = new HashSet<string>();
    public HashSet<string> changedIfcPropertiesById = new HashSet<string>();

    ///<summary>Finds the correct IFC geometric representation context for 3D elements.</summary>
    ///<param name="ifcFile">The IfcFile object used to store the IfcRows.</param>
    ///<returns> The ifc_reference as a string.</returns>
    public static string GetRepresesentationContextReference(IfcFile ifcFile){
        string representationContextReference;
        string contextReference = ifcFile.geometricRepresentationContextReference;
        string subContextReference = ifcFile.geometricRepresentationSubContextReference;

        if(subContextReference != ""){
            representationContextReference = subContextReference;
        } else if(contextReference != "") {
            representationContextReference = contextReference;
        } else {
            representationContextReference = "$";
        }

        return representationContextReference;
    }

    ///<summary>Finds the ifc_reference of an IFC GameObject.</summary>
    ///<param name="ifcElement">Any GameObject in an IFC hierarchy.</param>
    ///<returns>The ifc_reference as a string.</returns>
    public static string GetElementReference(GameObject ifcElement){
        IfcFile ifcFile = ifcElement.GetComponentInParent<IfcFile>();
        string elementId = ifcElement.GetComponent<IfcAttributes>().Find("id");
        return ifcFile.id_to_row["'" + elementId + "'"].ifc_reference;
    }
}
}
