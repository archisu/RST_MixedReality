using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Globalization;
using IfcToolkit.IfcSpec;

namespace IfcToolkit {

/// <summary>Class containing functions for creating new IFC GameObjects. </summary>
public class NewIfcGameObject : MonoBehaviour
{
    /// <summary>Instantiate a new IFC gameobject and add relevant components. </summary>
    /// <remarks>Note that currently the IFC gameobject's geometry is always a box. </remarks>
    /// <param name="elementType">The element type of the IFC gameobject. For example "IfcProduct" </param>
    /// <param name="elementName">The name of the element </param>
    /// <param name="random"> A random number generator used to generate deterministic IFC IDs. </param>
    /// <param name="propertyDict">A dictionary of the element's properties </param>
    /// <returns>A new IFC gameobject</returns>
    public static GameObject InstantiateIfcGameObject(string elementType, string elementName, System.Random random, Dictionary<string,string> propertyDict = null)
    {
        GameObject ifcGameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ifcGameObject.name = elementName;

        //Element Attributes
        IfcAttributes ifcAttributes = ifcGameObject.AddComponent<IfcAttributes>() as IfcAttributes;
        ifcAttributes.AddIfcAttribute("IfcElementType", elementType);
        ifcAttributes.AddIfcAttribute("id", IfcAttributes.GenerateIfcId(random));
        ifcAttributes.AddIfcAttribute("Name", elementName);

        //Element Properties
        if(propertyDict != null){
            IfcProperties ifcProperties = ifcGameObject.AddComponent<IfcProperties>() as IfcProperties;
            foreach(KeyValuePair<string,string> property in propertyDict){
                ifcProperties.AddIfcProperty(property.Key, property.Value);
            }
        }

        NewIfcGameObject newIfcGameObject = ifcGameObject.AddComponent<NewIfcGameObject>() as NewIfcGameObject;

        return ifcGameObject;
    }

    /// <summary>Generate IfcRows add them to the Ifc root IfcFile for the given IFC gameobject. </summary>
    /// <remarks>Note that currently the IFC gameobject's geometry is always a box. </remarks>
    /// <param name="ifcRootGameObject">The root GameObject of an IFC model. </param>
    /// <param name="ifcGameObject">The IFC gameobject to generate IfcRows for. </param>
    /// <param name="random"> A random number generator used to generate deterministic IFC IDs. </param>
    /// <param name="boxSize"> Width, height and depth of the box in meters. </param>
    /// <param name="presentationLayer"> An optional CAD layer name for the IFC gameobject. </param>
    public static void IfcRowsToIfcFile(GameObject ifcRootGameObject, GameObject ifcGameObject, System.Random random, double boxSize = 1.0, string presentationLayer = null){
        
        IfcFile ifcFile = ifcRootGameObject.GetComponent<IfcFile>();
        int lastIfcReference = ifcFile.highest_ifc_reference;
        //string representationContextReference = ifcFile.geometricRepresentationContextReference;
        string representationContextReference = IfcFile.GetRepresesentationContextReference(ifcFile);
        double lengthUnitDivisor = double.Parse( ifcRootGameObject.GetComponent<IfcUnits>().FindSIEquivalent("LENGTHUNIT"), CultureInfo.InvariantCulture );
        string postfix = ifcFile.ifcVersionPostfix;
        
        // A list of the generated ifc lines
        List<string> lines = new List<string>();
        List<string> elementReferences = new List<string>();

        // Box dimensions with dot floating points (instead of comma floating points)
        double boxheight = 1 / lengthUnitDivisor;
        double boxwidth = 1 / lengthUnitDivisor;
        double boxdepth = 1 / lengthUnitDivisor;

        // Generate IFCPRODUCTDEFINITIONSHAPE, i.e. the geometry used to represent each new element
        lines.Add("#" + (lastIfcReference + 1) + "=IFCPRODUCTDEFINITIONSHAPE($,$,(#" + (lastIfcReference + 2) + "));");
        int ifcProductDefinitionShapeReference = lastIfcReference + 1;
        lines.Add("#" + (lastIfcReference + 2) + "=IFCSHAPEREPRESENTATION(" + representationContextReference + ",'Body','SweptSolid',(#" + (lastIfcReference + 3) + "));");
        int ifcShapeRepresentationReference = lastIfcReference + 2;
        lines.Add("#" + (lastIfcReference + 3) + "=IFCEXTRUDEDAREASOLID(#" + (lastIfcReference + 4) + ",#" + (lastIfcReference + 6) + ",#" + (lastIfcReference + 9) + "," + boxheight + ");");
        lines.Add("#" + (lastIfcReference + 4) + "=IFCRECTANGLEPROFILEDEF(.AREA.,$,#" + (lastIfcReference + 5) + "," + boxwidth + "," + boxdepth + ");");
        lines.Add("#" + (lastIfcReference + 5) + "=IFCAXIS2PLACEMENT2D(#" + (lastIfcReference + 8) + ",$,$);");
        lines.Add("#" + (lastIfcReference + 6) + "=IFCAXIS2PLACEMENT3D(#" + (lastIfcReference + 7) + ",$,$);");
        lines.Add("#" + (lastIfcReference + 7) + "=IFCCARTESIANPOINT((0.,0.," + boxdepth/-4 + "));");
        lines.Add("#" + (lastIfcReference + 8) + "=IFCCARTESIANPOINT((0.,0.));");
        lines.Add("#" + (lastIfcReference + 9) + "=IFCDIRECTION((0.,0.,1.));");
        int activeIfcReference = lastIfcReference + 10;

        // IFC element object
        string name = ifcGameObject.GetComponent<IfcAttributes>().Find("Name");
        string type = ifcGameObject.GetComponent<IfcAttributes>().Find("IfcElementType");
        string id = ifcGameObject.GetComponent<IfcAttributes>().Find("id");
        string proxyLine = "#" + activeIfcReference + "=IFCBUILDINGELEMENTPROXY('" + id + "',$,'"+name+"','','"+type+"',#" + (activeIfcReference+1) +",#"+ ifcProductDefinitionShapeReference + ",$,$);";
        lines.Add(proxyLine);
        string proxyReference = "#" + activeIfcReference.ToString();

        // Placement objects
        lines.Add("#" + (activeIfcReference+1) + "=IFCLOCALPLACEMENT($,#" + (activeIfcReference + 2) + ");");
        lines.Add("#" + (activeIfcReference+2) + "=IFCAXIS2PLACEMENT3D(#" + (activeIfcReference + 3) + ",$,$);");
        
        // Coordinate object
        Vector3 ifcGameObjectPosition = ifcGameObject.transform.position;
        double xPosition = ifcGameObjectPosition.x * -1 / lengthUnitDivisor;
        double yPosition = ifcGameObjectPosition.y / lengthUnitDivisor;
        double zPosition = ifcGameObjectPosition.z * -1 / lengthUnitDivisor;
        lines.Add("#" + (activeIfcReference+3) + "=IFCCARTESIANPOINT((" + xPosition + "," + zPosition + "," + yPosition + "));" );
        activeIfcReference += 4;

        AddToParentSpatialStructure(ifcFile, ifcGameObject, proxyLine);

        // Add property sets
        if(ifcGameObject.GetComponent<IfcProperties>() != null){
            IfcProperties ifcProperties = ifcGameObject.GetComponent<IfcProperties>();
            List<string> singleValueReferences = new List<string>();
            // backwards loop due to how properties are stored in IfcProperties
            for(int i = ifcProperties.properties.Count - 1; i >= 0; i--){
                if(ifcProperties.properties[i] == "PsetName"){
                    lines.Add("#" + (activeIfcReference) + "=IFCPROPERTYSET('" + IfcAttributes.GenerateIfcId(random) + "',$,'Pset_Test',$,(" + string.Join(",", singleValueReferences) + "));");
                    activeIfcReference++;
                    string ifcreldefinesid = IfcAttributes.GenerateIfcId(random);
                    lines.Add("#" + activeIfcReference + "=IFCRELDEFINESBYPROPERTIES('" + ifcreldefinesid + "',$,$,$,("+ proxyReference +"),#" + (activeIfcReference-1) + ");");
                    activeIfcReference++;
                    singleValueReferences = new List<string>();
                } else {
                    lines.Add("#" + activeIfcReference + "=IFCPROPERTYSINGLEVALUE('" + ifcProperties.properties[i] + "',$,IFCTEXT('" + ifcProperties.nominalValues[i] + "'),$);");
                    singleValueReferences.Add("#" + activeIfcReference);
                    activeIfcReference++;
                }
            }
        }

        ifcFile.highest_ifc_reference = activeIfcReference;

        // Parse the new ifc element lines to IfcRows and store them in ifcFile
        IfcParser.ParseIfc(ifcFile, lines.ToArray());
        //IfcParser.ParseIfc(ifcFile, lines.ToArray());
    }

