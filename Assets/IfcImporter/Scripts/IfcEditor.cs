using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Reflection;
using IfcToolkit.IfcSpec;
using System.Globalization;

namespace IfcToolkit {

/// <summary>Class containing functions for editing IFC GameObjects. </summary>
public class IfcEditor : MonoBehaviour
{

    /*
    // EXPERIMENTAL -- the following section exports changes to relative positions of IFC elements to the IFC file on IFC export.
    // Does not work with all models, so it has been deactivated by default.
    // To activate, uncomment this section and line 99 in IfcExporter.cs

    /// <summary>Staging function for updating all positions in an IFC model. </summary>
    /// <param name="ifcFile">The IfcFile component attached to the root GameObject of an IFC model. </param>
    public static void UpdateAllIfcPositions(IfcFile ifcFile){
        double lengthUnitDivisor = double.Parse( ifcFile.transform.GetComponent<IfcUnits>().FindSIEquivalent("LENGTHUNIT"), CultureInfo.InvariantCulture );
        DetectChangedPositions(ifcFile.transform, lengthUnitDivisor);
    }

    /// <summary>Detect changed positions in an IFC model recursively. </summary>
    /// <param name="ifcTransform">A transform to check. All the transfrom's children will also be checked recursively. </param>
    public static void DetectChangedPositions(Transform ifcTransform, double lengthUnit){
        // Check if position has changed since start
        if(ifcTransform.GetComponent<IfcAttributes>() != null){
            Vector3 currentPosition = ifcTransform.localPosition;
            Vector3 startPosition = ifcTransform.GetComponent<IfcAttributes>().startPosition;
            double distance = Vector3.Distance(currentPosition, startPosition) / lengthUnit;
            if(distance > 0.001f){
                Debug.Log(ifcTransform.name);
                UpdateIfcPosition(ifcTransform);
                // Debug.Log(ifcTransform.localPosition);
                // Debug.Log(ifcTransform.position);
                // Debug.Log("currentPosition: " + currentPosition.ToString());
                // Debug.Log("startPosition: " + startPosition.ToString());
                // Debug.Log("distance: " + distance.ToString());
            }
        }

        // Loop hierarchy recursively
        foreach(Transform childTransform in ifcTransform){
            DetectChangedPositions(childTransform, lengthUnit);
        }
    }

    /// <summary>Generate new positions for ifc elements matching their positions in Unity. </summary>
    /// <remarks>The id of an ifc element must be placed in the ifcRootGameObject.IfcFile.changedTransformsById list in order to update its position.</remarks>
    /// <param name="changedTransform">A transform that has been changed in Unity. </param>
    public static void UpdateIfcPosition(Transform changedTransform){
        IfcFile ifcFile = changedTransform.GetComponentInParent<IfcFile>();
        string geometryFileFormat = changedTransform.GetComponentInParent<IfcFile>().geometryFileFormat;
        string ifcVersion = changedTransform.GetComponentInParent<IfcFile>().ifc_version;
        string postfix = ifcFile.ifcVersionPostfix;

        // Get element IfcRow based on id
        string changedTransformId = changedTransform.GetComponent<IfcAttributes>().Find("id");
        IfcRow myIfcObject = ifcFile.id_to_row["'"+changedTransformId+"'"];

        // Get element's old position and rotation from IFC data
        double[] oldIfcCoordinates = GetIfcPosition(myIfcObject, geometryFileFormat, ifcVersion);
        Quaternion ifcSumRotation = GetIfcRotation(myIfcObject, geometryFileFormat, ifcVersion);

        // Get positional change from element moved in unity
        Vector3 deltaVector = changedTransform.position;
        Debug.Log("deltaVector: " + deltaVector.ToString("F4"));

        // Rotate delta vector to correct for rotations in the IFC model
        Vector3 correctedDeltaVector = ifcSumRotation * deltaVector;
        Debug.Log("correctedDeltaVector: " + correctedDeltaVector.ToString("F4"));

        // Convert the delta vector from unity to coordinates that can be used in IFC
        double lengthUnitDivisor = double.Parse( ifcFile.transform.GetComponent<IfcUnits>().FindSIEquivalent("LENGTHUNIT"), CultureInfo.InvariantCulture );
        double unityXPosition;
        double unityYPosition;
        double unityZPosition;
        if(geometryFileFormat == "DAE"){
            unityXPosition = changedTransform.position.x * -1 / lengthUnitDivisor;
            unityYPosition = changedTransform.position.y / lengthUnitDivisor;
            unityZPosition = changedTransform.position.z / lengthUnitDivisor;
        }
        else{
            // geometryFileFormat == "OBJ"
            // unityXPosition = changedTransform.position.x / lengthUnitDivisor;
            // unityYPosition = changedTransform.position.z * -1 / lengthUnitDivisor;
            // unityZPosition = changedTransform.position.y / lengthUnitDivisor;
            unityXPosition = deltaVector.x / lengthUnitDivisor;
            unityYPosition = deltaVector.z * -1 / lengthUnitDivisor;
            unityZPosition = deltaVector.y / lengthUnitDivisor;
        }
        
        // Add the positions, note that with a DAE import the added coordinates should be 0,0,0
        double xPositionIfc = oldIfcCoordinates[0] + unityXPosition;
        double yPositionIfc = oldIfcCoordinates[1] + unityYPosition;
        double zPositionIfc = oldIfcCoordinates[2] + unityZPosition;

        //Get local placement object from element
        FieldInfo objectPlacement = myIfcObject.GetType().GetField("ObjectPlacement");

        // Check if the Ifc object actually has an object placement
        if(objectPlacement != null){
            // Create new cartesian point with new positions and add it to re_to_row
            int highestReference = ifcFile.highest_ifc_reference;
            int cartesianPointReference = highestReference + 1;
            string cartesianPointline = "#" + cartesianPointReference.ToString() + "=IFCCARTESIANPOINT((" + xPositionIfc.ToString() + "," + yPositionIfc.ToString() + "," + zPositionIfc.ToString() + "));";
            Type cartesianType = IfcParser.GetIfcRowType(cartesianPointline, postfix);
            IfcRow cartesianRow = IfcRow.NewRow(cartesianType, cartesianPointline);
            ifcFile.transform.GetComponent<IfcFile>().ref_to_row[cartesianRow.ifc_reference] = cartesianRow;

            // Separate code for IFC2X3 and IFC4
            if (ifcFile.ifc_version == "'IFC2X3'") {
                IfcLocalPlacement_IFC2X3 ifcLocalPlacementObject = objectPlacement.GetValue(myIfcObject) as IfcLocalPlacement_IFC2X3;

                // Get axis placement object from local placement
                string relativePlacementReference = ((IfcRow)ifcLocalPlacementObject.RelativePlacement.Value).ifc_reference;
                IfcRow oldAxisPlacementObject = ifcFile.ref_to_row[relativePlacementReference];

                // Copy IfcAxis2Placement
                int axisReference = highestReference + 2;
                string axisPlacementLine = oldAxisPlacementObject.ToString(postfix);
                IfcAxis2Placement3D_IFC2X3 axisRow = new IfcAxis2Placement3D_IFC2X3(axisPlacementLine);
                axisRow.ifc_reference = "#" + axisReference;

                // Update IfcAxis2Placement to use new cartesian point
                axisRow.Location = cartesianRow as IfcCartesianPoint_IFC2X3;

                // Add copied IfcAxis2Placement to ref_to_row
                ifcFile.transform.GetComponent<IfcFile>().ref_to_row[axisRow.ifc_reference] = axisRow as IfcRow;

                // Update new IfcAxis2Placement to localPlacement
                ifcLocalPlacementObject.RelativePlacement.Value = axisRow;
            }

            else if (ifcFile.ifc_version == "'IFC4'") {
                IfcLocalPlacement_IFC4 ifcLocalPlacementObject = objectPlacement.GetValue(myIfcObject) as IfcLocalPlacement_IFC4;

                // Get axis placement object from local placement
                string relativePlacementReference = ((IfcRow)ifcLocalPlacementObject.RelativePlacement.Value).ifc_reference;
                IfcRow oldAxisPlacementObject = ifcFile.ref_to_row[relativePlacementReference];

                // Copy IfcAxis2Placement
                int axisReference = highestReference + 2;
                string axisPlacementLine = oldAxisPlacementObject.ToString(postfix);
                IfcAxis2Placement3D_IFC4 axisRow = new IfcAxis2Placement3D_IFC4(axisPlacementLine);
                axisRow.ifc_reference = "#" + axisReference;

                // Update IfcAxis2Placement to use new cartesian point
                axisRow.Location = cartesianRow as IfcCartesianPoint_IFC4;

                // Add copied IfcAxis2Placement to ref_to_row
                ifcFile.transform.GetComponent<IfcFile>().ref_to_row[axisRow.ifc_reference] = axisRow as IfcRow;

                // Update new IfcAxis2Placement to localPlacement
                ifcLocalPlacementObject.RelativePlacement.Value = axisRow;
            }
            
            // Update ifcFile.highest_ifc_reference!
            ifcFile.highest_ifc_reference = ifcFile.highest_ifc_reference + 2;
            
        }
    }
    */