    public static void AddToParentSpatialStructure(IfcFile ifcFile, GameObject ifcGameObject, string proxyLine){
        // If structure ids are not mapped to ifcrelcontainedinspatialstructure_IFC2X3 this step should be skipped
        if (ifcFile.structure_id_to_ifcrelcontainedinspatialstructure_IFC2X3 == null && ifcFile.structure_id_to_ifcrelcontainedinspatialstructure_IFC4 == null) {
            return;
        }
        string postfix = ifcFile.ifcVersionPostfix;
        if (ifcFile.ifc_version == "'IFC2X3'") {
            //find parent spatialStructureReference and add proxyReference to it
            string spatialStructureId = ifcGameObject.transform.parent.GetComponent<IfcAttributes>().Find("id");
            //Debug.Log("Spatial structure id: "+spatialStructureId);
            string spatialStructureReference = ifcFile.structure_id_to_ifcrelcontainedinspatialstructure_IFC2X3["'" + spatialStructureId + "'"].ifc_reference;
            IfcRelContainedInSpatialStructure_IFC2X3 spatialStructure = ifcFile.ref_to_row[spatialStructureReference] as IfcRelContainedInSpatialStructure_IFC2X3;
            
            Type proxyLineType = IfcParser.GetIfcRowType(proxyLine, postfix);
            IfcRow proxyRow = IfcRow.NewRow(proxyLineType, proxyLine);
            IfcProduct_IFC2X3 proxyProduct = proxyRow as IfcProduct_IFC2X3;
            spatialStructure.RelatedElements.Add(proxyProduct);
        }
        else if (ifcFile.ifc_version == "'IFC4'") {
            //find parent spatialStructureReference and add proxyReference to it
            string spatialStructureId = ifcGameObject.transform.parent.GetComponent<IfcAttributes>().Find("id");
            string spatialStructureReference = ifcFile.structure_id_to_ifcrelcontainedinspatialstructure_IFC4["'" + spatialStructureId + "'"].ifc_reference;
            IfcRelContainedInSpatialStructure_IFC4 spatialStructure = ifcFile.ref_to_row[spatialStructureReference] as IfcRelContainedInSpatialStructure_IFC4;

            Type proxyLineType = IfcParser.GetIfcRowType(proxyLine, postfix);
            IfcRow proxyRow = IfcRow.NewRow(proxyLineType, proxyLine);
            IfcProduct_IFC4 proxyProduct = proxyRow as IfcProduct_IFC4;
            spatialStructure.RelatedElements.Add(proxyProduct);
        }
    }
}
}