    /// <summary>Generate new properties for ifc elements matching those in Unity. </summary>
    /// <remarks>For this to be called for an ifc element, its id must be in the ifcRootGameObject.IfcFile.changedIfcObjectId list. </remarks>
    /// <param name="ifcFile">The IfcFile component attached to the root GameObject of an IFC model. </param>
    /// <param name="random"> A random number generator used to generate IDs for new elements. </param>
    public static void UpdateIfcProperties(IfcFile ifcFile, System.Random random){
        foreach(string changedIfcObjectId in ifcFile.changedIfcPropertiesById){
            // Get basic information for the changed ifc gameobject
            GameObject changedIfcGameObject = ifcFile.transform.GetComponent<IfcRootLists>().FindIfcGameObject(changedIfcObjectId);
            IfcRow ifcObjectRow = ifcFile.id_to_row["'" + changedIfcObjectId + "'"];
            string ifcObjectReference = ifcObjectRow.ifc_reference;
            List<string> oldDefinesByPropertiesReferences = new List<string>();

            // Check if we're working with IFC2X3 or IFC4
            string postfix = ifcFile.ifcVersionPostfix;

            // A list of the generated ifc lines
            List<string> lines = new List<string>();
            int activeIfcReference = ifcFile.highest_ifc_reference + 1;

            // Generate new rows based on the Ifc GameObject's IfcProperties
            // These new rows will include any changes made in Unity
            if(changedIfcGameObject.GetComponent<IfcProperties>() != null){
                IfcProperties ifcProperties = changedIfcGameObject.GetComponent<IfcProperties>();
                List<string> singleValueReferences = new List<string>();

                // Reverse loop through the Ifc GameObject's properties
                for(int i = ifcProperties.properties.Count - 1; i >= 0; i--){
                    //Debug.Log(ifcProperties.properties[i] + ": " + ifcProperties.nominalValues[i]);
                    if(ifcProperties.properties[i] == "PsetName"){
                        lines.Add("#" + (activeIfcReference) + "=IFCPROPERTYSET('" + IfcAttributes.GenerateIfcId(random) + "',$,'"+ ifcProperties.nominalValues[i] +"',$,(" + string.Join(",", singleValueReferences) + "));");
                        activeIfcReference++;
                        lines.Add("#" + activeIfcReference + "=IFCRELDEFINESBYPROPERTIES('" + IfcAttributes.GenerateIfcId(random) + "',$,$,$,("+ ifcObjectReference +"),#" + (activeIfcReference-1) + ");");
                        activeIfcReference++;
                        singleValueReferences = new List<string>();
                    } else {
                        // id is written into properties for convenience in Unity, but should not be written to a propertysinglevalue
                        if(ifcProperties.properties[i] != "Id"){
                            lines.Add("#" + activeIfcReference + "=IFCPROPERTYSINGLEVALUE('" + ifcProperties.properties[i] + "',$,IFCTEXT('" + ifcProperties.nominalValues[i] + "'),$);");
                            singleValueReferences.Add("#" + activeIfcReference);
                            activeIfcReference++;
                        } else {
                            // we need to remove element reference from old IfcRelDefinesByProperties
                            string propertySetId = ifcProperties.nominalValues[i];
                            string propertySetReference = ifcFile.id_to_row["'" + propertySetId + "'"].ifc_reference;
                            oldDefinesByPropertiesReferences.Add(propertySetReference);
                        }
                    }
                }
            }
            
            // Parse the new property lines to IfcRows and store them in ifcFile
            IfcParser.ParseIfc(ifcFile, lines.ToArray());
            
            // Update the highest_ifc_reference, this is important if we edit ifcRows later
            ifcFile.highest_ifc_reference = activeIfcReference;

            // Edit old rows so they don't add the old properties to the element.
            foreach(string definesByPropertiesId in oldDefinesByPropertiesReferences){

                if (ifcFile.ifc_version == "'IFC2X3'") {
                    //Get old IfcRelDefinesByProperties using property set reference
                    IfcRelDefinesByProperties_IFC2X3 relDefinesByProperties = ifcFile.propertySetReferenceToIfcRelDefinesByProperties_IFC2X3[definesByPropertiesId];
                    //Remove the changed ifc object from the relDefinesByProperties list using lambda expression
                    relDefinesByProperties.RelatedObjects.RemoveAll(s => s.ifc_reference == ifcObjectReference);
                }
                else if (ifcFile.ifc_version == "'IFC4'") {
                    // Same as above but for IFC4
                    IfcRelDefinesByProperties_IFC4 relDefinesByProperties = ifcFile.propertySetReferenceToIfcRelDefinesByProperties_IFC4[definesByPropertiesId];
                    relDefinesByProperties.RelatedObjects.RemoveAll(s => s.ifc_reference == ifcObjectReference);
                }

            }
        }
    }
    public static double[] GetIfcPosition(IfcRow myIfcObject, string geometryFileFormat, string ifcVersion){
        double[] myIfcCoordinates = new double[3];
        if(geometryFileFormat == "DAE"){
            myIfcCoordinates = new double[3] {0,0,0};
        }
        if(geometryFileFormat == "OBJ"){
            // Should also check if we're using 2x3 or 4
            if(ifcVersion == "'IFC2X3'"){
                myIfcCoordinates = GetIfc2X3Position(myIfcObject);
            } else if(ifcVersion == "'IFC4'"){
                myIfcCoordinates = GetIfc4Position(myIfcObject);
            }
        }
        return myIfcCoordinates;
    }
    public static double[] GetIfc2X3Position(IfcRow myIfcObject){
        IfcAxis2Placement3D_IFC2X3 ifcAxis2Placement3D = GetIfcAxisPlacement2X3(myIfcObject);
        IfcCartesianPoint_IFC2X3 ifcCartesianPoint = ifcAxis2Placement3D.Location as IfcCartesianPoint_IFC2X3;
        List<string> coordinates = ifcCartesianPoint.Coordinates;
        double[] position = new double[3];
        position[0] = double.Parse(coordinates[0]);
        position[1] = double.Parse(coordinates[1]);
        position[2] = double.Parse(coordinates[2]);
        return position;
    }
    public static IfcAxis2Placement3D_IFC2X3 GetIfcAxisPlacement2X3(IfcRow myIfcObject){
        FieldInfo objectPlacement = myIfcObject.GetType().GetField("ObjectPlacement");
        IfcLocalPlacement_IFC2X3 ifcLocalPlacementObject = objectPlacement.GetValue(myIfcObject) as IfcLocalPlacement_IFC2X3;
        IfcAxis2Placement3D_IFC2X3 ifcAxis2Placement3D = ifcLocalPlacementObject.RelativePlacement.Value as IfcAxis2Placement3D_IFC2X3;
        return ifcAxis2Placement3D;
    }
    public static double[] GetIfc4Position(IfcRow myIfcObject){
        FieldInfo objectPlacement = myIfcObject.GetType().GetField("ObjectPlacement");
        IfcLocalPlacement_IFC4 ifcLocalPlacementObject = objectPlacement.GetValue(myIfcObject) as IfcLocalPlacement_IFC4;
        IfcAxis2Placement3D_IFC4 ifcAxis2Placement3D = ifcLocalPlacementObject.RelativePlacement.Value as IfcAxis2Placement3D_IFC4;
        IfcCartesianPoint_IFC4 ifcCartesianPoint = ifcAxis2Placement3D.Location as IfcCartesianPoint_IFC4;
        List<string> coordinates = ifcCartesianPoint.Coordinates;
        double[] position = new double[3];
        position[0] = double.Parse(coordinates[0]);
        position[1] = double.Parse(coordinates[1]);
        position[2] = double.Parse(coordinates[2]);
        return position;
    }
    public static Quaternion GetIfcRotation(IfcRow myIfcObject, string geometryFileFormat, string ifcVersion){
        Quaternion myIfcRotation = new Quaternion(0,0,0,1);
        if(geometryFileFormat == "DAE"){
            myIfcRotation = new Quaternion(0,0,0,1);
        }
        if(geometryFileFormat == "OBJ"){
            if(ifcVersion == "'IFC2X3'"){
                myIfcRotation = GetIfc2X3RotationalAncestry(myIfcObject);
            } else if(ifcVersion == "'IFC4'"){
                //Quaternion myIfcRotation = GetIfc4RotationalAncestry(myIfcObject);
                myIfcRotation = new Quaternion(0,0,0,1);
                Debug.Log("Add function for getting IFC4 rotational ancestry");
            }
        }
        return myIfcRotation;
    }
    public static Quaternion GetIfc2X3RotationalAncestry(IfcRow myIfcObject){
        FieldInfo objectPlacement = myIfcObject.GetType().GetField("ObjectPlacement");
        IfcLocalPlacement_IFC2X3 ifcLocalPlacementObject = objectPlacement.GetValue(myIfcObject) as IfcLocalPlacement_IFC2X3;
        //GetIfc2X3RotationalAncestor(ifcLocalPlacementObject);

        IfcLocalPlacement_IFC2X3 current = ifcLocalPlacementObject;
        Vector3 sumAxis = new Vector3(0,0,0);
        Vector3 sumRefDirection = new Vector3(0,0,0);
        while(current.PlacementRelTo != null){
            current = current.PlacementRelTo as IfcLocalPlacement_IFC2X3;

            IfcAxis2Placement3D_IFC2X3 ifcAxis2Placement3D = current.RelativePlacement.Value as IfcAxis2Placement3D_IFC2X3;
            
            sumAxis = sumAxis + Get2X3Axis(ifcAxis2Placement3D);

            sumRefDirection = sumRefDirection + Get2X3RefDirection(ifcAxis2Placement3D);

            //Debug.Log(current);
        }
        // Debug.Log("SumAxis:");
        // Debug.Log(sumAxis.ToString("F4"));
        // Debug.Log("sumRefDirection");
        // Debug.Log(sumRefDirection.ToString("F4"));

        Quaternion sumRotation = ConvertIfcRotation(sumAxis, sumRefDirection);
        Debug.Log("sumRotation");
        Debug.Log(sumRotation.ToString("F4"));
        return sumRotation;
    }
    public static Quaternion ConvertIfcRotation(Vector3 axis, Vector3 refDirection){
        Vector3 cross = Vector3.Cross(axis,refDirection);
        Quaternion axisCross = Quaternion.LookRotation(axis, cross);
        //return axisCross;
        Quaternion axisCrossCorrected = new Quaternion(axisCross.x, axisCross.y, -axisCross.z, axisCross.w);
        //Quaternion axisCrossCorrected = new Quaternion(axisCross.x, axisCross.y, axisCross.z, axisCross.w);
        //Debug.Log("Quaternion: " + axisCrossCorrected.ToString("F4"));
        return axisCrossCorrected;
    }

    public static Vector3 Get2X3Axis(IfcAxis2Placement3D_IFC2X3 ifcAxis2Placement3D){
        Vector3 axis = new Vector3(0,0,0);
        if(ifcAxis2Placement3D.Axis != null){
            List<string> axisRatios = ifcAxis2Placement3D.Axis.DirectionRatios;
            axis = new Vector3(float.Parse(axisRatios[0]), float.Parse(axisRatios[1]), float.Parse(axisRatios[2]));
        }
        //Debug.Log(axis.ToString("F4"));
        return axis;
    }
    public static Vector3 Get2X3RefDirection(IfcAxis2Placement3D_IFC2X3 ifcAxis2Placement3D){
        Vector3 refDirection = new Vector3(0,0,0);
        if(ifcAxis2Placement3D.RefDirection != null){
            List<string> RefDirectionRatios = ifcAxis2Placement3D.RefDirection.DirectionRatios;
            refDirection = new Vector3(float.Parse(RefDirectionRatios[0]), float.Parse(RefDirectionRatios[1]), float.Parse(RefDirectionRatios[2]));
        }
        //Debug.Log(refDirection.ToString("F4"));
        return refDirection;
    }
}
}
