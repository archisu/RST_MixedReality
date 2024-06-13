using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;


namespace IfcToolkit {
///<summary>A collection of automatically generated classes based on various IFC EXPRESS specifications, as well as a handful of manually created classes to handle header information.</summary>
namespace IfcSpec {
//Not parsed from EXPRESS
public class File_Description : IfcRow {
    public string description; // example: 'ViewDefinition[CoordinationView]'
    public string implementation_level; // example: '2;1'
    public new List<string> param_order = new List<string>{"description", "implementation_level"};
    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public File_Description(string line) : base(line){}
    public File_Description(Dictionary<string, object> p) :base(p){}
}
public class File_Name : IfcRow {
    public string name; // example: 'C:\Test_Building.ifc'
    public string time_stamp; // example: '2007-02-06T10:28:37'
    public string author; // example: 'Firstname Lastname, email address'
    public string organization; // example: 'Forschungszentrum Karlsruhe'
    public string preprocessor_version; // example: 'Arcventure IFC importer exporter'
    public string originating_system; // example: 'Your Unity app, version 1, build 123'
    public string authorization; // example: 'Firstname Lastname, email address'
    public new List<string> param_order = new List<string>{"name", "time_stamp", "author", "organization", "preprocessor_version", "originating_system", "authorization"};
    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public File_Name(string line) : base(line){}
    public File_Name(Dictionary<string, object> p) :base(p){}
}

public class File_Schema : IfcRow {
    public string schema_identifiers; // example: 'IFC2X3'
    public new List<string> param_order = new List<string>{"schema_identifiers"};
    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public File_Schema(string line) : base(line){}
    public File_Schema(Dictionary<string, object> p) :base(p){}
}

//The rest are automatically generated

public class Ifc2DCompositeCurve_IFC2X3 : IfcCompositeCurve_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public Ifc2DCompositeCurve_IFC2X3(string line) : base(line){}
    public Ifc2DCompositeCurve_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcActionRequest_IFC2X3 : IfcControl_IFC2X3 {
    public string RequestID;

    public new List<string> param_order = new List<string>{"RequestID"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcActionRequest_IFC2X3(string line) : base(line){}
    public IfcActionRequest_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcActor_IFC2X3 : IfcObject_IFC2X3 {
    public IfcActorSelect_IFC2X3 TheActor;

    public new List<string> param_order = new List<string>{"TheActor"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcActor_IFC2X3(string line) : base(line){}
    public IfcActor_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcActorRole_IFC2X3 : Entity {
    public string Role;
    public string UserDefinedRole;
    public string Description;

    public new List<string> param_order = new List<string>{"Role", "UserDefinedRole", "Description"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcActorRole_IFC2X3(string line) : base(line){}
    public IfcActorRole_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcActuatorType_IFC2X3 : IfcDistributionControlElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcActuatorType_IFC2X3(string line) : base(line){}
    public IfcActuatorType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAddress_IFC2X3 : Entity {
    public string Purpose;
    public string Description;
    public string UserDefinedPurpose;

    public new List<string> param_order = new List<string>{"Purpose", "Description", "UserDefinedPurpose"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAddress_IFC2X3(string line) : base(line){}
    public IfcAddress_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAirTerminalBoxType_IFC2X3 : IfcFlowControllerType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAirTerminalBoxType_IFC2X3(string line) : base(line){}
    public IfcAirTerminalBoxType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAirTerminalType_IFC2X3 : IfcFlowTerminalType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAirTerminalType_IFC2X3(string line) : base(line){}
    public IfcAirTerminalType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAirToAirHeatRecoveryType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAirToAirHeatRecoveryType_IFC2X3(string line) : base(line){}
    public IfcAirToAirHeatRecoveryType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAlarmType_IFC2X3 : IfcDistributionControlElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAlarmType_IFC2X3(string line) : base(line){}
    public IfcAlarmType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAngularDimension_IFC2X3 : IfcDimensionCurveDirectedCallout_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAngularDimension_IFC2X3(string line) : base(line){}
    public IfcAngularDimension_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAnnotation_IFC2X3 : IfcProduct_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAnnotation_IFC2X3(string line) : base(line){}
    public IfcAnnotation_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAnnotationCurveOccurrence_IFC2X3 : IfcAnnotationOccurrence_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAnnotationCurveOccurrence_IFC2X3(string line) : base(line){}
    public IfcAnnotationCurveOccurrence_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAnnotationFillArea_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public IfcCurve_IFC2X3 OuterBoundary;
    public List<IfcCurve_IFC2X3> InnerBoundaries;

    public new List<string> param_order = new List<string>{"OuterBoundary", "InnerBoundaries"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAnnotationFillArea_IFC2X3(string line) : base(line){}
    public IfcAnnotationFillArea_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAnnotationFillAreaOccurrence_IFC2X3 : IfcAnnotationOccurrence_IFC2X3 {
    public IfcPoint_IFC2X3 FillStyleTarget;
    public string GlobalOrLocal;

    public new List<string> param_order = new List<string>{"FillStyleTarget", "GlobalOrLocal"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAnnotationFillAreaOccurrence_IFC2X3(string line) : base(line){}
    public IfcAnnotationFillAreaOccurrence_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAnnotationOccurrence_IFC2X3 : IfcStyledItem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAnnotationOccurrence_IFC2X3(string line) : base(line){}
    public IfcAnnotationOccurrence_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAnnotationSurface_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public IfcGeometricRepresentationItem_IFC2X3 Item;
    public IfcTextureCoordinate_IFC2X3 TextureCoordinates;

    public new List<string> param_order = new List<string>{"Item", "TextureCoordinates"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAnnotationSurface_IFC2X3(string line) : base(line){}
    public IfcAnnotationSurface_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAnnotationSurfaceOccurrence_IFC2X3 : IfcAnnotationOccurrence_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAnnotationSurfaceOccurrence_IFC2X3(string line) : base(line){}
    public IfcAnnotationSurfaceOccurrence_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAnnotationSymbolOccurrence_IFC2X3 : IfcAnnotationOccurrence_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAnnotationSymbolOccurrence_IFC2X3(string line) : base(line){}
    public IfcAnnotationSymbolOccurrence_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAnnotationTextOccurrence_IFC2X3 : IfcAnnotationOccurrence_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAnnotationTextOccurrence_IFC2X3(string line) : base(line){}
    public IfcAnnotationTextOccurrence_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcApplication_IFC2X3 : Entity {
    public IfcOrganization_IFC2X3 ApplicationDeveloper;
    public string Version;
    public string ApplicationFullName;
    public string ApplicationIdentifier;

    public new List<string> param_order = new List<string>{"ApplicationDeveloper", "Version", "ApplicationFullName", "ApplicationIdentifier"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcApplication_IFC2X3(string line) : base(line){}
    public IfcApplication_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAppliedValue_IFC2X3 : Entity {
    public string Name;
    public string Description;
    public IfcAppliedValueSelect_IFC2X3 AppliedValue;
    public IfcMeasureWithUnit_IFC2X3 UnitBasis;
    public IfcDateTimeSelect_IFC2X3 ApplicableDate;
    public IfcDateTimeSelect_IFC2X3 FixedUntilDate;

    public new List<string> param_order = new List<string>{"Name", "Description", "AppliedValue", "UnitBasis", "ApplicableDate", "FixedUntilDate"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAppliedValue_IFC2X3(string line) : base(line){}
    public IfcAppliedValue_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAppliedValueRelationship_IFC2X3 : Entity {
    public IfcAppliedValue_IFC2X3 ComponentOfTotal;
    public List<IfcAppliedValue_IFC2X3> Components;
    public string ArithmeticOperator;
    public string Name;
    public string Description;

    public new List<string> param_order = new List<string>{"ComponentOfTotal", "Components", "ArithmeticOperator", "Name", "Description"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAppliedValueRelationship_IFC2X3(string line) : base(line){}
    public IfcAppliedValueRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcApproval_IFC2X3 : Entity {
    public string Description;
    public IfcDateTimeSelect_IFC2X3 ApprovalDateTime;
    public string ApprovalStatus;
    public string ApprovalLevel;
    public string ApprovalQualifier;
    public string Name;
    public string Identifier;

    public new List<string> param_order = new List<string>{"Description", "ApprovalDateTime", "ApprovalStatus", "ApprovalLevel", "ApprovalQualifier", "Name", "Identifier"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcApproval_IFC2X3(string line) : base(line){}
    public IfcApproval_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcApprovalActorRelationship_IFC2X3 : Entity {
    public IfcActorSelect_IFC2X3 Actor;
    public IfcApproval_IFC2X3 Approval;
    public IfcActorRole_IFC2X3 Role;

    public new List<string> param_order = new List<string>{"Actor", "Approval", "Role"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcApprovalActorRelationship_IFC2X3(string line) : base(line){}
    public IfcApprovalActorRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcApprovalPropertyRelationship_IFC2X3 : Entity {
    public List<IfcProperty_IFC2X3> ApprovedProperties;
    public IfcApproval_IFC2X3 Approval;

    public new List<string> param_order = new List<string>{"ApprovedProperties", "Approval"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcApprovalPropertyRelationship_IFC2X3(string line) : base(line){}
    public IfcApprovalPropertyRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcApprovalRelationship_IFC2X3 : Entity {
    public IfcApproval_IFC2X3 RelatedApproval;
    public IfcApproval_IFC2X3 RelatingApproval;
    public string Description;
    public string Name;

    public new List<string> param_order = new List<string>{"RelatedApproval", "RelatingApproval", "Description", "Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcApprovalRelationship_IFC2X3(string line) : base(line){}
    public IfcApprovalRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcArbitraryClosedProfileDef_IFC2X3 : IfcProfileDef_IFC2X3 {
    public IfcCurve_IFC2X3 OuterCurve;

    public new List<string> param_order = new List<string>{"OuterCurve"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcArbitraryClosedProfileDef_IFC2X3(string line) : base(line){}
    public IfcArbitraryClosedProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcArbitraryOpenProfileDef_IFC2X3 : IfcProfileDef_IFC2X3 {
    public IfcBoundedCurve_IFC2X3 Curve;

    public new List<string> param_order = new List<string>{"Curve"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcArbitraryOpenProfileDef_IFC2X3(string line) : base(line){}
    public IfcArbitraryOpenProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcArbitraryProfileDefWithVoids_IFC2X3 : IfcArbitraryClosedProfileDef_IFC2X3 {
    public List<IfcCurve_IFC2X3> InnerCurves;

    public new List<string> param_order = new List<string>{"InnerCurves"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcArbitraryProfileDefWithVoids_IFC2X3(string line) : base(line){}
    public IfcArbitraryProfileDefWithVoids_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAsset_IFC2X3 : IfcGroup_IFC2X3 {
    public string AssetID;
    public IfcCostValue_IFC2X3 OriginalValue;
    public IfcCostValue_IFC2X3 CurrentValue;
    public IfcCostValue_IFC2X3 TotalReplacementCost;
    public IfcActorSelect_IFC2X3 Owner;
    public IfcActorSelect_IFC2X3 User;
    public IfcPerson_IFC2X3 ResponsiblePerson;
    public IfcCalendarDate_IFC2X3 IncorporationDate;
    public IfcCostValue_IFC2X3 DepreciatedValue;

    public new List<string> param_order = new List<string>{"AssetID", "OriginalValue", "CurrentValue", "TotalReplacementCost", "Owner", "User", "ResponsiblePerson", "IncorporationDate", "DepreciatedValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAsset_IFC2X3(string line) : base(line){}
    public IfcAsset_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAsymmetricIShapeProfileDef_IFC2X3 : IfcIShapeProfileDef_IFC2X3 {
    public string TopFlangeWidth;
    public string TopFlangeThickness;
    public string TopFlangeFilletRadius;
    public string CentreOfGravityInY;

    public new List<string> param_order = new List<string>{"TopFlangeWidth", "TopFlangeThickness", "TopFlangeFilletRadius", "CentreOfGravityInY"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAsymmetricIShapeProfileDef_IFC2X3(string line) : base(line){}
    public IfcAsymmetricIShapeProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAxis1Placement_IFC2X3 : IfcPlacement_IFC2X3 {
    public IfcDirection_IFC2X3 Axis;

    public new List<string> param_order = new List<string>{"Axis"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAxis1Placement_IFC2X3(string line) : base(line){}
    public IfcAxis1Placement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAxis2Placement2D_IFC2X3 : IfcPlacement_IFC2X3 {
    public IfcDirection_IFC2X3 RefDirection;

    public new List<string> param_order = new List<string>{"RefDirection"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAxis2Placement2D_IFC2X3(string line) : base(line){}
    public IfcAxis2Placement2D_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcAxis2Placement3D_IFC2X3 : IfcPlacement_IFC2X3 {
    public IfcDirection_IFC2X3 Axis;
    public IfcDirection_IFC2X3 RefDirection;

    public new List<string> param_order = new List<string>{"Axis", "RefDirection"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAxis2Placement3D_IFC2X3(string line) : base(line){}
    public IfcAxis2Placement3D_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBSplineCurve_IFC2X3 : IfcBoundedCurve_IFC2X3 {
    public string Degree;
    public List<IfcCartesianPoint_IFC2X3> ControlPointsList;
    public string CurveForm;
    public string ClosedCurve;
    public string SelfIntersect;

    public new List<string> param_order = new List<string>{"Degree", "ControlPointsList", "CurveForm", "ClosedCurve", "SelfIntersect"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBSplineCurve_IFC2X3(string line) : base(line){}
    public IfcBSplineCurve_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBeam_IFC2X3 : IfcBuildingElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBeam_IFC2X3(string line) : base(line){}
    public IfcBeam_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBeamType_IFC2X3 : IfcBuildingElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBeamType_IFC2X3(string line) : base(line){}
    public IfcBeamType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBezierCurve_IFC2X3 : IfcBSplineCurve_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBezierCurve_IFC2X3(string line) : base(line){}
    public IfcBezierCurve_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBlobTexture_IFC2X3 : IfcSurfaceTexture_IFC2X3 {
    public string RasterFormat;
    public string RasterCode;

    public new List<string> param_order = new List<string>{"RasterFormat", "RasterCode"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBlobTexture_IFC2X3(string line) : base(line){}
    public IfcBlobTexture_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBlock_IFC2X3 : IfcCsgPrimitive3D_IFC2X3 {
    public string XLength;
    public string YLength;
    public string ZLength;

    public new List<string> param_order = new List<string>{"XLength", "YLength", "ZLength"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBlock_IFC2X3(string line) : base(line){}
    public IfcBlock_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBoilerType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoilerType_IFC2X3(string line) : base(line){}
    public IfcBoilerType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBooleanClippingResult_IFC2X3 : IfcBooleanResult_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBooleanClippingResult_IFC2X3(string line) : base(line){}
    public IfcBooleanClippingResult_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBooleanResult_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public string Operator;
    public IfcBooleanOperand_IFC2X3 FirstOperand;
    public IfcBooleanOperand_IFC2X3 SecondOperand;

    public new List<string> param_order = new List<string>{"Operator", "FirstOperand", "SecondOperand"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBooleanResult_IFC2X3(string line) : base(line){}
    public IfcBooleanResult_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundaryCondition_IFC2X3 : Entity {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundaryCondition_IFC2X3(string line) : base(line){}
    public IfcBoundaryCondition_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundaryEdgeCondition_IFC2X3 : IfcBoundaryCondition_IFC2X3 {
    public string LinearStiffnessByLengthX;
    public string LinearStiffnessByLengthY;
    public string LinearStiffnessByLengthZ;
    public string RotationalStiffnessByLengthX;
    public string RotationalStiffnessByLengthY;
    public string RotationalStiffnessByLengthZ;

    public new List<string> param_order = new List<string>{"LinearStiffnessByLengthX", "LinearStiffnessByLengthY", "LinearStiffnessByLengthZ", "RotationalStiffnessByLengthX", "RotationalStiffnessByLengthY", "RotationalStiffnessByLengthZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundaryEdgeCondition_IFC2X3(string line) : base(line){}
    public IfcBoundaryEdgeCondition_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundaryFaceCondition_IFC2X3 : IfcBoundaryCondition_IFC2X3 {
    public string LinearStiffnessByAreaX;
    public string LinearStiffnessByAreaY;
    public string LinearStiffnessByAreaZ;

    public new List<string> param_order = new List<string>{"LinearStiffnessByAreaX", "LinearStiffnessByAreaY", "LinearStiffnessByAreaZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundaryFaceCondition_IFC2X3(string line) : base(line){}
    public IfcBoundaryFaceCondition_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundaryNodeCondition_IFC2X3 : IfcBoundaryCondition_IFC2X3 {
    public string LinearStiffnessX;
    public string LinearStiffnessY;
    public string LinearStiffnessZ;
    public string RotationalStiffnessX;
    public string RotationalStiffnessY;
    public string RotationalStiffnessZ;

    public new List<string> param_order = new List<string>{"LinearStiffnessX", "LinearStiffnessY", "LinearStiffnessZ", "RotationalStiffnessX", "RotationalStiffnessY", "RotationalStiffnessZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundaryNodeCondition_IFC2X3(string line) : base(line){}
    public IfcBoundaryNodeCondition_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundaryNodeConditionWarping_IFC2X3 : IfcBoundaryNodeCondition_IFC2X3 {
    public string WarpingStiffness;

    public new List<string> param_order = new List<string>{"WarpingStiffness"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundaryNodeConditionWarping_IFC2X3(string line) : base(line){}
    public IfcBoundaryNodeConditionWarping_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundedCurve_IFC2X3 : IfcCurve_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundedCurve_IFC2X3(string line) : base(line){}
    public IfcBoundedCurve_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundedSurface_IFC2X3 : IfcSurface_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundedSurface_IFC2X3(string line) : base(line){}
    public IfcBoundedSurface_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundingBox_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public IfcCartesianPoint_IFC2X3 Corner;
    public string XDim;
    public string YDim;
    public string ZDim;

    public new List<string> param_order = new List<string>{"Corner", "XDim", "YDim", "ZDim"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundingBox_IFC2X3(string line) : base(line){}
    public IfcBoundingBox_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBoxedHalfSpace_IFC2X3 : IfcHalfSpaceSolid_IFC2X3 {
    public IfcBoundingBox_IFC2X3 Enclosure;

    public new List<string> param_order = new List<string>{"Enclosure"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoxedHalfSpace_IFC2X3(string line) : base(line){}
    public IfcBoxedHalfSpace_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBuilding_IFC2X3 : IfcSpatialStructureElement_IFC2X3 {
    public string ElevationOfRefHeight;
    public string ElevationOfTerrain;
    public IfcPostalAddress_IFC2X3 BuildingAddress;

    public new List<string> param_order = new List<string>{"ElevationOfRefHeight", "ElevationOfTerrain", "BuildingAddress"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuilding_IFC2X3(string line) : base(line){}
    public IfcBuilding_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingElement_IFC2X3 : IfcElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingElement_IFC2X3(string line) : base(line){}
    public IfcBuildingElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingElementComponent_IFC2X3 : IfcBuildingElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingElementComponent_IFC2X3(string line) : base(line){}
    public IfcBuildingElementComponent_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingElementPart_IFC2X3 : IfcBuildingElementComponent_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingElementPart_IFC2X3(string line) : base(line){}
    public IfcBuildingElementPart_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingElementProxy_IFC2X3 : IfcBuildingElement_IFC2X3 {
    public string CompositionType;

    public new List<string> param_order = new List<string>{"CompositionType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingElementProxy_IFC2X3(string line) : base(line){}
    public IfcBuildingElementProxy_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingElementProxyType_IFC2X3 : IfcBuildingElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingElementProxyType_IFC2X3(string line) : base(line){}
    public IfcBuildingElementProxyType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingElementType_IFC2X3 : IfcElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingElementType_IFC2X3(string line) : base(line){}
    public IfcBuildingElementType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingStorey_IFC2X3 : IfcSpatialStructureElement_IFC2X3 {
    public string Elevation;

    public new List<string> param_order = new List<string>{"Elevation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingStorey_IFC2X3(string line) : base(line){}
    public IfcBuildingStorey_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCShapeProfileDef_IFC2X3 : IfcParameterizedProfileDef_IFC2X3 {
    public string Depth;
    public string Width;
    public string WallThickness;
    public string Girth;
    public string InternalFilletRadius;
    public string CentreOfGravityInX;

    public new List<string> param_order = new List<string>{"Depth", "Width", "WallThickness", "Girth", "InternalFilletRadius", "CentreOfGravityInX"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCShapeProfileDef_IFC2X3(string line) : base(line){}
    public IfcCShapeProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCableCarrierFittingType_IFC2X3 : IfcFlowFittingType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCableCarrierFittingType_IFC2X3(string line) : base(line){}
    public IfcCableCarrierFittingType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCableCarrierSegmentType_IFC2X3 : IfcFlowSegmentType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCableCarrierSegmentType_IFC2X3(string line) : base(line){}
    public IfcCableCarrierSegmentType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCableSegmentType_IFC2X3 : IfcFlowSegmentType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCableSegmentType_IFC2X3(string line) : base(line){}
    public IfcCableSegmentType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCalendarDate_IFC2X3 : Entity {
    public string DayComponent;
    public string MonthComponent;
    public string YearComponent;

    public new List<string> param_order = new List<string>{"DayComponent", "MonthComponent", "YearComponent"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCalendarDate_IFC2X3(string line) : base(line){}
    public IfcCalendarDate_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianPoint_IFC2X3 : IfcPoint_IFC2X3 {
    public List<string> Coordinates;

    public new List<string> param_order = new List<string>{"Coordinates"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianPoint_IFC2X3(string line) : base(line){}
    public IfcCartesianPoint_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianTransformationOperator_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public IfcDirection_IFC2X3 Axis1;
    public IfcDirection_IFC2X3 Axis2;
    public IfcCartesianPoint_IFC2X3 LocalOrigin;
    public string Scale;

    public new List<string> param_order = new List<string>{"Axis1", "Axis2", "LocalOrigin", "Scale"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianTransformationOperator_IFC2X3(string line) : base(line){}
    public IfcCartesianTransformationOperator_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianTransformationOperator2D_IFC2X3 : IfcCartesianTransformationOperator_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianTransformationOperator2D_IFC2X3(string line) : base(line){}
    public IfcCartesianTransformationOperator2D_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianTransformationOperator2DnonUniform_IFC2X3 : IfcCartesianTransformationOperator2D_IFC2X3 {
    public string Scale2;

    public new List<string> param_order = new List<string>{"Scale2"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianTransformationOperator2DnonUniform_IFC2X3(string line) : base(line){}
    public IfcCartesianTransformationOperator2DnonUniform_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianTransformationOperator3D_IFC2X3 : IfcCartesianTransformationOperator_IFC2X3 {
    public IfcDirection_IFC2X3 Axis3;

    public new List<string> param_order = new List<string>{"Axis3"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianTransformationOperator3D_IFC2X3(string line) : base(line){}
    public IfcCartesianTransformationOperator3D_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianTransformationOperator3DnonUniform_IFC2X3 : IfcCartesianTransformationOperator3D_IFC2X3 {
    public string Scale2;
    public string Scale3;

    public new List<string> param_order = new List<string>{"Scale2", "Scale3"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianTransformationOperator3DnonUniform_IFC2X3(string line) : base(line){}
    public IfcCartesianTransformationOperator3DnonUniform_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCenterLineProfileDef_IFC2X3 : IfcArbitraryOpenProfileDef_IFC2X3 {
    public string Thickness;

    public new List<string> param_order = new List<string>{"Thickness"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCenterLineProfileDef_IFC2X3(string line) : base(line){}
    public IfcCenterLineProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcChamferEdgeFeature_IFC2X3 : IfcEdgeFeature_IFC2X3 {
    public string Width;
    public string Height;

    public new List<string> param_order = new List<string>{"Width", "Height"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcChamferEdgeFeature_IFC2X3(string line) : base(line){}
    public IfcChamferEdgeFeature_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcChillerType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcChillerType_IFC2X3(string line) : base(line){}
    public IfcChillerType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCircle_IFC2X3 : IfcConic_IFC2X3 {
    public string Radius;

    public new List<string> param_order = new List<string>{"Radius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCircle_IFC2X3(string line) : base(line){}
    public IfcCircle_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCircleHollowProfileDef_IFC2X3 : IfcCircleProfileDef_IFC2X3 {
    public string WallThickness;

    public new List<string> param_order = new List<string>{"WallThickness"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCircleHollowProfileDef_IFC2X3(string line) : base(line){}
    public IfcCircleHollowProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCircleProfileDef_IFC2X3 : IfcParameterizedProfileDef_IFC2X3 {
    public string Radius;

    public new List<string> param_order = new List<string>{"Radius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCircleProfileDef_IFC2X3(string line) : base(line){}
    public IfcCircleProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcClassification_IFC2X3 : Entity {
    public string Source;
    public string Edition;
    public IfcCalendarDate_IFC2X3 EditionDate;
    public string Name;

    public new List<string> param_order = new List<string>{"Source", "Edition", "EditionDate", "Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcClassification_IFC2X3(string line) : base(line){}
    public IfcClassification_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcClassificationItem_IFC2X3 : Entity {
    public IfcClassificationNotationFacet_IFC2X3 Notation;
    public IfcClassification_IFC2X3 ItemOf;
    public string Title;

    public new List<string> param_order = new List<string>{"Notation", "ItemOf", "Title"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcClassificationItem_IFC2X3(string line) : base(line){}
    public IfcClassificationItem_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcClassificationItemRelationship_IFC2X3 : Entity {
    public IfcClassificationItem_IFC2X3 RelatingItem;
    public List<IfcClassificationItem_IFC2X3> RelatedItems;

    public new List<string> param_order = new List<string>{"RelatingItem", "RelatedItems"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcClassificationItemRelationship_IFC2X3(string line) : base(line){}
    public IfcClassificationItemRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcClassificationNotation_IFC2X3 : Entity {
    public List<IfcClassificationNotationFacet_IFC2X3> NotationFacets;

    public new List<string> param_order = new List<string>{"NotationFacets"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcClassificationNotation_IFC2X3(string line) : base(line){}
    public IfcClassificationNotation_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcClassificationNotationFacet_IFC2X3 : Entity {
    public string NotationValue;

    public new List<string> param_order = new List<string>{"NotationValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcClassificationNotationFacet_IFC2X3(string line) : base(line){}
    public IfcClassificationNotationFacet_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcClassificationReference_IFC2X3 : IfcExternalReference_IFC2X3 {
    public IfcClassification_IFC2X3 ReferencedSource;

    public new List<string> param_order = new List<string>{"ReferencedSource"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcClassificationReference_IFC2X3(string line) : base(line){}
    public IfcClassificationReference_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcClosedShell_IFC2X3 : IfcConnectedFaceSet_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcClosedShell_IFC2X3(string line) : base(line){}
    public IfcClosedShell_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCoilType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCoilType_IFC2X3(string line) : base(line){}
    public IfcCoilType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcColourRgb_IFC2X3 : IfcColourSpecification_IFC2X3 {
    public string Red;
    public string Green;
    public string Blue;

    public new List<string> param_order = new List<string>{"Red", "Green", "Blue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcColourRgb_IFC2X3(string line) : base(line){}
    public IfcColourRgb_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcColourSpecification_IFC2X3 : Entity {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcColourSpecification_IFC2X3(string line) : base(line){}
    public IfcColourSpecification_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcColumn_IFC2X3 : IfcBuildingElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcColumn_IFC2X3(string line) : base(line){}
    public IfcColumn_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcColumnType_IFC2X3 : IfcBuildingElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcColumnType_IFC2X3(string line) : base(line){}
    public IfcColumnType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcComplexProperty_IFC2X3 : IfcProperty_IFC2X3 {
    public string UsageName;
    public List<IfcProperty_IFC2X3> HasProperties;

    public new List<string> param_order = new List<string>{"UsageName", "HasProperties"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcComplexProperty_IFC2X3(string line) : base(line){}
    public IfcComplexProperty_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCompositeCurve_IFC2X3 : IfcBoundedCurve_IFC2X3 {
    public List<IfcCompositeCurveSegment_IFC2X3> Segments;
    public string SelfIntersect;

    public new List<string> param_order = new List<string>{"Segments", "SelfIntersect"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCompositeCurve_IFC2X3(string line) : base(line){}
    public IfcCompositeCurve_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCompositeCurveSegment_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public string Transition;
    public string SameSense;
    public IfcCurve_IFC2X3 ParentCurve;

    public new List<string> param_order = new List<string>{"Transition", "SameSense", "ParentCurve"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCompositeCurveSegment_IFC2X3(string line) : base(line){}
    public IfcCompositeCurveSegment_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCompositeProfileDef_IFC2X3 : IfcProfileDef_IFC2X3 {
    public List<IfcProfileDef_IFC2X3> Profiles;
    public string Label;

    public new List<string> param_order = new List<string>{"Profiles", "Label"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCompositeProfileDef_IFC2X3(string line) : base(line){}
    public IfcCompositeProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCompressorType_IFC2X3 : IfcFlowMovingDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCompressorType_IFC2X3(string line) : base(line){}
    public IfcCompressorType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCondenserType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCondenserType_IFC2X3(string line) : base(line){}
    public IfcCondenserType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCondition_IFC2X3 : IfcGroup_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCondition_IFC2X3(string line) : base(line){}
    public IfcCondition_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConditionCriterion_IFC2X3 : IfcControl_IFC2X3 {
    public IfcConditionCriterionSelect_IFC2X3 Criterion;
    public IfcDateTimeSelect_IFC2X3 CriterionDateTime;

    public new List<string> param_order = new List<string>{"Criterion", "CriterionDateTime"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConditionCriterion_IFC2X3(string line) : base(line){}
    public IfcConditionCriterion_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConic_IFC2X3 : IfcCurve_IFC2X3 {
    public IfcAxis2Placement_IFC2X3 Position;

    public new List<string> param_order = new List<string>{"Position"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConic_IFC2X3(string line) : base(line){}
    public IfcConic_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConnectedFaceSet_IFC2X3 : IfcTopologicalRepresentationItem_IFC2X3 {
    public List<IfcFace_IFC2X3> CfsFaces;

    public new List<string> param_order = new List<string>{"CfsFaces"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConnectedFaceSet_IFC2X3(string line) : base(line){}
    public IfcConnectedFaceSet_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConnectionCurveGeometry_IFC2X3 : IfcConnectionGeometry_IFC2X3 {
    public IfcCurveOrEdgeCurve_IFC2X3 CurveOnRelatingElement;
    public IfcCurveOrEdgeCurve_IFC2X3 CurveOnRelatedElement;

    public new List<string> param_order = new List<string>{"CurveOnRelatingElement", "CurveOnRelatedElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConnectionCurveGeometry_IFC2X3(string line) : base(line){}
    public IfcConnectionCurveGeometry_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConnectionGeometry_IFC2X3 : Entity {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConnectionGeometry_IFC2X3(string line) : base(line){}
    public IfcConnectionGeometry_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConnectionPointEccentricity_IFC2X3 : IfcConnectionPointGeometry_IFC2X3 {
    public string EccentricityInX;
    public string EccentricityInY;
    public string EccentricityInZ;

    public new List<string> param_order = new List<string>{"EccentricityInX", "EccentricityInY", "EccentricityInZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConnectionPointEccentricity_IFC2X3(string line) : base(line){}
    public IfcConnectionPointEccentricity_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConnectionPointGeometry_IFC2X3 : IfcConnectionGeometry_IFC2X3 {
    public IfcPointOrVertexPoint_IFC2X3 PointOnRelatingElement;
    public IfcPointOrVertexPoint_IFC2X3 PointOnRelatedElement;

    public new List<string> param_order = new List<string>{"PointOnRelatingElement", "PointOnRelatedElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConnectionPointGeometry_IFC2X3(string line) : base(line){}
    public IfcConnectionPointGeometry_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConnectionPortGeometry_IFC2X3 : IfcConnectionGeometry_IFC2X3 {
    public IfcAxis2Placement_IFC2X3 LocationAtRelatingElement;
    public IfcAxis2Placement_IFC2X3 LocationAtRelatedElement;
    public IfcProfileDef_IFC2X3 ProfileOfPort;

    public new List<string> param_order = new List<string>{"LocationAtRelatingElement", "LocationAtRelatedElement", "ProfileOfPort"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConnectionPortGeometry_IFC2X3(string line) : base(line){}
    public IfcConnectionPortGeometry_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConnectionSurfaceGeometry_IFC2X3 : IfcConnectionGeometry_IFC2X3 {
    public IfcSurfaceOrFaceSurface_IFC2X3 SurfaceOnRelatingElement;
    public IfcSurfaceOrFaceSurface_IFC2X3 SurfaceOnRelatedElement;

    public new List<string> param_order = new List<string>{"SurfaceOnRelatingElement", "SurfaceOnRelatedElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConnectionSurfaceGeometry_IFC2X3(string line) : base(line){}
    public IfcConnectionSurfaceGeometry_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConstraint_IFC2X3 : Entity {
    public string Name;
    public string Description;
    public string ConstraintGrade;
    public string ConstraintSource;
    public IfcActorSelect_IFC2X3 CreatingActor;
    public IfcDateTimeSelect_IFC2X3 CreationTime;
    public string UserDefinedGrade;

    public new List<string> param_order = new List<string>{"Name", "Description", "ConstraintGrade", "ConstraintSource", "CreatingActor", "CreationTime", "UserDefinedGrade"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstraint_IFC2X3(string line) : base(line){}
    public IfcConstraint_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConstraintAggregationRelationship_IFC2X3 : Entity {
    public string Name;
    public string Description;
    public IfcConstraint_IFC2X3 RelatingConstraint;
    public List<IfcConstraint_IFC2X3> RelatedConstraints;
    public string LogicalAggregator;

    public new List<string> param_order = new List<string>{"Name", "Description", "RelatingConstraint", "RelatedConstraints", "LogicalAggregator"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstraintAggregationRelationship_IFC2X3(string line) : base(line){}
    public IfcConstraintAggregationRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConstraintClassificationRelationship_IFC2X3 : Entity {
    public IfcConstraint_IFC2X3 ClassifiedConstraint;
    public List<IfcClassificationNotationSelect_IFC2X3> RelatedClassifications;

    public new List<string> param_order = new List<string>{"ClassifiedConstraint", "RelatedClassifications"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstraintClassificationRelationship_IFC2X3(string line) : base(line){}
    public IfcConstraintClassificationRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConstraintRelationship_IFC2X3 : Entity {
    public string Name;
    public string Description;
    public IfcConstraint_IFC2X3 RelatingConstraint;
    public List<IfcConstraint_IFC2X3> RelatedConstraints;

    public new List<string> param_order = new List<string>{"Name", "Description", "RelatingConstraint", "RelatedConstraints"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstraintRelationship_IFC2X3(string line) : base(line){}
    public IfcConstraintRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConstructionEquipmentResource_IFC2X3 : IfcConstructionResource_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstructionEquipmentResource_IFC2X3(string line) : base(line){}
    public IfcConstructionEquipmentResource_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConstructionMaterialResource_IFC2X3 : IfcConstructionResource_IFC2X3 {
    public List<IfcActorSelect_IFC2X3> Suppliers;
    public string UsageRatio;

    public new List<string> param_order = new List<string>{"Suppliers", "UsageRatio"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstructionMaterialResource_IFC2X3(string line) : base(line){}
    public IfcConstructionMaterialResource_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConstructionProductResource_IFC2X3 : IfcConstructionResource_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstructionProductResource_IFC2X3(string line) : base(line){}
    public IfcConstructionProductResource_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConstructionResource_IFC2X3 : IfcResource_IFC2X3 {
    public string ResourceIdentifier;
    public string ResourceGroup;
    public string ResourceConsumption;
    public IfcMeasureWithUnit_IFC2X3 BaseQuantity;

    public new List<string> param_order = new List<string>{"ResourceIdentifier", "ResourceGroup", "ResourceConsumption", "BaseQuantity"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstructionResource_IFC2X3(string line) : base(line){}
    public IfcConstructionResource_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcContextDependentUnit_IFC2X3 : IfcNamedUnit_IFC2X3 {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcContextDependentUnit_IFC2X3(string line) : base(line){}
    public IfcContextDependentUnit_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcControl_IFC2X3 : IfcObject_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcControl_IFC2X3(string line) : base(line){}
    public IfcControl_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcControllerType_IFC2X3 : IfcDistributionControlElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcControllerType_IFC2X3(string line) : base(line){}
    public IfcControllerType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcConversionBasedUnit_IFC2X3 : IfcNamedUnit_IFC2X3 {
    public string Name;
    public IfcMeasureWithUnit_IFC2X3 ConversionFactor;

    public new List<string> param_order = new List<string>{"Name", "ConversionFactor"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConversionBasedUnit_IFC2X3(string line) : base(line){}
    public IfcConversionBasedUnit_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCooledBeamType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCooledBeamType_IFC2X3(string line) : base(line){}
    public IfcCooledBeamType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCoolingTowerType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCoolingTowerType_IFC2X3(string line) : base(line){}
    public IfcCoolingTowerType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCoordinatedUniversalTimeOffset_IFC2X3 : Entity {
    public string HourOffset;
    public string MinuteOffset;
    public string Sense;

    public new List<string> param_order = new List<string>{"HourOffset", "MinuteOffset", "Sense"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCoordinatedUniversalTimeOffset_IFC2X3(string line) : base(line){}
    public IfcCoordinatedUniversalTimeOffset_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCostItem_IFC2X3 : IfcControl_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCostItem_IFC2X3(string line) : base(line){}
    public IfcCostItem_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCostSchedule_IFC2X3 : IfcControl_IFC2X3 {
    public IfcActorSelect_IFC2X3 SubmittedBy;
    public IfcActorSelect_IFC2X3 PreparedBy;
    public IfcDateTimeSelect_IFC2X3 SubmittedOn;
    public string Status;
    public List<IfcActorSelect_IFC2X3> TargetUsers;
    public IfcDateTimeSelect_IFC2X3 UpdateDate;
    public string ID;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"SubmittedBy", "PreparedBy", "SubmittedOn", "Status", "TargetUsers", "UpdateDate", "ID", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCostSchedule_IFC2X3(string line) : base(line){}
    public IfcCostSchedule_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCostValue_IFC2X3 : IfcAppliedValue_IFC2X3 {
    public string CostType;
    public string Condition;

    public new List<string> param_order = new List<string>{"CostType", "Condition"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCostValue_IFC2X3(string line) : base(line){}
    public IfcCostValue_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCovering_IFC2X3 : IfcBuildingElement_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCovering_IFC2X3(string line) : base(line){}
    public IfcCovering_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCoveringType_IFC2X3 : IfcBuildingElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCoveringType_IFC2X3(string line) : base(line){}
    public IfcCoveringType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCraneRailAShapeProfileDef_IFC2X3 : IfcParameterizedProfileDef_IFC2X3 {
    public string OverallHeight;
    public string BaseWidth2;
    public string Radius;
    public string HeadWidth;
    public string HeadDepth2;
    public string HeadDepth3;
    public string WebThickness;
    public string BaseWidth4;
    public string BaseDepth1;
    public string BaseDepth2;
    public string BaseDepth3;
    public string CentreOfGravityInY;

    public new List<string> param_order = new List<string>{"OverallHeight", "BaseWidth2", "Radius", "HeadWidth", "HeadDepth2", "HeadDepth3", "WebThickness", "BaseWidth4", "BaseDepth1", "BaseDepth2", "BaseDepth3", "CentreOfGravityInY"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCraneRailAShapeProfileDef_IFC2X3(string line) : base(line){}
    public IfcCraneRailAShapeProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCraneRailFShapeProfileDef_IFC2X3 : IfcParameterizedProfileDef_IFC2X3 {
    public string OverallHeight;
    public string HeadWidth;
    public string Radius;
    public string HeadDepth2;
    public string HeadDepth3;
    public string WebThickness;
    public string BaseDepth1;
    public string BaseDepth2;
    public string CentreOfGravityInY;

    public new List<string> param_order = new List<string>{"OverallHeight", "HeadWidth", "Radius", "HeadDepth2", "HeadDepth3", "WebThickness", "BaseDepth1", "BaseDepth2", "CentreOfGravityInY"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCraneRailFShapeProfileDef_IFC2X3(string line) : base(line){}
    public IfcCraneRailFShapeProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCrewResource_IFC2X3 : IfcConstructionResource_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCrewResource_IFC2X3(string line) : base(line){}
    public IfcCrewResource_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCsgPrimitive3D_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public IfcAxis2Placement3D_IFC2X3 Position;

    public new List<string> param_order = new List<string>{"Position"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCsgPrimitive3D_IFC2X3(string line) : base(line){}
    public IfcCsgPrimitive3D_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCsgSolid_IFC2X3 : IfcSolidModel_IFC2X3 {
    public IfcCsgSelect_IFC2X3 TreeRootExpression;

    public new List<string> param_order = new List<string>{"TreeRootExpression"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCsgSolid_IFC2X3(string line) : base(line){}
    public IfcCsgSolid_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCurrencyRelationship_IFC2X3 : Entity {
    public IfcMonetaryUnit_IFC2X3 RelatingMonetaryUnit;
    public IfcMonetaryUnit_IFC2X3 RelatedMonetaryUnit;
    public string ExchangeRate;
    public IfcDateAndTime_IFC2X3 RateDateTime;
    public IfcLibraryInformation_IFC2X3 RateSource;

    public new List<string> param_order = new List<string>{"RelatingMonetaryUnit", "RelatedMonetaryUnit", "ExchangeRate", "RateDateTime", "RateSource"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurrencyRelationship_IFC2X3(string line) : base(line){}
    public IfcCurrencyRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCurtainWall_IFC2X3 : IfcBuildingElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurtainWall_IFC2X3(string line) : base(line){}
    public IfcCurtainWall_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCurtainWallType_IFC2X3 : IfcBuildingElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurtainWallType_IFC2X3(string line) : base(line){}
    public IfcCurtainWallType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCurve_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurve_IFC2X3(string line) : base(line){}
    public IfcCurve_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCurveBoundedPlane_IFC2X3 : IfcBoundedSurface_IFC2X3 {
    public IfcPlane_IFC2X3 BasisSurface;
    public IfcCurve_IFC2X3 OuterBoundary;
    public List<IfcCurve_IFC2X3> InnerBoundaries;

    public new List<string> param_order = new List<string>{"BasisSurface", "OuterBoundary", "InnerBoundaries"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurveBoundedPlane_IFC2X3(string line) : base(line){}
    public IfcCurveBoundedPlane_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCurveStyle_IFC2X3 : IfcPresentationStyle_IFC2X3 {
    public IfcCurveFontOrScaledCurveFontSelect_IFC2X3 CurveFont;
    public IfcSizeSelect_IFC2X3 CurveWidth;
    public IfcColour_IFC2X3 CurveColour;

    public new List<string> param_order = new List<string>{"CurveFont", "CurveWidth", "CurveColour"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurveStyle_IFC2X3(string line) : base(line){}
    public IfcCurveStyle_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCurveStyleFont_IFC2X3 : Entity {
    public string Name;
    public List<IfcCurveStyleFontPattern_IFC2X3> PatternList;

    public new List<string> param_order = new List<string>{"Name", "PatternList"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurveStyleFont_IFC2X3(string line) : base(line){}
    public IfcCurveStyleFont_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCurveStyleFontAndScaling_IFC2X3 : Entity {
    public string Name;
    public IfcCurveStyleFontSelect_IFC2X3 CurveFont;
    public string CurveFontScaling;

    public new List<string> param_order = new List<string>{"Name", "CurveFont", "CurveFontScaling"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurveStyleFontAndScaling_IFC2X3(string line) : base(line){}
    public IfcCurveStyleFontAndScaling_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcCurveStyleFontPattern_IFC2X3 : Entity {
    public string VisibleSegmentLength;
    public string InvisibleSegmentLength;

    public new List<string> param_order = new List<string>{"VisibleSegmentLength", "InvisibleSegmentLength"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurveStyleFontPattern_IFC2X3(string line) : base(line){}
    public IfcCurveStyleFontPattern_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDamperType_IFC2X3 : IfcFlowControllerType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDamperType_IFC2X3(string line) : base(line){}
    public IfcDamperType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDateAndTime_IFC2X3 : Entity {
    public IfcCalendarDate_IFC2X3 DateComponent;
    public IfcLocalTime_IFC2X3 TimeComponent;

    public new List<string> param_order = new List<string>{"DateComponent", "TimeComponent"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDateAndTime_IFC2X3(string line) : base(line){}
    public IfcDateAndTime_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDefinedSymbol_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public IfcDefinedSymbolSelect_IFC2X3 Definition;
    public IfcCartesianTransformationOperator2D_IFC2X3 Target;

    public new List<string> param_order = new List<string>{"Definition", "Target"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDefinedSymbol_IFC2X3(string line) : base(line){}
    public IfcDefinedSymbol_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDerivedProfileDef_IFC2X3 : IfcProfileDef_IFC2X3 {
    public IfcProfileDef_IFC2X3 ParentProfile;
    public IfcCartesianTransformationOperator2D_IFC2X3 Operator;
    public string Label;

    public new List<string> param_order = new List<string>{"ParentProfile", "Operator", "Label"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDerivedProfileDef_IFC2X3(string line) : base(line){}
    public IfcDerivedProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDerivedUnit_IFC2X3 : Entity {
    public List<IfcDerivedUnitElement_IFC2X3> Elements;
    public string UnitType;
    public string UserDefinedType;

    public new List<string> param_order = new List<string>{"Elements", "UnitType", "UserDefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDerivedUnit_IFC2X3(string line) : base(line){}
    public IfcDerivedUnit_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDerivedUnitElement_IFC2X3 : Entity {
    public IfcNamedUnit_IFC2X3 Unit;
    public string Exponent;

    public new List<string> param_order = new List<string>{"Unit", "Exponent"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDerivedUnitElement_IFC2X3(string line) : base(line){}
    public IfcDerivedUnitElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDiameterDimension_IFC2X3 : IfcDimensionCurveDirectedCallout_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDiameterDimension_IFC2X3(string line) : base(line){}
    public IfcDiameterDimension_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDimensionCalloutRelationship_IFC2X3 : IfcDraughtingCalloutRelationship_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDimensionCalloutRelationship_IFC2X3(string line) : base(line){}
    public IfcDimensionCalloutRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDimensionCurve_IFC2X3 : IfcAnnotationCurveOccurrence_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDimensionCurve_IFC2X3(string line) : base(line){}
    public IfcDimensionCurve_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDimensionCurveDirectedCallout_IFC2X3 : IfcDraughtingCallout_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDimensionCurveDirectedCallout_IFC2X3(string line) : base(line){}
    public IfcDimensionCurveDirectedCallout_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDimensionCurveTerminator_IFC2X3 : IfcTerminatorSymbol_IFC2X3 {
    public string Role;

    public new List<string> param_order = new List<string>{"Role"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDimensionCurveTerminator_IFC2X3(string line) : base(line){}
    public IfcDimensionCurveTerminator_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDimensionPair_IFC2X3 : IfcDraughtingCalloutRelationship_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDimensionPair_IFC2X3(string line) : base(line){}
    public IfcDimensionPair_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDimensionalExponents_IFC2X3 : Entity {
    public string LengthExponent;
    public string MassExponent;
    public string TimeExponent;
    public string ElectricCurrentExponent;
    public string ThermodynamicTemperatureExponent;
    public string AmountOfSubstanceExponent;
    public string LuminousIntensityExponent;

    public new List<string> param_order = new List<string>{"LengthExponent", "MassExponent", "TimeExponent", "ElectricCurrentExponent", "ThermodynamicTemperatureExponent", "AmountOfSubstanceExponent", "LuminousIntensityExponent"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDimensionalExponents_IFC2X3(string line) : base(line){}
    public IfcDimensionalExponents_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDirection_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public List<string> DirectionRatios;

    public new List<string> param_order = new List<string>{"DirectionRatios"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDirection_IFC2X3(string line) : base(line){}
    public IfcDirection_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDiscreteAccessory_IFC2X3 : IfcElementComponent_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDiscreteAccessory_IFC2X3(string line) : base(line){}
    public IfcDiscreteAccessory_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDiscreteAccessoryType_IFC2X3 : IfcElementComponentType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDiscreteAccessoryType_IFC2X3(string line) : base(line){}
    public IfcDiscreteAccessoryType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionChamberElement_IFC2X3 : IfcDistributionFlowElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionChamberElement_IFC2X3(string line) : base(line){}
    public IfcDistributionChamberElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionChamberElementType_IFC2X3 : IfcDistributionFlowElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionChamberElementType_IFC2X3(string line) : base(line){}
    public IfcDistributionChamberElementType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionControlElement_IFC2X3 : IfcDistributionElement_IFC2X3 {
    public string ControlElementId;

    public new List<string> param_order = new List<string>{"ControlElementId"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionControlElement_IFC2X3(string line) : base(line){}
    public IfcDistributionControlElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionControlElementType_IFC2X3 : IfcDistributionElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionControlElementType_IFC2X3(string line) : base(line){}
    public IfcDistributionControlElementType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionElement_IFC2X3 : IfcElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionElement_IFC2X3(string line) : base(line){}
    public IfcDistributionElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionElementType_IFC2X3 : IfcElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionElementType_IFC2X3(string line) : base(line){}
    public IfcDistributionElementType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionFlowElement_IFC2X3 : IfcDistributionElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionFlowElement_IFC2X3(string line) : base(line){}
    public IfcDistributionFlowElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionFlowElementType_IFC2X3 : IfcDistributionElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionFlowElementType_IFC2X3(string line) : base(line){}
    public IfcDistributionFlowElementType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionPort_IFC2X3 : IfcPort_IFC2X3 {
    public string FlowDirection;

    public new List<string> param_order = new List<string>{"FlowDirection"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionPort_IFC2X3(string line) : base(line){}
    public IfcDistributionPort_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDocumentElectronicFormat_IFC2X3 : Entity {
    public string FileExtension;
    public string MimeContentType;
    public string MimeSubtype;

    public new List<string> param_order = new List<string>{"FileExtension", "MimeContentType", "MimeSubtype"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDocumentElectronicFormat_IFC2X3(string line) : base(line){}
    public IfcDocumentElectronicFormat_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDocumentInformation_IFC2X3 : Entity {
    public string DocumentId;
    public string Name;
    public string Description;
    public List<IfcDocumentReference_IFC2X3> DocumentReferences;
    public string Purpose;
    public string IntendedUse;
    public string Scope;
    public string Revision;
    public IfcActorSelect_IFC2X3 DocumentOwner;
    public List<IfcActorSelect_IFC2X3> Editors;
    public IfcDateAndTime_IFC2X3 CreationTime;
    public IfcDateAndTime_IFC2X3 LastRevisionTime;
    public IfcDocumentElectronicFormat_IFC2X3 ElectronicFormat;
    public IfcCalendarDate_IFC2X3 ValidFrom;
    public IfcCalendarDate_IFC2X3 ValidUntil;
    public string Confidentiality;
    public string Status;

    public new List<string> param_order = new List<string>{"DocumentId", "Name", "Description", "DocumentReferences", "Purpose", "IntendedUse", "Scope", "Revision", "DocumentOwner", "Editors", "CreationTime", "LastRevisionTime", "ElectronicFormat", "ValidFrom", "ValidUntil", "Confidentiality", "Status"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDocumentInformation_IFC2X3(string line) : base(line){}
    public IfcDocumentInformation_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDocumentInformationRelationship_IFC2X3 : Entity {
    public IfcDocumentInformation_IFC2X3 RelatingDocument;
    public List<IfcDocumentInformation_IFC2X3> RelatedDocuments;
    public string RelationshipType;

    public new List<string> param_order = new List<string>{"RelatingDocument", "RelatedDocuments", "RelationshipType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDocumentInformationRelationship_IFC2X3(string line) : base(line){}
    public IfcDocumentInformationRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDocumentReference_IFC2X3 : IfcExternalReference_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDocumentReference_IFC2X3(string line) : base(line){}
    public IfcDocumentReference_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDoor_IFC2X3 : IfcBuildingElement_IFC2X3 {
    public string OverallHeight;
    public string OverallWidth;

    public new List<string> param_order = new List<string>{"OverallHeight", "OverallWidth"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDoor_IFC2X3(string line) : base(line){}
    public IfcDoor_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDoorLiningProperties_IFC2X3 : IfcPropertySetDefinition_IFC2X3 {
    public string LiningDepth;
    public string LiningThickness;
    public string ThresholdDepth;
    public string ThresholdThickness;
    public string TransomThickness;
    public string TransomOffset;
    public string LiningOffset;
    public string ThresholdOffset;
    public string CasingThickness;
    public string CasingDepth;
    public IfcShapeAspect_IFC2X3 ShapeAspectStyle;

    public new List<string> param_order = new List<string>{"LiningDepth", "LiningThickness", "ThresholdDepth", "ThresholdThickness", "TransomThickness", "TransomOffset", "LiningOffset", "ThresholdOffset", "CasingThickness", "CasingDepth", "ShapeAspectStyle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDoorLiningProperties_IFC2X3(string line) : base(line){}
    public IfcDoorLiningProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDoorPanelProperties_IFC2X3 : IfcPropertySetDefinition_IFC2X3 {
    public string PanelDepth;
    public string PanelOperation;
    public string PanelWidth;
    public string PanelPosition;
    public IfcShapeAspect_IFC2X3 ShapeAspectStyle;

    public new List<string> param_order = new List<string>{"PanelDepth", "PanelOperation", "PanelWidth", "PanelPosition", "ShapeAspectStyle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDoorPanelProperties_IFC2X3(string line) : base(line){}
    public IfcDoorPanelProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDoorStyle_IFC2X3 : IfcTypeProduct_IFC2X3 {
    public string OperationType;
    public string ConstructionType;
    public string ParameterTakesPrecedence;
    public string Sizeable;

    public new List<string> param_order = new List<string>{"OperationType", "ConstructionType", "ParameterTakesPrecedence", "Sizeable"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDoorStyle_IFC2X3(string line) : base(line){}
    public IfcDoorStyle_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDraughtingCallout_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public List<IfcDraughtingCalloutElement_IFC2X3> Contents;

    public new List<string> param_order = new List<string>{"Contents"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDraughtingCallout_IFC2X3(string line) : base(line){}
    public IfcDraughtingCallout_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDraughtingCalloutRelationship_IFC2X3 : Entity {
    public string Name;
    public string Description;
    public IfcDraughtingCallout_IFC2X3 RelatingDraughtingCallout;
    public IfcDraughtingCallout_IFC2X3 RelatedDraughtingCallout;

    public new List<string> param_order = new List<string>{"Name", "Description", "RelatingDraughtingCallout", "RelatedDraughtingCallout"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDraughtingCalloutRelationship_IFC2X3(string line) : base(line){}
    public IfcDraughtingCalloutRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDraughtingPreDefinedColour_IFC2X3 : IfcPreDefinedColour_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDraughtingPreDefinedColour_IFC2X3(string line) : base(line){}
    public IfcDraughtingPreDefinedColour_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDraughtingPreDefinedCurveFont_IFC2X3 : IfcPreDefinedCurveFont_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDraughtingPreDefinedCurveFont_IFC2X3(string line) : base(line){}
    public IfcDraughtingPreDefinedCurveFont_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDraughtingPreDefinedTextFont_IFC2X3 : IfcPreDefinedTextFont_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDraughtingPreDefinedTextFont_IFC2X3(string line) : base(line){}
    public IfcDraughtingPreDefinedTextFont_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDuctFittingType_IFC2X3 : IfcFlowFittingType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDuctFittingType_IFC2X3(string line) : base(line){}
    public IfcDuctFittingType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDuctSegmentType_IFC2X3 : IfcFlowSegmentType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDuctSegmentType_IFC2X3(string line) : base(line){}
    public IfcDuctSegmentType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcDuctSilencerType_IFC2X3 : IfcFlowTreatmentDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDuctSilencerType_IFC2X3(string line) : base(line){}
    public IfcDuctSilencerType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcEdge_IFC2X3 : IfcTopologicalRepresentationItem_IFC2X3 {
    public IfcVertex_IFC2X3 EdgeStart;
    public IfcVertex_IFC2X3 EdgeEnd;

    public new List<string> param_order = new List<string>{"EdgeStart", "EdgeEnd"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEdge_IFC2X3(string line) : base(line){}
    public IfcEdge_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcEdgeCurve_IFC2X3 : IfcEdge_IFC2X3 {
    public IfcCurve_IFC2X3 EdgeGeometry;
    public string SameSense;

    public new List<string> param_order = new List<string>{"EdgeGeometry", "SameSense"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEdgeCurve_IFC2X3(string line) : base(line){}
    public IfcEdgeCurve_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcEdgeFeature_IFC2X3 : IfcFeatureElementSubtraction_IFC2X3 {
    public string FeatureLength;

    public new List<string> param_order = new List<string>{"FeatureLength"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEdgeFeature_IFC2X3(string line) : base(line){}
    public IfcEdgeFeature_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcEdgeLoop_IFC2X3 : IfcLoop_IFC2X3 {
    public List<IfcOrientedEdge_IFC2X3> EdgeList;

    public new List<string> param_order = new List<string>{"EdgeList"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEdgeLoop_IFC2X3(string line) : base(line){}
    public IfcEdgeLoop_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricApplianceType_IFC2X3 : IfcFlowTerminalType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricApplianceType_IFC2X3(string line) : base(line){}
    public IfcElectricApplianceType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricDistributionPoint_IFC2X3 : IfcFlowController_IFC2X3 {
    public string DistributionPointFunction;
    public string UserDefinedFunction;

    public new List<string> param_order = new List<string>{"DistributionPointFunction", "UserDefinedFunction"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricDistributionPoint_IFC2X3(string line) : base(line){}
    public IfcElectricDistributionPoint_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricFlowStorageDeviceType_IFC2X3 : IfcFlowStorageDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricFlowStorageDeviceType_IFC2X3(string line) : base(line){}
    public IfcElectricFlowStorageDeviceType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricGeneratorType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricGeneratorType_IFC2X3(string line) : base(line){}
    public IfcElectricGeneratorType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricHeaterType_IFC2X3 : IfcFlowTerminalType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricHeaterType_IFC2X3(string line) : base(line){}
    public IfcElectricHeaterType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricMotorType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricMotorType_IFC2X3(string line) : base(line){}
    public IfcElectricMotorType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricTimeControlType_IFC2X3 : IfcFlowControllerType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricTimeControlType_IFC2X3(string line) : base(line){}
    public IfcElectricTimeControlType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricalBaseProperties_IFC2X3 : IfcEnergyProperties_IFC2X3 {
    public string ElectricCurrentType;
    public string InputVoltage;
    public string InputFrequency;
    public string FullLoadCurrent;
    public string MinimumCircuitCurrent;
    public string MaximumPowerInput;
    public string RatedPowerInput;
    public string InputPhase;

    public new List<string> param_order = new List<string>{"ElectricCurrentType", "InputVoltage", "InputFrequency", "FullLoadCurrent", "MinimumCircuitCurrent", "MaximumPowerInput", "RatedPowerInput", "InputPhase"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricalBaseProperties_IFC2X3(string line) : base(line){}
    public IfcElectricalBaseProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricalCircuit_IFC2X3 : IfcSystem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricalCircuit_IFC2X3(string line) : base(line){}
    public IfcElectricalCircuit_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricalElement_IFC2X3 : IfcElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricalElement_IFC2X3(string line) : base(line){}
    public IfcElectricalElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElement_IFC2X3 : IfcProduct_IFC2X3 {
    public string Tag;

    public new List<string> param_order = new List<string>{"Tag"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElement_IFC2X3(string line) : base(line){}
    public IfcElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElementAssembly_IFC2X3 : IfcElement_IFC2X3 {
    public string AssemblyPlace;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"AssemblyPlace", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElementAssembly_IFC2X3(string line) : base(line){}
    public IfcElementAssembly_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElementComponent_IFC2X3 : IfcElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElementComponent_IFC2X3(string line) : base(line){}
    public IfcElementComponent_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElementComponentType_IFC2X3 : IfcElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElementComponentType_IFC2X3(string line) : base(line){}
    public IfcElementComponentType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElementQuantity_IFC2X3 : IfcPropertySetDefinition_IFC2X3 {
    public string MethodOfMeasurement;
    public List<IfcPhysicalQuantity_IFC2X3> Quantities;

    public new List<string> param_order = new List<string>{"MethodOfMeasurement", "Quantities"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElementQuantity_IFC2X3(string line) : base(line){}
    public IfcElementQuantity_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElementType_IFC2X3 : IfcTypeProduct_IFC2X3 {
    public string ElementType;

    public new List<string> param_order = new List<string>{"ElementType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElementType_IFC2X3(string line) : base(line){}
    public IfcElementType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcElementarySurface_IFC2X3 : IfcSurface_IFC2X3 {
    public IfcAxis2Placement3D_IFC2X3 Position;

    public new List<string> param_order = new List<string>{"Position"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElementarySurface_IFC2X3(string line) : base(line){}
    public IfcElementarySurface_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcEllipse_IFC2X3 : IfcConic_IFC2X3 {
    public string SemiAxis1;
    public string SemiAxis2;

    public new List<string> param_order = new List<string>{"SemiAxis1", "SemiAxis2"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEllipse_IFC2X3(string line) : base(line){}
    public IfcEllipse_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcEllipseProfileDef_IFC2X3 : IfcParameterizedProfileDef_IFC2X3 {
    public string SemiAxis1;
    public string SemiAxis2;

    public new List<string> param_order = new List<string>{"SemiAxis1", "SemiAxis2"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEllipseProfileDef_IFC2X3(string line) : base(line){}
    public IfcEllipseProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcEnergyConversionDevice_IFC2X3 : IfcDistributionFlowElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEnergyConversionDevice_IFC2X3(string line) : base(line){}
    public IfcEnergyConversionDevice_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcEnergyConversionDeviceType_IFC2X3 : IfcDistributionFlowElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEnergyConversionDeviceType_IFC2X3(string line) : base(line){}
    public IfcEnergyConversionDeviceType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcEnergyProperties_IFC2X3 : IfcPropertySetDefinition_IFC2X3 {
    public string EnergySequence;
    public string UserDefinedEnergySequence;

    public new List<string> param_order = new List<string>{"EnergySequence", "UserDefinedEnergySequence"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEnergyProperties_IFC2X3(string line) : base(line){}
    public IfcEnergyProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcEnvironmentalImpactValue_IFC2X3 : IfcAppliedValue_IFC2X3 {
    public string ImpactType;
    public string Category;
    public string UserDefinedCategory;

    public new List<string> param_order = new List<string>{"ImpactType", "Category", "UserDefinedCategory"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEnvironmentalImpactValue_IFC2X3(string line) : base(line){}
    public IfcEnvironmentalImpactValue_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcEquipmentElement_IFC2X3 : IfcElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEquipmentElement_IFC2X3(string line) : base(line){}
    public IfcEquipmentElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcEquipmentStandard_IFC2X3 : IfcControl_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEquipmentStandard_IFC2X3(string line) : base(line){}
    public IfcEquipmentStandard_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcEvaporativeCoolerType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEvaporativeCoolerType_IFC2X3(string line) : base(line){}
    public IfcEvaporativeCoolerType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcEvaporatorType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEvaporatorType_IFC2X3(string line) : base(line){}
    public IfcEvaporatorType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcExtendedMaterialProperties_IFC2X3 : IfcMaterialProperties_IFC2X3 {
    public List<IfcProperty_IFC2X3> ExtendedProperties;
    public string Description;
    public string Name;

    public new List<string> param_order = new List<string>{"ExtendedProperties", "Description", "Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExtendedMaterialProperties_IFC2X3(string line) : base(line){}
    public IfcExtendedMaterialProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcExternalReference_IFC2X3 : Entity {
    public string Location;
    public string ItemReference;
    public string Name;

    public new List<string> param_order = new List<string>{"Location", "ItemReference", "Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExternalReference_IFC2X3(string line) : base(line){}
    public IfcExternalReference_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcExternallyDefinedHatchStyle_IFC2X3 : IfcExternalReference_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExternallyDefinedHatchStyle_IFC2X3(string line) : base(line){}
    public IfcExternallyDefinedHatchStyle_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcExternallyDefinedSurfaceStyle_IFC2X3 : IfcExternalReference_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExternallyDefinedSurfaceStyle_IFC2X3(string line) : base(line){}
    public IfcExternallyDefinedSurfaceStyle_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcExternallyDefinedSymbol_IFC2X3 : IfcExternalReference_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExternallyDefinedSymbol_IFC2X3(string line) : base(line){}
    public IfcExternallyDefinedSymbol_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcExternallyDefinedTextFont_IFC2X3 : IfcExternalReference_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExternallyDefinedTextFont_IFC2X3(string line) : base(line){}
    public IfcExternallyDefinedTextFont_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcExtrudedAreaSolid_IFC2X3 : IfcSweptAreaSolid_IFC2X3 {
    public IfcDirection_IFC2X3 ExtrudedDirection;
    public string Depth;

    public new List<string> param_order = new List<string>{"ExtrudedDirection", "Depth"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExtrudedAreaSolid_IFC2X3(string line) : base(line){}
    public IfcExtrudedAreaSolid_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFace_IFC2X3 : IfcTopologicalRepresentationItem_IFC2X3 {
    public List<IfcFaceBound_IFC2X3> Bounds;

    public new List<string> param_order = new List<string>{"Bounds"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFace_IFC2X3(string line) : base(line){}
    public IfcFace_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFaceBasedSurfaceModel_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public List<IfcConnectedFaceSet_IFC2X3> FbsmFaces;

    public new List<string> param_order = new List<string>{"FbsmFaces"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFaceBasedSurfaceModel_IFC2X3(string line) : base(line){}
    public IfcFaceBasedSurfaceModel_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFaceBound_IFC2X3 : IfcTopologicalRepresentationItem_IFC2X3 {
    public IfcLoop_IFC2X3 Bound;
    public string Orientation;

    public new List<string> param_order = new List<string>{"Bound", "Orientation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFaceBound_IFC2X3(string line) : base(line){}
    public IfcFaceBound_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFaceOuterBound_IFC2X3 : IfcFaceBound_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFaceOuterBound_IFC2X3(string line) : base(line){}
    public IfcFaceOuterBound_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFaceSurface_IFC2X3 : IfcFace_IFC2X3 {
    public IfcSurface_IFC2X3 FaceSurface;
    public string SameSense;

    public new List<string> param_order = new List<string>{"FaceSurface", "SameSense"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFaceSurface_IFC2X3(string line) : base(line){}
    public IfcFaceSurface_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFacetedBrep_IFC2X3 : IfcManifoldSolidBrep_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFacetedBrep_IFC2X3(string line) : base(line){}
    public IfcFacetedBrep_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFacetedBrepWithVoids_IFC2X3 : IfcManifoldSolidBrep_IFC2X3 {
    public List<IfcClosedShell_IFC2X3> Voids;

    public new List<string> param_order = new List<string>{"Voids"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFacetedBrepWithVoids_IFC2X3(string line) : base(line){}
    public IfcFacetedBrepWithVoids_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFailureConnectionCondition_IFC2X3 : IfcStructuralConnectionCondition_IFC2X3 {
    public string TensionFailureX;
    public string TensionFailureY;
    public string TensionFailureZ;
    public string CompressionFailureX;
    public string CompressionFailureY;
    public string CompressionFailureZ;

    public new List<string> param_order = new List<string>{"TensionFailureX", "TensionFailureY", "TensionFailureZ", "CompressionFailureX", "CompressionFailureY", "CompressionFailureZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFailureConnectionCondition_IFC2X3(string line) : base(line){}
    public IfcFailureConnectionCondition_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFanType_IFC2X3 : IfcFlowMovingDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFanType_IFC2X3(string line) : base(line){}
    public IfcFanType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFastener_IFC2X3 : IfcElementComponent_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFastener_IFC2X3(string line) : base(line){}
    public IfcFastener_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFastenerType_IFC2X3 : IfcElementComponentType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFastenerType_IFC2X3(string line) : base(line){}
    public IfcFastenerType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFeatureElement_IFC2X3 : IfcElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFeatureElement_IFC2X3(string line) : base(line){}
    public IfcFeatureElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFeatureElementAddition_IFC2X3 : IfcFeatureElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFeatureElementAddition_IFC2X3(string line) : base(line){}
    public IfcFeatureElementAddition_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFeatureElementSubtraction_IFC2X3 : IfcFeatureElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFeatureElementSubtraction_IFC2X3(string line) : base(line){}
    public IfcFeatureElementSubtraction_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFillAreaStyle_IFC2X3 : IfcPresentationStyle_IFC2X3 {
    public List<IfcFillStyleSelect_IFC2X3> FillStyles;

    public new List<string> param_order = new List<string>{"FillStyles"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFillAreaStyle_IFC2X3(string line) : base(line){}
    public IfcFillAreaStyle_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFillAreaStyleHatching_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public IfcCurveStyle_IFC2X3 HatchLineAppearance;
    public IfcHatchLineDistanceSelect_IFC2X3 StartOfNextHatchLine;
    public IfcCartesianPoint_IFC2X3 PointOfReferenceHatchLine;
    public IfcCartesianPoint_IFC2X3 PatternStart;
    public string HatchLineAngle;

    public new List<string> param_order = new List<string>{"HatchLineAppearance", "StartOfNextHatchLine", "PointOfReferenceHatchLine", "PatternStart", "HatchLineAngle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFillAreaStyleHatching_IFC2X3(string line) : base(line){}
    public IfcFillAreaStyleHatching_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFillAreaStyleTileSymbolWithStyle_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public IfcAnnotationSymbolOccurrence_IFC2X3 Symbol;

    public new List<string> param_order = new List<string>{"Symbol"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFillAreaStyleTileSymbolWithStyle_IFC2X3(string line) : base(line){}
    public IfcFillAreaStyleTileSymbolWithStyle_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFillAreaStyleTiles_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public IfcOneDirectionRepeatFactor_IFC2X3 TilingPattern;
    public List<IfcFillAreaStyleTileShapeSelect_IFC2X3> Tiles;
    public string TilingScale;

    public new List<string> param_order = new List<string>{"TilingPattern", "Tiles", "TilingScale"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFillAreaStyleTiles_IFC2X3(string line) : base(line){}
    public IfcFillAreaStyleTiles_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFilterType_IFC2X3 : IfcFlowTreatmentDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFilterType_IFC2X3(string line) : base(line){}
    public IfcFilterType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFireSuppressionTerminalType_IFC2X3 : IfcFlowTerminalType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFireSuppressionTerminalType_IFC2X3(string line) : base(line){}
    public IfcFireSuppressionTerminalType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowController_IFC2X3 : IfcDistributionFlowElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowController_IFC2X3(string line) : base(line){}
    public IfcFlowController_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowControllerType_IFC2X3 : IfcDistributionFlowElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowControllerType_IFC2X3(string line) : base(line){}
    public IfcFlowControllerType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowFitting_IFC2X3 : IfcDistributionFlowElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowFitting_IFC2X3(string line) : base(line){}
    public IfcFlowFitting_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowFittingType_IFC2X3 : IfcDistributionFlowElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowFittingType_IFC2X3(string line) : base(line){}
    public IfcFlowFittingType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowInstrumentType_IFC2X3 : IfcDistributionControlElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowInstrumentType_IFC2X3(string line) : base(line){}
    public IfcFlowInstrumentType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowMeterType_IFC2X3 : IfcFlowControllerType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowMeterType_IFC2X3(string line) : base(line){}
    public IfcFlowMeterType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowMovingDevice_IFC2X3 : IfcDistributionFlowElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowMovingDevice_IFC2X3(string line) : base(line){}
    public IfcFlowMovingDevice_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowMovingDeviceType_IFC2X3 : IfcDistributionFlowElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowMovingDeviceType_IFC2X3(string line) : base(line){}
    public IfcFlowMovingDeviceType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowSegment_IFC2X3 : IfcDistributionFlowElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowSegment_IFC2X3(string line) : base(line){}
    public IfcFlowSegment_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowSegmentType_IFC2X3 : IfcDistributionFlowElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowSegmentType_IFC2X3(string line) : base(line){}
    public IfcFlowSegmentType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowStorageDevice_IFC2X3 : IfcDistributionFlowElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowStorageDevice_IFC2X3(string line) : base(line){}
    public IfcFlowStorageDevice_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowStorageDeviceType_IFC2X3 : IfcDistributionFlowElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowStorageDeviceType_IFC2X3(string line) : base(line){}
    public IfcFlowStorageDeviceType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowTerminal_IFC2X3 : IfcDistributionFlowElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowTerminal_IFC2X3(string line) : base(line){}
    public IfcFlowTerminal_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowTerminalType_IFC2X3 : IfcDistributionFlowElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowTerminalType_IFC2X3(string line) : base(line){}
    public IfcFlowTerminalType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowTreatmentDevice_IFC2X3 : IfcDistributionFlowElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowTreatmentDevice_IFC2X3(string line) : base(line){}
    public IfcFlowTreatmentDevice_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowTreatmentDeviceType_IFC2X3 : IfcDistributionFlowElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowTreatmentDeviceType_IFC2X3(string line) : base(line){}
    public IfcFlowTreatmentDeviceType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFluidFlowProperties_IFC2X3 : IfcPropertySetDefinition_IFC2X3 {
    public string PropertySource;
    public IfcTimeSeries_IFC2X3 FlowConditionTimeSeries;
    public IfcTimeSeries_IFC2X3 VelocityTimeSeries;
    public IfcTimeSeries_IFC2X3 FlowrateTimeSeries;
    public IfcMaterial_IFC2X3 Fluid;
    public IfcTimeSeries_IFC2X3 PressureTimeSeries;
    public string UserDefinedPropertySource;
    public string TemperatureSingleValue;
    public string WetBulbTemperatureSingleValue;
    public IfcTimeSeries_IFC2X3 WetBulbTemperatureTimeSeries;
    public IfcTimeSeries_IFC2X3 TemperatureTimeSeries;
    public IfcDerivedMeasureValue_IFC2X3 FlowrateSingleValue;
    public string FlowConditionSingleValue;
    public string VelocitySingleValue;
    public string PressureSingleValue;

    public new List<string> param_order = new List<string>{"PropertySource", "FlowConditionTimeSeries", "VelocityTimeSeries", "FlowrateTimeSeries", "Fluid", "PressureTimeSeries", "UserDefinedPropertySource", "TemperatureSingleValue", "WetBulbTemperatureSingleValue", "WetBulbTemperatureTimeSeries", "TemperatureTimeSeries", "FlowrateSingleValue", "FlowConditionSingleValue", "VelocitySingleValue", "PressureSingleValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFluidFlowProperties_IFC2X3(string line) : base(line){}
    public IfcFluidFlowProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFooting_IFC2X3 : IfcBuildingElement_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFooting_IFC2X3(string line) : base(line){}
    public IfcFooting_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFuelProperties_IFC2X3 : IfcMaterialProperties_IFC2X3 {
    public string CombustionTemperature;
    public string CarbonContent;
    public string LowerHeatingValue;
    public string HigherHeatingValue;

    public new List<string> param_order = new List<string>{"CombustionTemperature", "CarbonContent", "LowerHeatingValue", "HigherHeatingValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFuelProperties_IFC2X3(string line) : base(line){}
    public IfcFuelProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFurnishingElement_IFC2X3 : IfcElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFurnishingElement_IFC2X3(string line) : base(line){}
    public IfcFurnishingElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFurnishingElementType_IFC2X3 : IfcElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFurnishingElementType_IFC2X3(string line) : base(line){}
    public IfcFurnishingElementType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFurnitureStandard_IFC2X3 : IfcControl_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFurnitureStandard_IFC2X3(string line) : base(line){}
    public IfcFurnitureStandard_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcFurnitureType_IFC2X3 : IfcFurnishingElementType_IFC2X3 {
    public string AssemblyPlace;

    public new List<string> param_order = new List<string>{"AssemblyPlace"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFurnitureType_IFC2X3(string line) : base(line){}
    public IfcFurnitureType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcGasTerminalType_IFC2X3 : IfcFlowTerminalType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGasTerminalType_IFC2X3(string line) : base(line){}
    public IfcGasTerminalType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcGeneralMaterialProperties_IFC2X3 : IfcMaterialProperties_IFC2X3 {
    public string MolecularWeight;
    public string Porosity;
    public string MassDensity;

    public new List<string> param_order = new List<string>{"MolecularWeight", "Porosity", "MassDensity"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGeneralMaterialProperties_IFC2X3(string line) : base(line){}
    public IfcGeneralMaterialProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcGeneralProfileProperties_IFC2X3 : IfcProfileProperties_IFC2X3 {
    public string PhysicalWeight;
    public string Perimeter;
    public string MinimumPlateThickness;
    public string MaximumPlateThickness;
    public string CrossSectionArea;

    public new List<string> param_order = new List<string>{"PhysicalWeight", "Perimeter", "MinimumPlateThickness", "MaximumPlateThickness", "CrossSectionArea"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGeneralProfileProperties_IFC2X3(string line) : base(line){}
    public IfcGeneralProfileProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcGeometricCurveSet_IFC2X3 : IfcGeometricSet_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGeometricCurveSet_IFC2X3(string line) : base(line){}
    public IfcGeometricCurveSet_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcGeometricRepresentationContext_IFC2X3 : IfcRepresentationContext_IFC2X3 {
    public string CoordinateSpaceDimension;
    public string Precision;
    public IfcAxis2Placement_IFC2X3 WorldCoordinateSystem;
    public IfcDirection_IFC2X3 TrueNorth;

    public new List<string> param_order = new List<string>{"CoordinateSpaceDimension", "Precision", "WorldCoordinateSystem", "TrueNorth"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGeometricRepresentationContext_IFC2X3(string line) : base(line){}
    public IfcGeometricRepresentationContext_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcGeometricRepresentationItem_IFC2X3 : IfcRepresentationItem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGeometricRepresentationItem_IFC2X3(string line) : base(line){}
    public IfcGeometricRepresentationItem_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcGeometricRepresentationSubContext_IFC2X3 : IfcGeometricRepresentationContext_IFC2X3 {
    public IfcGeometricRepresentationContext_IFC2X3 ParentContext;
    public string TargetScale;
    public string TargetView;
    public string UserDefinedTargetView;

    public new List<string> param_order = new List<string>{"ParentContext", "TargetScale", "TargetView", "UserDefinedTargetView"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGeometricRepresentationSubContext_IFC2X3(string line) : base(line){}
    public IfcGeometricRepresentationSubContext_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcGeometricSet_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public List<IfcGeometricSetSelect_IFC2X3> Elements;

    public new List<string> param_order = new List<string>{"Elements"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGeometricSet_IFC2X3(string line) : base(line){}
    public IfcGeometricSet_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcGrid_IFC2X3 : IfcProduct_IFC2X3 {
    public List<IfcGridAxis_IFC2X3> UAxes;
    public List<IfcGridAxis_IFC2X3> VAxes;
    public List<IfcGridAxis_IFC2X3> WAxes;

    public new List<string> param_order = new List<string>{"UAxes", "VAxes", "WAxes"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGrid_IFC2X3(string line) : base(line){}
    public IfcGrid_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcGridAxis_IFC2X3 : Entity {
    public string AxisTag;
    public IfcCurve_IFC2X3 AxisCurve;
    public string SameSense;

    public new List<string> param_order = new List<string>{"AxisTag", "AxisCurve", "SameSense"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGridAxis_IFC2X3(string line) : base(line){}
    public IfcGridAxis_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcGridPlacement_IFC2X3 : IfcObjectPlacement_IFC2X3 {
    public IfcVirtualGridIntersection_IFC2X3 PlacementLocation;
    public IfcVirtualGridIntersection_IFC2X3 PlacementRefDirection;

    public new List<string> param_order = new List<string>{"PlacementLocation", "PlacementRefDirection"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGridPlacement_IFC2X3(string line) : base(line){}
    public IfcGridPlacement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcGroup_IFC2X3 : IfcObject_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGroup_IFC2X3(string line) : base(line){}
    public IfcGroup_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcHalfSpaceSolid_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public IfcSurface_IFC2X3 BaseSurface;
    public string AgreementFlag;

    public new List<string> param_order = new List<string>{"BaseSurface", "AgreementFlag"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcHalfSpaceSolid_IFC2X3(string line) : base(line){}
    public IfcHalfSpaceSolid_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcHeatExchangerType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcHeatExchangerType_IFC2X3(string line) : base(line){}
    public IfcHeatExchangerType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcHumidifierType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcHumidifierType_IFC2X3(string line) : base(line){}
    public IfcHumidifierType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcHygroscopicMaterialProperties_IFC2X3 : IfcMaterialProperties_IFC2X3 {
    public string UpperVaporResistanceFactor;
    public string LowerVaporResistanceFactor;
    public string IsothermalMoistureCapacity;
    public string VaporPermeability;
    public string MoistureDiffusivity;

    public new List<string> param_order = new List<string>{"UpperVaporResistanceFactor", "LowerVaporResistanceFactor", "IsothermalMoistureCapacity", "VaporPermeability", "MoistureDiffusivity"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcHygroscopicMaterialProperties_IFC2X3(string line) : base(line){}
    public IfcHygroscopicMaterialProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcIShapeProfileDef_IFC2X3 : IfcParameterizedProfileDef_IFC2X3 {
    public string OverallWidth;
    public string OverallDepth;
    public string WebThickness;
    public string FlangeThickness;
    public string FilletRadius;

    public new List<string> param_order = new List<string>{"OverallWidth", "OverallDepth", "WebThickness", "FlangeThickness", "FilletRadius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcIShapeProfileDef_IFC2X3(string line) : base(line){}
    public IfcIShapeProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcImageTexture_IFC2X3 : IfcSurfaceTexture_IFC2X3 {
    public string UrlReference;

    public new List<string> param_order = new List<string>{"UrlReference"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcImageTexture_IFC2X3(string line) : base(line){}
    public IfcImageTexture_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcInventory_IFC2X3 : IfcGroup_IFC2X3 {
    public string InventoryType;
    public IfcActorSelect_IFC2X3 Jurisdiction;
    public List<IfcPerson_IFC2X3> ResponsiblePersons;
    public IfcCalendarDate_IFC2X3 LastUpdateDate;
    public IfcCostValue_IFC2X3 CurrentValue;
    public IfcCostValue_IFC2X3 OriginalValue;

    public new List<string> param_order = new List<string>{"InventoryType", "Jurisdiction", "ResponsiblePersons", "LastUpdateDate", "CurrentValue", "OriginalValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcInventory_IFC2X3(string line) : base(line){}
    public IfcInventory_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcIrregularTimeSeries_IFC2X3 : IfcTimeSeries_IFC2X3 {
    public List<IfcIrregularTimeSeriesValue_IFC2X3> Values;

    public new List<string> param_order = new List<string>{"Values"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcIrregularTimeSeries_IFC2X3(string line) : base(line){}
    public IfcIrregularTimeSeries_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcIrregularTimeSeriesValue_IFC2X3 : Entity {
    public IfcDateTimeSelect_IFC2X3 TimeStamp;
    public List<IfcValue_IFC2X3> ListValues;

    public new List<string> param_order = new List<string>{"TimeStamp", "ListValues"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcIrregularTimeSeriesValue_IFC2X3(string line) : base(line){}
    public IfcIrregularTimeSeriesValue_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcJunctionBoxType_IFC2X3 : IfcFlowFittingType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcJunctionBoxType_IFC2X3(string line) : base(line){}
    public IfcJunctionBoxType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLShapeProfileDef_IFC2X3 : IfcParameterizedProfileDef_IFC2X3 {
    public string Depth;
    public string Width;
    public string Thickness;
    public string FilletRadius;
    public string EdgeRadius;
    public string LegSlope;
    public string CentreOfGravityInX;
    public string CentreOfGravityInY;

    public new List<string> param_order = new List<string>{"Depth", "Width", "Thickness", "FilletRadius", "EdgeRadius", "LegSlope", "CentreOfGravityInX", "CentreOfGravityInY"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLShapeProfileDef_IFC2X3(string line) : base(line){}
    public IfcLShapeProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLaborResource_IFC2X3 : IfcConstructionResource_IFC2X3 {
    public string SkillSet;

    public new List<string> param_order = new List<string>{"SkillSet"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLaborResource_IFC2X3(string line) : base(line){}
    public IfcLaborResource_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLampType_IFC2X3 : IfcFlowTerminalType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLampType_IFC2X3(string line) : base(line){}
    public IfcLampType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLibraryInformation_IFC2X3 : Entity {
    public string Name;
    public string Version;
    public IfcOrganization_IFC2X3 Publisher;
    public IfcCalendarDate_IFC2X3 VersionDate;
    public List<IfcLibraryReference_IFC2X3> LibraryReference;

    public new List<string> param_order = new List<string>{"Name", "Version", "Publisher", "VersionDate", "LibraryReference"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLibraryInformation_IFC2X3(string line) : base(line){}
    public IfcLibraryInformation_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLibraryReference_IFC2X3 : IfcExternalReference_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLibraryReference_IFC2X3(string line) : base(line){}
    public IfcLibraryReference_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLightDistributionData_IFC2X3 : Entity {
    public string MainPlaneAngle;
    public List<string> SecondaryPlaneAngle;
    public List<string> LuminousIntensity;

    public new List<string> param_order = new List<string>{"MainPlaneAngle", "SecondaryPlaneAngle", "LuminousIntensity"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightDistributionData_IFC2X3(string line) : base(line){}
    public IfcLightDistributionData_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLightFixtureType_IFC2X3 : IfcFlowTerminalType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightFixtureType_IFC2X3(string line) : base(line){}
    public IfcLightFixtureType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLightIntensityDistribution_IFC2X3 : Entity {
    public string LightDistributionCurve;
    public List<IfcLightDistributionData_IFC2X3> DistributionData;

    public new List<string> param_order = new List<string>{"LightDistributionCurve", "DistributionData"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightIntensityDistribution_IFC2X3(string line) : base(line){}
    public IfcLightIntensityDistribution_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLightSource_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public string Name;
    public IfcColourRgb_IFC2X3 LightColour;
    public string AmbientIntensity;
    public string Intensity;

    public new List<string> param_order = new List<string>{"Name", "LightColour", "AmbientIntensity", "Intensity"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightSource_IFC2X3(string line) : base(line){}
    public IfcLightSource_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLightSourceAmbient_IFC2X3 : IfcLightSource_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightSourceAmbient_IFC2X3(string line) : base(line){}
    public IfcLightSourceAmbient_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLightSourceDirectional_IFC2X3 : IfcLightSource_IFC2X3 {
    public IfcDirection_IFC2X3 Orientation;

    public new List<string> param_order = new List<string>{"Orientation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightSourceDirectional_IFC2X3(string line) : base(line){}
    public IfcLightSourceDirectional_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLightSourceGoniometric_IFC2X3 : IfcLightSource_IFC2X3 {
    public IfcAxis2Placement3D_IFC2X3 Position;
    public IfcColourRgb_IFC2X3 ColourAppearance;
    public string ColourTemperature;
    public string LuminousFlux;
    public string LightEmissionSource;
    public IfcLightDistributionDataSourceSelect_IFC2X3 LightDistributionDataSource;

    public new List<string> param_order = new List<string>{"Position", "ColourAppearance", "ColourTemperature", "LuminousFlux", "LightEmissionSource", "LightDistributionDataSource"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightSourceGoniometric_IFC2X3(string line) : base(line){}
    public IfcLightSourceGoniometric_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLightSourcePositional_IFC2X3 : IfcLightSource_IFC2X3 {
    public IfcCartesianPoint_IFC2X3 Position;
    public string Radius;
    public string ConstantAttenuation;
    public string DistanceAttenuation;
    public string QuadricAttenuation;

    public new List<string> param_order = new List<string>{"Position", "Radius", "ConstantAttenuation", "DistanceAttenuation", "QuadricAttenuation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightSourcePositional_IFC2X3(string line) : base(line){}
    public IfcLightSourcePositional_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLightSourceSpot_IFC2X3 : IfcLightSourcePositional_IFC2X3 {
    public IfcDirection_IFC2X3 Orientation;
    public string ConcentrationExponent;
    public string SpreadAngle;
    public string BeamWidthAngle;

    public new List<string> param_order = new List<string>{"Orientation", "ConcentrationExponent", "SpreadAngle", "BeamWidthAngle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightSourceSpot_IFC2X3(string line) : base(line){}
    public IfcLightSourceSpot_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLine_IFC2X3 : IfcCurve_IFC2X3 {
    public IfcCartesianPoint_IFC2X3 Pnt;
    public IfcVector_IFC2X3 Dir;

    public new List<string> param_order = new List<string>{"Pnt", "Dir"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLine_IFC2X3(string line) : base(line){}
    public IfcLine_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLinearDimension_IFC2X3 : IfcDimensionCurveDirectedCallout_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLinearDimension_IFC2X3(string line) : base(line){}
    public IfcLinearDimension_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLocalPlacement_IFC2X3 : IfcObjectPlacement_IFC2X3 {
    public IfcObjectPlacement_IFC2X3 PlacementRelTo;
    public IfcAxis2Placement_IFC2X3 RelativePlacement;

    public new List<string> param_order = new List<string>{"PlacementRelTo", "RelativePlacement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLocalPlacement_IFC2X3(string line) : base(line){}
    public IfcLocalPlacement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLocalTime_IFC2X3 : Entity {
    public string HourComponent;
    public string MinuteComponent;
    public string SecondComponent;
    public IfcCoordinatedUniversalTimeOffset_IFC2X3 Zone;
    public string DaylightSavingOffset;

    public new List<string> param_order = new List<string>{"HourComponent", "MinuteComponent", "SecondComponent", "Zone", "DaylightSavingOffset"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLocalTime_IFC2X3(string line) : base(line){}
    public IfcLocalTime_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcLoop_IFC2X3 : IfcTopologicalRepresentationItem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLoop_IFC2X3(string line) : base(line){}
    public IfcLoop_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcManifoldSolidBrep_IFC2X3 : IfcSolidModel_IFC2X3 {
    public IfcClosedShell_IFC2X3 Outer;

    public new List<string> param_order = new List<string>{"Outer"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcManifoldSolidBrep_IFC2X3(string line) : base(line){}
    public IfcManifoldSolidBrep_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMappedItem_IFC2X3 : IfcRepresentationItem_IFC2X3 {
    public IfcRepresentationMap_IFC2X3 MappingSource;
    public IfcCartesianTransformationOperator_IFC2X3 MappingTarget;

    public new List<string> param_order = new List<string>{"MappingSource", "MappingTarget"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMappedItem_IFC2X3(string line) : base(line){}
    public IfcMappedItem_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterial_IFC2X3 : Entity {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterial_IFC2X3(string line) : base(line){}
    public IfcMaterial_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialClassificationRelationship_IFC2X3 : Entity {
    public List<IfcClassificationNotationSelect_IFC2X3> MaterialClassifications;
    public IfcMaterial_IFC2X3 ClassifiedMaterial;

    public new List<string> param_order = new List<string>{"MaterialClassifications", "ClassifiedMaterial"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialClassificationRelationship_IFC2X3(string line) : base(line){}
    public IfcMaterialClassificationRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialDefinitionRepresentation_IFC2X3 : IfcProductRepresentation_IFC2X3 {
    public IfcMaterial_IFC2X3 RepresentedMaterial;

    public new List<string> param_order = new List<string>{"RepresentedMaterial"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialDefinitionRepresentation_IFC2X3(string line) : base(line){}
    public IfcMaterialDefinitionRepresentation_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialLayer_IFC2X3 : Entity {
    public IfcMaterial_IFC2X3 Material;
    public string LayerThickness;
    public string IsVentilated;

    public new List<string> param_order = new List<string>{"Material", "LayerThickness", "IsVentilated"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialLayer_IFC2X3(string line) : base(line){}
    public IfcMaterialLayer_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialLayerSet_IFC2X3 : Entity {
    public List<IfcMaterialLayer_IFC2X3> MaterialLayers;
    public string LayerSetName;

    public new List<string> param_order = new List<string>{"MaterialLayers", "LayerSetName"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialLayerSet_IFC2X3(string line) : base(line){}
    public IfcMaterialLayerSet_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialLayerSetUsage_IFC2X3 : Entity {
    public IfcMaterialLayerSet_IFC2X3 ForLayerSet;
    public string LayerSetDirection;
    public string DirectionSense;
    public string OffsetFromReferenceLine;

    public new List<string> param_order = new List<string>{"ForLayerSet", "LayerSetDirection", "DirectionSense", "OffsetFromReferenceLine"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialLayerSetUsage_IFC2X3(string line) : base(line){}
    public IfcMaterialLayerSetUsage_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialList_IFC2X3 : Entity {
    public List<IfcMaterial_IFC2X3> Materials;

    public new List<string> param_order = new List<string>{"Materials"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialList_IFC2X3(string line) : base(line){}
    public IfcMaterialList_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialProperties_IFC2X3 : Entity {
    public IfcMaterial_IFC2X3 Material;

    public new List<string> param_order = new List<string>{"Material"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialProperties_IFC2X3(string line) : base(line){}
    public IfcMaterialProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMeasureWithUnit_IFC2X3 : Entity {
    public IfcValue_IFC2X3 ValueComponent;
    public IfcUnit_IFC2X3 UnitComponent;

    public new List<string> param_order = new List<string>{"ValueComponent", "UnitComponent"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMeasureWithUnit_IFC2X3(string line) : base(line){}
    public IfcMeasureWithUnit_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMechanicalConcreteMaterialProperties_IFC2X3 : IfcMechanicalMaterialProperties_IFC2X3 {
    public string CompressiveStrength;
    public string MaxAggregateSize;
    public string AdmixturesDescription;
    public string Workability;
    public string ProtectivePoreRatio;
    public string WaterImpermeability;

    public new List<string> param_order = new List<string>{"CompressiveStrength", "MaxAggregateSize", "AdmixturesDescription", "Workability", "ProtectivePoreRatio", "WaterImpermeability"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMechanicalConcreteMaterialProperties_IFC2X3(string line) : base(line){}
    public IfcMechanicalConcreteMaterialProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMechanicalFastener_IFC2X3 : IfcFastener_IFC2X3 {
    public string NominalDiameter;
    public string NominalLength;

    public new List<string> param_order = new List<string>{"NominalDiameter", "NominalLength"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMechanicalFastener_IFC2X3(string line) : base(line){}
    public IfcMechanicalFastener_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMechanicalFastenerType_IFC2X3 : IfcFastenerType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMechanicalFastenerType_IFC2X3(string line) : base(line){}
    public IfcMechanicalFastenerType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMechanicalMaterialProperties_IFC2X3 : IfcMaterialProperties_IFC2X3 {
    public string DynamicViscosity;
    public string YoungModulus;
    public string ShearModulus;
    public string PoissonRatio;
    public string ThermalExpansionCoefficient;

    public new List<string> param_order = new List<string>{"DynamicViscosity", "YoungModulus", "ShearModulus", "PoissonRatio", "ThermalExpansionCoefficient"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMechanicalMaterialProperties_IFC2X3(string line) : base(line){}
    public IfcMechanicalMaterialProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMechanicalSteelMaterialProperties_IFC2X3 : IfcMechanicalMaterialProperties_IFC2X3 {
    public string YieldStress;
    public string UltimateStress;
    public string UltimateStrain;
    public string HardeningModule;
    public string ProportionalStress;
    public string PlasticStrain;
    public List<IfcRelaxation_IFC2X3> Relaxations;

    public new List<string> param_order = new List<string>{"YieldStress", "UltimateStress", "UltimateStrain", "HardeningModule", "ProportionalStress", "PlasticStrain", "Relaxations"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMechanicalSteelMaterialProperties_IFC2X3(string line) : base(line){}
    public IfcMechanicalSteelMaterialProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMember_IFC2X3 : IfcBuildingElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMember_IFC2X3(string line) : base(line){}
    public IfcMember_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMemberType_IFC2X3 : IfcBuildingElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMemberType_IFC2X3(string line) : base(line){}
    public IfcMemberType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMetric_IFC2X3 : IfcConstraint_IFC2X3 {
    public string Benchmark;
    public string ValueSource;
    public IfcMetricValueSelect_IFC2X3 DataValue;

    public new List<string> param_order = new List<string>{"Benchmark", "ValueSource", "DataValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMetric_IFC2X3(string line) : base(line){}
    public IfcMetric_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMonetaryUnit_IFC2X3 : Entity {
    public string Currency;

    public new List<string> param_order = new List<string>{"Currency"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMonetaryUnit_IFC2X3(string line) : base(line){}
    public IfcMonetaryUnit_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMotorConnectionType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMotorConnectionType_IFC2X3(string line) : base(line){}
    public IfcMotorConnectionType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcMove_IFC2X3 : IfcTask_IFC2X3 {
    public IfcSpatialStructureElement_IFC2X3 MoveFrom;
    public IfcSpatialStructureElement_IFC2X3 MoveTo;
    public List<string> PunchList;

    public new List<string> param_order = new List<string>{"MoveFrom", "MoveTo", "PunchList"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMove_IFC2X3(string line) : base(line){}
    public IfcMove_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcNamedUnit_IFC2X3 : Entity {
    public IfcDimensionalExponents_IFC2X3 Dimensions;
    public string UnitType;

    public new List<string> param_order = new List<string>{"Dimensions", "UnitType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcNamedUnit_IFC2X3(string line) : base(line){}
    public IfcNamedUnit_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcObject_IFC2X3 : IfcObjectDefinition_IFC2X3 {
    public string ObjectType;

    public new List<string> param_order = new List<string>{"ObjectType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcObject_IFC2X3(string line) : base(line){}
    public IfcObject_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcObjectDefinition_IFC2X3 : IfcRoot_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcObjectDefinition_IFC2X3(string line) : base(line){}
    public IfcObjectDefinition_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcObjectPlacement_IFC2X3 : Entity {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcObjectPlacement_IFC2X3(string line) : base(line){}
    public IfcObjectPlacement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcObjective_IFC2X3 : IfcConstraint_IFC2X3 {
    public IfcMetric_IFC2X3 BenchmarkValues;
    public IfcMetric_IFC2X3 ResultValues;
    public string ObjectiveQualifier;
    public string UserDefinedQualifier;

    public new List<string> param_order = new List<string>{"BenchmarkValues", "ResultValues", "ObjectiveQualifier", "UserDefinedQualifier"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcObjective_IFC2X3(string line) : base(line){}
    public IfcObjective_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcOccupant_IFC2X3 : IfcActor_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOccupant_IFC2X3(string line) : base(line){}
    public IfcOccupant_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcOffsetCurve2D_IFC2X3 : IfcCurve_IFC2X3 {
    public IfcCurve_IFC2X3 BasisCurve;
    public string Distance;
    public string SelfIntersect;

    public new List<string> param_order = new List<string>{"BasisCurve", "Distance", "SelfIntersect"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOffsetCurve2D_IFC2X3(string line) : base(line){}
    public IfcOffsetCurve2D_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcOffsetCurve3D_IFC2X3 : IfcCurve_IFC2X3 {
    public IfcCurve_IFC2X3 BasisCurve;
    public string Distance;
    public string SelfIntersect;
    public IfcDirection_IFC2X3 RefDirection;

    public new List<string> param_order = new List<string>{"BasisCurve", "Distance", "SelfIntersect", "RefDirection"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOffsetCurve3D_IFC2X3(string line) : base(line){}
    public IfcOffsetCurve3D_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcOneDirectionRepeatFactor_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public IfcVector_IFC2X3 RepeatFactor;

    public new List<string> param_order = new List<string>{"RepeatFactor"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOneDirectionRepeatFactor_IFC2X3(string line) : base(line){}
    public IfcOneDirectionRepeatFactor_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcOpenShell_IFC2X3 : IfcConnectedFaceSet_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOpenShell_IFC2X3(string line) : base(line){}
    public IfcOpenShell_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcOpeningElement_IFC2X3 : IfcFeatureElementSubtraction_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOpeningElement_IFC2X3(string line) : base(line){}
    public IfcOpeningElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcOpticalMaterialProperties_IFC2X3 : IfcMaterialProperties_IFC2X3 {
    public string VisibleTransmittance;
    public string SolarTransmittance;
    public string ThermalIrTransmittance;
    public string ThermalIrEmissivityBack;
    public string ThermalIrEmissivityFront;
    public string VisibleReflectanceBack;
    public string VisibleReflectanceFront;
    public string SolarReflectanceFront;
    public string SolarReflectanceBack;

    public new List<string> param_order = new List<string>{"VisibleTransmittance", "SolarTransmittance", "ThermalIrTransmittance", "ThermalIrEmissivityBack", "ThermalIrEmissivityFront", "VisibleReflectanceBack", "VisibleReflectanceFront", "SolarReflectanceFront", "SolarReflectanceBack"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOpticalMaterialProperties_IFC2X3(string line) : base(line){}
    public IfcOpticalMaterialProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcOrderAction_IFC2X3 : IfcTask_IFC2X3 {
    public string ActionID;

    public new List<string> param_order = new List<string>{"ActionID"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOrderAction_IFC2X3(string line) : base(line){}
    public IfcOrderAction_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcOrganization_IFC2X3 : Entity {
    public string Id;
    public string Name;
    public string Description;
    public List<IfcActorRole_IFC2X3> Roles;
    public List<IfcAddress_IFC2X3> Addresses;

    public new List<string> param_order = new List<string>{"Id", "Name", "Description", "Roles", "Addresses"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOrganization_IFC2X3(string line) : base(line){}
    public IfcOrganization_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcOrganizationRelationship_IFC2X3 : Entity {
    public string Name;
    public string Description;
    public IfcOrganization_IFC2X3 RelatingOrganization;
    public List<IfcOrganization_IFC2X3> RelatedOrganizations;

    public new List<string> param_order = new List<string>{"Name", "Description", "RelatingOrganization", "RelatedOrganizations"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOrganizationRelationship_IFC2X3(string line) : base(line){}
    public IfcOrganizationRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcOrientedEdge_IFC2X3 : IfcEdge_IFC2X3 {
    public IfcEdge_IFC2X3 EdgeElement;
    public string Orientation;

    public new List<string> param_order = new List<string>{"EdgeElement", "Orientation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOrientedEdge_IFC2X3(string line) : base(line){}
    public IfcOrientedEdge_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcOutletType_IFC2X3 : IfcFlowTerminalType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOutletType_IFC2X3(string line) : base(line){}
    public IfcOutletType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcOwnerHistory_IFC2X3 : Entity {
    public IfcPersonAndOrganization_IFC2X3 OwningUser;
    public IfcApplication_IFC2X3 OwningApplication;
    public string State;
    public string ChangeAction;
    public string LastModifiedDate;
    public IfcPersonAndOrganization_IFC2X3 LastModifyingUser;
    public IfcApplication_IFC2X3 LastModifyingApplication;
    public string CreationDate;

    public new List<string> param_order = new List<string>{"OwningUser", "OwningApplication", "State", "ChangeAction", "LastModifiedDate", "LastModifyingUser", "LastModifyingApplication", "CreationDate"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOwnerHistory_IFC2X3(string line) : base(line){}
    public IfcOwnerHistory_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcParameterizedProfileDef_IFC2X3 : IfcProfileDef_IFC2X3 {
    public IfcAxis2Placement2D_IFC2X3 Position;

    public new List<string> param_order = new List<string>{"Position"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcParameterizedProfileDef_IFC2X3(string line) : base(line){}
    public IfcParameterizedProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPath_IFC2X3 : IfcTopologicalRepresentationItem_IFC2X3 {
    public List<IfcOrientedEdge_IFC2X3> EdgeList;

    public new List<string> param_order = new List<string>{"EdgeList"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPath_IFC2X3(string line) : base(line){}
    public IfcPath_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPerformanceHistory_IFC2X3 : IfcControl_IFC2X3 {
    public string LifeCyclePhase;

    public new List<string> param_order = new List<string>{"LifeCyclePhase"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPerformanceHistory_IFC2X3(string line) : base(line){}
    public IfcPerformanceHistory_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPermeableCoveringProperties_IFC2X3 : IfcPropertySetDefinition_IFC2X3 {
    public string OperationType;
    public string PanelPosition;
    public string FrameDepth;
    public string FrameThickness;
    public IfcShapeAspect_IFC2X3 ShapeAspectStyle;

    public new List<string> param_order = new List<string>{"OperationType", "PanelPosition", "FrameDepth", "FrameThickness", "ShapeAspectStyle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPermeableCoveringProperties_IFC2X3(string line) : base(line){}
    public IfcPermeableCoveringProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPermit_IFC2X3 : IfcControl_IFC2X3 {
    public string PermitID;

    public new List<string> param_order = new List<string>{"PermitID"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPermit_IFC2X3(string line) : base(line){}
    public IfcPermit_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPerson_IFC2X3 : Entity {
    public string Id;
    public string FamilyName;
    public string GivenName;
    public List<string> MiddleNames;
    public List<string> PrefixTitles;
    public List<string> SuffixTitles;
    public List<IfcActorRole_IFC2X3> Roles;
    public List<IfcAddress_IFC2X3> Addresses;

    public new List<string> param_order = new List<string>{"Id", "FamilyName", "GivenName", "MiddleNames", "PrefixTitles", "SuffixTitles", "Roles", "Addresses"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPerson_IFC2X3(string line) : base(line){}
    public IfcPerson_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPersonAndOrganization_IFC2X3 : Entity {
    public IfcPerson_IFC2X3 ThePerson;
    public IfcOrganization_IFC2X3 TheOrganization;
    public List<IfcActorRole_IFC2X3> Roles;

    public new List<string> param_order = new List<string>{"ThePerson", "TheOrganization", "Roles"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPersonAndOrganization_IFC2X3(string line) : base(line){}
    public IfcPersonAndOrganization_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPhysicalComplexQuantity_IFC2X3 : IfcPhysicalQuantity_IFC2X3 {
    public List<IfcPhysicalQuantity_IFC2X3> HasQuantities;
    public string Discrimination;
    public string Quality;
    public string Usage;

    public new List<string> param_order = new List<string>{"HasQuantities", "Discrimination", "Quality", "Usage"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPhysicalComplexQuantity_IFC2X3(string line) : base(line){}
    public IfcPhysicalComplexQuantity_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPhysicalQuantity_IFC2X3 : Entity {
    public string Name;
    public string Description;

    public new List<string> param_order = new List<string>{"Name", "Description"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPhysicalQuantity_IFC2X3(string line) : base(line){}
    public IfcPhysicalQuantity_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPhysicalSimpleQuantity_IFC2X3 : IfcPhysicalQuantity_IFC2X3 {
    public IfcNamedUnit_IFC2X3 Unit;

    public new List<string> param_order = new List<string>{"Unit"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPhysicalSimpleQuantity_IFC2X3(string line) : base(line){}
    public IfcPhysicalSimpleQuantity_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPile_IFC2X3 : IfcBuildingElement_IFC2X3 {
    public string PredefinedType;
    public string ConstructionType;

    public new List<string> param_order = new List<string>{"PredefinedType", "ConstructionType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPile_IFC2X3(string line) : base(line){}
    public IfcPile_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPipeFittingType_IFC2X3 : IfcFlowFittingType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPipeFittingType_IFC2X3(string line) : base(line){}
    public IfcPipeFittingType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPipeSegmentType_IFC2X3 : IfcFlowSegmentType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPipeSegmentType_IFC2X3(string line) : base(line){}
    public IfcPipeSegmentType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPixelTexture_IFC2X3 : IfcSurfaceTexture_IFC2X3 {
    public string Width;
    public string Height;
    public string ColourComponents;
    public List<string> Pixel;

    public new List<string> param_order = new List<string>{"Width", "Height", "ColourComponents", "Pixel"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPixelTexture_IFC2X3(string line) : base(line){}
    public IfcPixelTexture_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPlacement_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public IfcCartesianPoint_IFC2X3 Location;

    public new List<string> param_order = new List<string>{"Location"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPlacement_IFC2X3(string line) : base(line){}
    public IfcPlacement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPlanarBox_IFC2X3 : IfcPlanarExtent_IFC2X3 {
    public IfcAxis2Placement_IFC2X3 Placement;

    public new List<string> param_order = new List<string>{"Placement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPlanarBox_IFC2X3(string line) : base(line){}
    public IfcPlanarBox_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPlanarExtent_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public string SizeInX;
    public string SizeInY;

    public new List<string> param_order = new List<string>{"SizeInX", "SizeInY"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPlanarExtent_IFC2X3(string line) : base(line){}
    public IfcPlanarExtent_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPlane_IFC2X3 : IfcElementarySurface_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPlane_IFC2X3(string line) : base(line){}
    public IfcPlane_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPlate_IFC2X3 : IfcBuildingElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPlate_IFC2X3(string line) : base(line){}
    public IfcPlate_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPlateType_IFC2X3 : IfcBuildingElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPlateType_IFC2X3(string line) : base(line){}
    public IfcPlateType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPoint_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPoint_IFC2X3(string line) : base(line){}
    public IfcPoint_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPointOnCurve_IFC2X3 : IfcPoint_IFC2X3 {
    public IfcCurve_IFC2X3 BasisCurve;
    public string PointParameter;

    public new List<string> param_order = new List<string>{"BasisCurve", "PointParameter"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPointOnCurve_IFC2X3(string line) : base(line){}
    public IfcPointOnCurve_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPointOnSurface_IFC2X3 : IfcPoint_IFC2X3 {
    public IfcSurface_IFC2X3 BasisSurface;
    public string PointParameterU;
    public string PointParameterV;

    public new List<string> param_order = new List<string>{"BasisSurface", "PointParameterU", "PointParameterV"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPointOnSurface_IFC2X3(string line) : base(line){}
    public IfcPointOnSurface_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPolyLoop_IFC2X3 : IfcLoop_IFC2X3 {
    public List<IfcCartesianPoint_IFC2X3> Polygon;

    public new List<string> param_order = new List<string>{"Polygon"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPolyLoop_IFC2X3(string line) : base(line){}
    public IfcPolyLoop_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPolygonalBoundedHalfSpace_IFC2X3 : IfcHalfSpaceSolid_IFC2X3 {
    public IfcAxis2Placement3D_IFC2X3 Position;
    public IfcBoundedCurve_IFC2X3 PolygonalBoundary;

    public new List<string> param_order = new List<string>{"Position", "PolygonalBoundary"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPolygonalBoundedHalfSpace_IFC2X3(string line) : base(line){}
    public IfcPolygonalBoundedHalfSpace_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPolyline_IFC2X3 : IfcBoundedCurve_IFC2X3 {
    public List<IfcCartesianPoint_IFC2X3> Points;

    public new List<string> param_order = new List<string>{"Points"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPolyline_IFC2X3(string line) : base(line){}
    public IfcPolyline_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPort_IFC2X3 : IfcProduct_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPort_IFC2X3(string line) : base(line){}
    public IfcPort_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPostalAddress_IFC2X3 : IfcAddress_IFC2X3 {
    public string InternalLocation;
    public List<string> AddressLines;
    public string PostalBox;
    public string Town;
    public string Region;
    public string PostalCode;
    public string Country;

    public new List<string> param_order = new List<string>{"InternalLocation", "AddressLines", "PostalBox", "Town", "Region", "PostalCode", "Country"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPostalAddress_IFC2X3(string line) : base(line){}
    public IfcPostalAddress_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPreDefinedColour_IFC2X3 : IfcPreDefinedItem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPreDefinedColour_IFC2X3(string line) : base(line){}
    public IfcPreDefinedColour_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPreDefinedCurveFont_IFC2X3 : IfcPreDefinedItem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPreDefinedCurveFont_IFC2X3(string line) : base(line){}
    public IfcPreDefinedCurveFont_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPreDefinedDimensionSymbol_IFC2X3 : IfcPreDefinedSymbol_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPreDefinedDimensionSymbol_IFC2X3(string line) : base(line){}
    public IfcPreDefinedDimensionSymbol_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPreDefinedItem_IFC2X3 : Entity {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPreDefinedItem_IFC2X3(string line) : base(line){}
    public IfcPreDefinedItem_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPreDefinedPointMarkerSymbol_IFC2X3 : IfcPreDefinedSymbol_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPreDefinedPointMarkerSymbol_IFC2X3(string line) : base(line){}
    public IfcPreDefinedPointMarkerSymbol_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPreDefinedSymbol_IFC2X3 : IfcPreDefinedItem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPreDefinedSymbol_IFC2X3(string line) : base(line){}
    public IfcPreDefinedSymbol_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPreDefinedTerminatorSymbol_IFC2X3 : IfcPreDefinedSymbol_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPreDefinedTerminatorSymbol_IFC2X3(string line) : base(line){}
    public IfcPreDefinedTerminatorSymbol_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPreDefinedTextFont_IFC2X3 : IfcPreDefinedItem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPreDefinedTextFont_IFC2X3(string line) : base(line){}
    public IfcPreDefinedTextFont_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPresentationLayerAssignment_IFC2X3 : Entity {
    public string Name;
    public string Description;
    public List<IfcLayeredItem_IFC2X3> AssignedItems;
    public string Identifier;

    public new List<string> param_order = new List<string>{"Name", "Description", "AssignedItems", "Identifier"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPresentationLayerAssignment_IFC2X3(string line) : base(line){}
    public IfcPresentationLayerAssignment_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPresentationLayerWithStyle_IFC2X3 : IfcPresentationLayerAssignment_IFC2X3 {
    public string LayerOn;
    public string LayerFrozen;
    public string LayerBlocked;
    public List<IfcPresentationStyleSelect_IFC2X3> LayerStyles;

    public new List<string> param_order = new List<string>{"LayerOn", "LayerFrozen", "LayerBlocked", "LayerStyles"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPresentationLayerWithStyle_IFC2X3(string line) : base(line){}
    public IfcPresentationLayerWithStyle_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPresentationStyle_IFC2X3 : Entity {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPresentationStyle_IFC2X3(string line) : base(line){}
    public IfcPresentationStyle_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPresentationStyleAssignment_IFC2X3 : Entity {
    public List<IfcPresentationStyleSelect_IFC2X3> Styles;

    public new List<string> param_order = new List<string>{"Styles"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPresentationStyleAssignment_IFC2X3(string line) : base(line){}
    public IfcPresentationStyleAssignment_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProcedure_IFC2X3 : IfcProcess_IFC2X3 {
    public string ProcedureID;
    public string ProcedureType;
    public string UserDefinedProcedureType;

    public new List<string> param_order = new List<string>{"ProcedureID", "ProcedureType", "UserDefinedProcedureType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProcedure_IFC2X3(string line) : base(line){}
    public IfcProcedure_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProcess_IFC2X3 : IfcObject_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProcess_IFC2X3(string line) : base(line){}
    public IfcProcess_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProduct_IFC2X3 : IfcObject_IFC2X3 {
    public IfcObjectPlacement_IFC2X3 ObjectPlacement;
    public IfcProductRepresentation_IFC2X3 Representation;

    public new List<string> param_order = new List<string>{"ObjectPlacement", "Representation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProduct_IFC2X3(string line) : base(line){}
    public IfcProduct_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProductDefinitionShape_IFC2X3 : IfcProductRepresentation_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProductDefinitionShape_IFC2X3(string line) : base(line){}
    public IfcProductDefinitionShape_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProductRepresentation_IFC2X3 : Entity {
    public string Name;
    public string Description;
    public List<IfcRepresentation_IFC2X3> Representations;

    public new List<string> param_order = new List<string>{"Name", "Description", "Representations"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProductRepresentation_IFC2X3(string line) : base(line){}
    public IfcProductRepresentation_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProductsOfCombustionProperties_IFC2X3 : IfcMaterialProperties_IFC2X3 {
    public string SpecificHeatCapacity;
    public string N20Content;
    public string COContent;
    public string CO2Content;

    public new List<string> param_order = new List<string>{"SpecificHeatCapacity", "N20Content", "COContent", "CO2Content"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProductsOfCombustionProperties_IFC2X3(string line) : base(line){}
    public IfcProductsOfCombustionProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProfileDef_IFC2X3 : Entity {
    public string ProfileType;
    public string ProfileName;

    public new List<string> param_order = new List<string>{"ProfileType", "ProfileName"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProfileDef_IFC2X3(string line) : base(line){}
    public IfcProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProfileProperties_IFC2X3 : Entity {
    public string ProfileName;
    public IfcProfileDef_IFC2X3 ProfileDefinition;

    public new List<string> param_order = new List<string>{"ProfileName", "ProfileDefinition"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProfileProperties_IFC2X3(string line) : base(line){}
    public IfcProfileProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProject_IFC2X3 : IfcObject_IFC2X3 {
    public string LongName;
    public string Phase;
    public List<IfcRepresentationContext_IFC2X3> RepresentationContexts;
    public IfcUnitAssignment_IFC2X3 UnitsInContext;

    public new List<string> param_order = new List<string>{"LongName", "Phase", "RepresentationContexts", "UnitsInContext"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProject_IFC2X3(string line) : base(line){}
    public IfcProject_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProjectOrder_IFC2X3 : IfcControl_IFC2X3 {
    public string ID;
    public string PredefinedType;
    public string Status;

    public new List<string> param_order = new List<string>{"ID", "PredefinedType", "Status"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProjectOrder_IFC2X3(string line) : base(line){}
    public IfcProjectOrder_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProjectOrderRecord_IFC2X3 : IfcControl_IFC2X3 {
    public List<IfcRelAssignsToProjectOrder_IFC2X3> Records;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"Records", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProjectOrderRecord_IFC2X3(string line) : base(line){}
    public IfcProjectOrderRecord_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProjectionCurve_IFC2X3 : IfcAnnotationCurveOccurrence_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProjectionCurve_IFC2X3(string line) : base(line){}
    public IfcProjectionCurve_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProjectionElement_IFC2X3 : IfcFeatureElementAddition_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProjectionElement_IFC2X3(string line) : base(line){}
    public IfcProjectionElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProperty_IFC2X3 : Entity {
    public string Name;
    public string Description;

    public new List<string> param_order = new List<string>{"Name", "Description"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProperty_IFC2X3(string line) : base(line){}
    public IfcProperty_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyBoundedValue_IFC2X3 : IfcSimpleProperty_IFC2X3 {
    public IfcValue_IFC2X3 UpperBoundValue;
    public IfcValue_IFC2X3 LowerBoundValue;
    public IfcUnit_IFC2X3 Unit;

    public new List<string> param_order = new List<string>{"UpperBoundValue", "LowerBoundValue", "Unit"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyBoundedValue_IFC2X3(string line) : base(line){}
    public IfcPropertyBoundedValue_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyConstraintRelationship_IFC2X3 : Entity {
    public IfcConstraint_IFC2X3 RelatingConstraint;
    public List<IfcProperty_IFC2X3> RelatedProperties;
    public string Name;
    public string Description;

    public new List<string> param_order = new List<string>{"RelatingConstraint", "RelatedProperties", "Name", "Description"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyConstraintRelationship_IFC2X3(string line) : base(line){}
    public IfcPropertyConstraintRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyDefinition_IFC2X3 : IfcRoot_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyDefinition_IFC2X3(string line) : base(line){}
    public IfcPropertyDefinition_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyDependencyRelationship_IFC2X3 : Entity {
    public IfcProperty_IFC2X3 DependingProperty;
    public IfcProperty_IFC2X3 DependantProperty;
    public string Name;
    public string Description;
    public string Expression;

    public new List<string> param_order = new List<string>{"DependingProperty", "DependantProperty", "Name", "Description", "Expression"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyDependencyRelationship_IFC2X3(string line) : base(line){}
    public IfcPropertyDependencyRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyEnumeratedValue_IFC2X3 : IfcSimpleProperty_IFC2X3 {
    public List<IfcValue_IFC2X3> EnumerationValues;
    public IfcPropertyEnumeration_IFC2X3 EnumerationReference;

    public new List<string> param_order = new List<string>{"EnumerationValues", "EnumerationReference"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyEnumeratedValue_IFC2X3(string line) : base(line){}
    public IfcPropertyEnumeratedValue_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyEnumeration_IFC2X3 : Entity {
    public string Name;
    public List<IfcValue_IFC2X3> EnumerationValues;
    public IfcUnit_IFC2X3 Unit;

    public new List<string> param_order = new List<string>{"Name", "EnumerationValues", "Unit"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyEnumeration_IFC2X3(string line) : base(line){}
    public IfcPropertyEnumeration_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyListValue_IFC2X3 : IfcSimpleProperty_IFC2X3 {
    public List<IfcValue_IFC2X3> ListValues;
    public IfcUnit_IFC2X3 Unit;

    public new List<string> param_order = new List<string>{"ListValues", "Unit"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyListValue_IFC2X3(string line) : base(line){}
    public IfcPropertyListValue_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyReferenceValue_IFC2X3 : IfcSimpleProperty_IFC2X3 {
    public string UsageName;
    public IfcObjectReferenceSelect_IFC2X3 PropertyReference;

    public new List<string> param_order = new List<string>{"UsageName", "PropertyReference"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyReferenceValue_IFC2X3(string line) : base(line){}
    public IfcPropertyReferenceValue_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertySet_IFC2X3 : IfcPropertySetDefinition_IFC2X3 {
    public List<IfcProperty_IFC2X3> HasProperties;

    public new List<string> param_order = new List<string>{"HasProperties"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertySet_IFC2X3(string line) : base(line){}
    public IfcPropertySet_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertySetDefinition_IFC2X3 : IfcPropertyDefinition_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertySetDefinition_IFC2X3(string line) : base(line){}
    public IfcPropertySetDefinition_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertySingleValue_IFC2X3 : IfcSimpleProperty_IFC2X3 {
    public IfcValue_IFC2X3 NominalValue;
    public IfcUnit_IFC2X3 Unit;

    public new List<string> param_order = new List<string>{"NominalValue", "Unit"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertySingleValue_IFC2X3(string line) : base(line){}
    public IfcPropertySingleValue_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyTableValue_IFC2X3 : IfcSimpleProperty_IFC2X3 {
    public List<IfcValue_IFC2X3> DefiningValues;
    public List<IfcValue_IFC2X3> DefinedValues;
    public string Expression;
    public IfcUnit_IFC2X3 DefiningUnit;
    public IfcUnit_IFC2X3 DefinedUnit;

    public new List<string> param_order = new List<string>{"DefiningValues", "DefinedValues", "Expression", "DefiningUnit", "DefinedUnit"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyTableValue_IFC2X3(string line) : base(line){}
    public IfcPropertyTableValue_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProtectiveDeviceType_IFC2X3 : IfcFlowControllerType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProtectiveDeviceType_IFC2X3(string line) : base(line){}
    public IfcProtectiveDeviceType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcProxy_IFC2X3 : IfcProduct_IFC2X3 {
    public string ProxyType;
    public string Tag;

    public new List<string> param_order = new List<string>{"ProxyType", "Tag"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProxy_IFC2X3(string line) : base(line){}
    public IfcProxy_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcPumpType_IFC2X3 : IfcFlowMovingDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPumpType_IFC2X3(string line) : base(line){}
    public IfcPumpType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcQuantityArea_IFC2X3 : IfcPhysicalSimpleQuantity_IFC2X3 {
    public string AreaValue;

    public new List<string> param_order = new List<string>{"AreaValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcQuantityArea_IFC2X3(string line) : base(line){}
    public IfcQuantityArea_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcQuantityCount_IFC2X3 : IfcPhysicalSimpleQuantity_IFC2X3 {
    public string CountValue;

    public new List<string> param_order = new List<string>{"CountValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcQuantityCount_IFC2X3(string line) : base(line){}
    public IfcQuantityCount_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcQuantityLength_IFC2X3 : IfcPhysicalSimpleQuantity_IFC2X3 {
    public string LengthValue;

    public new List<string> param_order = new List<string>{"LengthValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcQuantityLength_IFC2X3(string line) : base(line){}
    public IfcQuantityLength_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcQuantityTime_IFC2X3 : IfcPhysicalSimpleQuantity_IFC2X3 {
    public string TimeValue;

    public new List<string> param_order = new List<string>{"TimeValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcQuantityTime_IFC2X3(string line) : base(line){}
    public IfcQuantityTime_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcQuantityVolume_IFC2X3 : IfcPhysicalSimpleQuantity_IFC2X3 {
    public string VolumeValue;

    public new List<string> param_order = new List<string>{"VolumeValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcQuantityVolume_IFC2X3(string line) : base(line){}
    public IfcQuantityVolume_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcQuantityWeight_IFC2X3 : IfcPhysicalSimpleQuantity_IFC2X3 {
    public string WeightValue;

    public new List<string> param_order = new List<string>{"WeightValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcQuantityWeight_IFC2X3(string line) : base(line){}
    public IfcQuantityWeight_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRadiusDimension_IFC2X3 : IfcDimensionCurveDirectedCallout_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRadiusDimension_IFC2X3(string line) : base(line){}
    public IfcRadiusDimension_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRailing_IFC2X3 : IfcBuildingElement_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRailing_IFC2X3(string line) : base(line){}
    public IfcRailing_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRailingType_IFC2X3 : IfcBuildingElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRailingType_IFC2X3(string line) : base(line){}
    public IfcRailingType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRamp_IFC2X3 : IfcBuildingElement_IFC2X3 {
    public string ShapeType;

    public new List<string> param_order = new List<string>{"ShapeType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRamp_IFC2X3(string line) : base(line){}
    public IfcRamp_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRampFlight_IFC2X3 : IfcBuildingElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRampFlight_IFC2X3(string line) : base(line){}
    public IfcRampFlight_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRampFlightType_IFC2X3 : IfcBuildingElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRampFlightType_IFC2X3(string line) : base(line){}
    public IfcRampFlightType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRationalBezierCurve_IFC2X3 : IfcBezierCurve_IFC2X3 {
    public List<string> WeightsData;

    public new List<string> param_order = new List<string>{"WeightsData"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRationalBezierCurve_IFC2X3(string line) : base(line){}
    public IfcRationalBezierCurve_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRectangleHollowProfileDef_IFC2X3 : IfcRectangleProfileDef_IFC2X3 {
    public string WallThickness;
    public string InnerFilletRadius;
    public string OuterFilletRadius;

    public new List<string> param_order = new List<string>{"WallThickness", "InnerFilletRadius", "OuterFilletRadius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRectangleHollowProfileDef_IFC2X3(string line) : base(line){}
    public IfcRectangleHollowProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRectangleProfileDef_IFC2X3 : IfcParameterizedProfileDef_IFC2X3 {
    public string XDim;
    public string YDim;

    public new List<string> param_order = new List<string>{"XDim", "YDim"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRectangleProfileDef_IFC2X3(string line) : base(line){}
    public IfcRectangleProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRectangularPyramid_IFC2X3 : IfcCsgPrimitive3D_IFC2X3 {
    public string XLength;
    public string YLength;
    public string Height;

    public new List<string> param_order = new List<string>{"XLength", "YLength", "Height"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRectangularPyramid_IFC2X3(string line) : base(line){}
    public IfcRectangularPyramid_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRectangularTrimmedSurface_IFC2X3 : IfcBoundedSurface_IFC2X3 {
    public IfcSurface_IFC2X3 BasisSurface;
    public string U1;
    public string V1;
    public string U2;
    public string V2;
    public string Usense;
    public string Vsense;

    public new List<string> param_order = new List<string>{"BasisSurface", "U1", "V1", "U2", "V2", "Usense", "Vsense"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRectangularTrimmedSurface_IFC2X3(string line) : base(line){}
    public IfcRectangularTrimmedSurface_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcReferencesValueDocument_IFC2X3 : Entity {
    public IfcDocumentSelect_IFC2X3 ReferencedDocument;
    public List<IfcAppliedValue_IFC2X3> ReferencingValues;
    public string Name;
    public string Description;

    public new List<string> param_order = new List<string>{"ReferencedDocument", "ReferencingValues", "Name", "Description"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReferencesValueDocument_IFC2X3(string line) : base(line){}
    public IfcReferencesValueDocument_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRegularTimeSeries_IFC2X3 : IfcTimeSeries_IFC2X3 {
    public string TimeStep;
    public List<IfcTimeSeriesValue_IFC2X3> Values;

    public new List<string> param_order = new List<string>{"TimeStep", "Values"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRegularTimeSeries_IFC2X3(string line) : base(line){}
    public IfcRegularTimeSeries_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcReinforcementBarProperties_IFC2X3 : Entity {
    public string TotalCrossSectionArea;
    public string SteelGrade;
    public string BarSurface;
    public string EffectiveDepth;
    public string NominalBarDiameter;
    public string BarCount;

    public new List<string> param_order = new List<string>{"TotalCrossSectionArea", "SteelGrade", "BarSurface", "EffectiveDepth", "NominalBarDiameter", "BarCount"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReinforcementBarProperties_IFC2X3(string line) : base(line){}
    public IfcReinforcementBarProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcReinforcementDefinitionProperties_IFC2X3 : IfcPropertySetDefinition_IFC2X3 {
    public string DefinitionType;
    public List<IfcSectionReinforcementProperties_IFC2X3> ReinforcementSectionDefinitions;

    public new List<string> param_order = new List<string>{"DefinitionType", "ReinforcementSectionDefinitions"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReinforcementDefinitionProperties_IFC2X3(string line) : base(line){}
    public IfcReinforcementDefinitionProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcReinforcingBar_IFC2X3 : IfcReinforcingElement_IFC2X3 {
    public string NominalDiameter;
    public string CrossSectionArea;
    public string BarLength;
    public string BarRole;
    public string BarSurface;

    public new List<string> param_order = new List<string>{"NominalDiameter", "CrossSectionArea", "BarLength", "BarRole", "BarSurface"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReinforcingBar_IFC2X3(string line) : base(line){}
    public IfcReinforcingBar_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcReinforcingElement_IFC2X3 : IfcBuildingElementComponent_IFC2X3 {
    public string SteelGrade;

    public new List<string> param_order = new List<string>{"SteelGrade"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReinforcingElement_IFC2X3(string line) : base(line){}
    public IfcReinforcingElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcReinforcingMesh_IFC2X3 : IfcReinforcingElement_IFC2X3 {
    public string MeshLength;
    public string MeshWidth;
    public string LongitudinalBarNominalDiameter;
    public string TransverseBarNominalDiameter;
    public string LongitudinalBarCrossSectionArea;
    public string TransverseBarCrossSectionArea;
    public string LongitudinalBarSpacing;
    public string TransverseBarSpacing;

    public new List<string> param_order = new List<string>{"MeshLength", "MeshWidth", "LongitudinalBarNominalDiameter", "TransverseBarNominalDiameter", "LongitudinalBarCrossSectionArea", "TransverseBarCrossSectionArea", "LongitudinalBarSpacing", "TransverseBarSpacing"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReinforcingMesh_IFC2X3(string line) : base(line){}
    public IfcReinforcingMesh_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAggregates_IFC2X3 : IfcRelDecomposes_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAggregates_IFC2X3(string line) : base(line){}
    public IfcRelAggregates_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssigns_IFC2X3 : IfcRelationship_IFC2X3 {
    public List<IfcObjectDefinition_IFC2X3> RelatedObjects;
    public string RelatedObjectsType;

    public new List<string> param_order = new List<string>{"RelatedObjects", "RelatedObjectsType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssigns_IFC2X3(string line) : base(line){}
    public IfcRelAssigns_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsTasks_IFC2X3 : IfcRelAssignsToControl_IFC2X3 {
    public IfcScheduleTimeControl_IFC2X3 TimeForTask;

    public new List<string> param_order = new List<string>{"TimeForTask"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsTasks_IFC2X3(string line) : base(line){}
    public IfcRelAssignsTasks_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsToActor_IFC2X3 : IfcRelAssigns_IFC2X3 {
    public IfcActor_IFC2X3 RelatingActor;
    public IfcActorRole_IFC2X3 ActingRole;

    public new List<string> param_order = new List<string>{"RelatingActor", "ActingRole"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsToActor_IFC2X3(string line) : base(line){}
    public IfcRelAssignsToActor_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsToControl_IFC2X3 : IfcRelAssigns_IFC2X3 {
    public IfcControl_IFC2X3 RelatingControl;

    public new List<string> param_order = new List<string>{"RelatingControl"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsToControl_IFC2X3(string line) : base(line){}
    public IfcRelAssignsToControl_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsToGroup_IFC2X3 : IfcRelAssigns_IFC2X3 {
    public IfcGroup_IFC2X3 RelatingGroup;

    public new List<string> param_order = new List<string>{"RelatingGroup"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsToGroup_IFC2X3(string line) : base(line){}
    public IfcRelAssignsToGroup_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsToProcess_IFC2X3 : IfcRelAssigns_IFC2X3 {
    public IfcProcess_IFC2X3 RelatingProcess;
    public IfcMeasureWithUnit_IFC2X3 QuantityInProcess;

    public new List<string> param_order = new List<string>{"RelatingProcess", "QuantityInProcess"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsToProcess_IFC2X3(string line) : base(line){}
    public IfcRelAssignsToProcess_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsToProduct_IFC2X3 : IfcRelAssigns_IFC2X3 {
    public IfcProduct_IFC2X3 RelatingProduct;

    public new List<string> param_order = new List<string>{"RelatingProduct"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsToProduct_IFC2X3(string line) : base(line){}
    public IfcRelAssignsToProduct_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsToProjectOrder_IFC2X3 : IfcRelAssignsToControl_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsToProjectOrder_IFC2X3(string line) : base(line){}
    public IfcRelAssignsToProjectOrder_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsToResource_IFC2X3 : IfcRelAssigns_IFC2X3 {
    public IfcResource_IFC2X3 RelatingResource;

    public new List<string> param_order = new List<string>{"RelatingResource"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsToResource_IFC2X3(string line) : base(line){}
    public IfcRelAssignsToResource_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociates_IFC2X3 : IfcRelationship_IFC2X3 {
    public List<IfcRoot_IFC2X3> RelatedObjects;

    public new List<string> param_order = new List<string>{"RelatedObjects"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociates_IFC2X3(string line) : base(line){}
    public IfcRelAssociates_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociatesAppliedValue_IFC2X3 : IfcRelAssociates_IFC2X3 {
    public IfcAppliedValue_IFC2X3 RelatingAppliedValue;

    public new List<string> param_order = new List<string>{"RelatingAppliedValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociatesAppliedValue_IFC2X3(string line) : base(line){}
    public IfcRelAssociatesAppliedValue_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociatesApproval_IFC2X3 : IfcRelAssociates_IFC2X3 {
    public IfcApproval_IFC2X3 RelatingApproval;

    public new List<string> param_order = new List<string>{"RelatingApproval"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociatesApproval_IFC2X3(string line) : base(line){}
    public IfcRelAssociatesApproval_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociatesClassification_IFC2X3 : IfcRelAssociates_IFC2X3 {
    public IfcClassificationNotationSelect_IFC2X3 RelatingClassification;

    public new List<string> param_order = new List<string>{"RelatingClassification"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociatesClassification_IFC2X3(string line) : base(line){}
    public IfcRelAssociatesClassification_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociatesConstraint_IFC2X3 : IfcRelAssociates_IFC2X3 {
    public string Intent;
    public IfcConstraint_IFC2X3 RelatingConstraint;

    public new List<string> param_order = new List<string>{"Intent", "RelatingConstraint"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociatesConstraint_IFC2X3(string line) : base(line){}
    public IfcRelAssociatesConstraint_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociatesDocument_IFC2X3 : IfcRelAssociates_IFC2X3 {
    public IfcDocumentSelect_IFC2X3 RelatingDocument;

    public new List<string> param_order = new List<string>{"RelatingDocument"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociatesDocument_IFC2X3(string line) : base(line){}
    public IfcRelAssociatesDocument_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociatesLibrary_IFC2X3 : IfcRelAssociates_IFC2X3 {
    public IfcLibrarySelect_IFC2X3 RelatingLibrary;

    public new List<string> param_order = new List<string>{"RelatingLibrary"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociatesLibrary_IFC2X3(string line) : base(line){}
    public IfcRelAssociatesLibrary_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociatesMaterial_IFC2X3 : IfcRelAssociates_IFC2X3 {
    public IfcMaterialSelect_IFC2X3 RelatingMaterial;

    public new List<string> param_order = new List<string>{"RelatingMaterial"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociatesMaterial_IFC2X3(string line) : base(line){}
    public IfcRelAssociatesMaterial_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociatesProfileProperties_IFC2X3 : IfcRelAssociates_IFC2X3 {
    public IfcProfileProperties_IFC2X3 RelatingProfileProperties;
    public IfcShapeAspect_IFC2X3 ProfileSectionLocation;
    public IfcOrientationSelect_IFC2X3 ProfileOrientation;

    public new List<string> param_order = new List<string>{"RelatingProfileProperties", "ProfileSectionLocation", "ProfileOrientation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociatesProfileProperties_IFC2X3(string line) : base(line){}
    public IfcRelAssociatesProfileProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnects_IFC2X3 : IfcRelationship_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnects_IFC2X3(string line) : base(line){}
    public IfcRelConnects_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsElements_IFC2X3 : IfcRelConnects_IFC2X3 {
    public IfcConnectionGeometry_IFC2X3 ConnectionGeometry;
    public IfcElement_IFC2X3 RelatingElement;
    public IfcElement_IFC2X3 RelatedElement;

    public new List<string> param_order = new List<string>{"ConnectionGeometry", "RelatingElement", "RelatedElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsElements_IFC2X3(string line) : base(line){}
    public IfcRelConnectsElements_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsPathElements_IFC2X3 : IfcRelConnectsElements_IFC2X3 {
    public List<string> RelatingPriorities;
    public List<string> RelatedPriorities;
    public string RelatedConnectionType;
    public string RelatingConnectionType;

    public new List<string> param_order = new List<string>{"RelatingPriorities", "RelatedPriorities", "RelatedConnectionType", "RelatingConnectionType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsPathElements_IFC2X3(string line) : base(line){}
    public IfcRelConnectsPathElements_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsPortToElement_IFC2X3 : IfcRelConnects_IFC2X3 {
    public IfcPort_IFC2X3 RelatingPort;
    public IfcElement_IFC2X3 RelatedElement;

    public new List<string> param_order = new List<string>{"RelatingPort", "RelatedElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsPortToElement_IFC2X3(string line) : base(line){}
    public IfcRelConnectsPortToElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsPorts_IFC2X3 : IfcRelConnects_IFC2X3 {
    public IfcPort_IFC2X3 RelatingPort;
    public IfcPort_IFC2X3 RelatedPort;
    public IfcElement_IFC2X3 RealizingElement;

    public new List<string> param_order = new List<string>{"RelatingPort", "RelatedPort", "RealizingElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsPorts_IFC2X3(string line) : base(line){}
    public IfcRelConnectsPorts_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsStructuralActivity_IFC2X3 : IfcRelConnects_IFC2X3 {
    public IfcStructuralActivityAssignmentSelect_IFC2X3 RelatingElement;
    public IfcStructuralActivity_IFC2X3 RelatedStructuralActivity;

    public new List<string> param_order = new List<string>{"RelatingElement", "RelatedStructuralActivity"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsStructuralActivity_IFC2X3(string line) : base(line){}
    public IfcRelConnectsStructuralActivity_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsStructuralElement_IFC2X3 : IfcRelConnects_IFC2X3 {
    public IfcElement_IFC2X3 RelatingElement;
    public IfcStructuralMember_IFC2X3 RelatedStructuralMember;

    public new List<string> param_order = new List<string>{"RelatingElement", "RelatedStructuralMember"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsStructuralElement_IFC2X3(string line) : base(line){}
    public IfcRelConnectsStructuralElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsStructuralMember_IFC2X3 : IfcRelConnects_IFC2X3 {
    public IfcStructuralMember_IFC2X3 RelatingStructuralMember;
    public IfcStructuralConnection_IFC2X3 RelatedStructuralConnection;
    public IfcBoundaryCondition_IFC2X3 AppliedCondition;
    public IfcStructuralConnectionCondition_IFC2X3 AdditionalConditions;
    public string SupportedLength;
    public IfcAxis2Placement3D_IFC2X3 ConditionCoordinateSystem;

    public new List<string> param_order = new List<string>{"RelatingStructuralMember", "RelatedStructuralConnection", "AppliedCondition", "AdditionalConditions", "SupportedLength", "ConditionCoordinateSystem"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsStructuralMember_IFC2X3(string line) : base(line){}
    public IfcRelConnectsStructuralMember_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsWithEccentricity_IFC2X3 : IfcRelConnectsStructuralMember_IFC2X3 {
    public IfcConnectionGeometry_IFC2X3 ConnectionConstraint;

    public new List<string> param_order = new List<string>{"ConnectionConstraint"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsWithEccentricity_IFC2X3(string line) : base(line){}
    public IfcRelConnectsWithEccentricity_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsWithRealizingElements_IFC2X3 : IfcRelConnectsElements_IFC2X3 {
    public List<IfcElement_IFC2X3> RealizingElements;
    public string ConnectionType;

    public new List<string> param_order = new List<string>{"RealizingElements", "ConnectionType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsWithRealizingElements_IFC2X3(string line) : base(line){}
    public IfcRelConnectsWithRealizingElements_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelContainedInSpatialStructure_IFC2X3 : IfcRelConnects_IFC2X3 {
    public List<IfcProduct_IFC2X3> RelatedElements;
    public IfcSpatialStructureElement_IFC2X3 RelatingStructure;

    public new List<string> param_order = new List<string>{"RelatedElements", "RelatingStructure"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelContainedInSpatialStructure_IFC2X3(string line) : base(line){}
    public IfcRelContainedInSpatialStructure_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelCoversBldgElements_IFC2X3 : IfcRelConnects_IFC2X3 {
    public IfcElement_IFC2X3 RelatingBuildingElement;
    public List<IfcCovering_IFC2X3> RelatedCoverings;

    public new List<string> param_order = new List<string>{"RelatingBuildingElement", "RelatedCoverings"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelCoversBldgElements_IFC2X3(string line) : base(line){}
    public IfcRelCoversBldgElements_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelCoversSpaces_IFC2X3 : IfcRelConnects_IFC2X3 {
    public IfcSpace_IFC2X3 RelatedSpace;
    public List<IfcCovering_IFC2X3> RelatedCoverings;

    public new List<string> param_order = new List<string>{"RelatedSpace", "RelatedCoverings"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelCoversSpaces_IFC2X3(string line) : base(line){}
    public IfcRelCoversSpaces_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelDecomposes_IFC2X3 : IfcRelationship_IFC2X3 {
    public IfcObjectDefinition_IFC2X3 RelatingObject;
    public List<IfcObjectDefinition_IFC2X3> RelatedObjects;

    public new List<string> param_order = new List<string>{"RelatingObject", "RelatedObjects"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelDecomposes_IFC2X3(string line) : base(line){}
    public IfcRelDecomposes_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelDefines_IFC2X3 : IfcRelationship_IFC2X3 {
    public List<IfcObject_IFC2X3> RelatedObjects;

    public new List<string> param_order = new List<string>{"RelatedObjects"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelDefines_IFC2X3(string line) : base(line){}
    public IfcRelDefines_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelDefinesByProperties_IFC2X3 : IfcRelDefines_IFC2X3 {
    public IfcPropertySetDefinition_IFC2X3 RelatingPropertyDefinition;

    public new List<string> param_order = new List<string>{"RelatingPropertyDefinition"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelDefinesByProperties_IFC2X3(string line) : base(line){}
    public IfcRelDefinesByProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelDefinesByType_IFC2X3 : IfcRelDefines_IFC2X3 {
    public IfcTypeObject_IFC2X3 RelatingType;

    public new List<string> param_order = new List<string>{"RelatingType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelDefinesByType_IFC2X3(string line) : base(line){}
    public IfcRelDefinesByType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelFillsElement_IFC2X3 : IfcRelConnects_IFC2X3 {
    public IfcOpeningElement_IFC2X3 RelatingOpeningElement;
    public IfcElement_IFC2X3 RelatedBuildingElement;

    public new List<string> param_order = new List<string>{"RelatingOpeningElement", "RelatedBuildingElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelFillsElement_IFC2X3(string line) : base(line){}
    public IfcRelFillsElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelFlowControlElements_IFC2X3 : IfcRelConnects_IFC2X3 {
    public List<IfcDistributionControlElement_IFC2X3> RelatedControlElements;
    public IfcDistributionFlowElement_IFC2X3 RelatingFlowElement;

    public new List<string> param_order = new List<string>{"RelatedControlElements", "RelatingFlowElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelFlowControlElements_IFC2X3(string line) : base(line){}
    public IfcRelFlowControlElements_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelInteractionRequirements_IFC2X3 : IfcRelConnects_IFC2X3 {
    public string DailyInteraction;
    public string ImportanceRating;
    public IfcSpatialStructureElement_IFC2X3 LocationOfInteraction;
    public IfcSpaceProgram_IFC2X3 RelatedSpaceProgram;
    public IfcSpaceProgram_IFC2X3 RelatingSpaceProgram;

    public new List<string> param_order = new List<string>{"DailyInteraction", "ImportanceRating", "LocationOfInteraction", "RelatedSpaceProgram", "RelatingSpaceProgram"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelInteractionRequirements_IFC2X3(string line) : base(line){}
    public IfcRelInteractionRequirements_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelNests_IFC2X3 : IfcRelDecomposes_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelNests_IFC2X3(string line) : base(line){}
    public IfcRelNests_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelOccupiesSpaces_IFC2X3 : IfcRelAssignsToActor_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelOccupiesSpaces_IFC2X3(string line) : base(line){}
    public IfcRelOccupiesSpaces_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelOverridesProperties_IFC2X3 : IfcRelDefinesByProperties_IFC2X3 {
    public List<IfcProperty_IFC2X3> OverridingProperties;

    public new List<string> param_order = new List<string>{"OverridingProperties"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelOverridesProperties_IFC2X3(string line) : base(line){}
    public IfcRelOverridesProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelProjectsElement_IFC2X3 : IfcRelConnects_IFC2X3 {
    public IfcElement_IFC2X3 RelatingElement;
    public IfcFeatureElementAddition_IFC2X3 RelatedFeatureElement;

    public new List<string> param_order = new List<string>{"RelatingElement", "RelatedFeatureElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelProjectsElement_IFC2X3(string line) : base(line){}
    public IfcRelProjectsElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelReferencedInSpatialStructure_IFC2X3 : IfcRelConnects_IFC2X3 {
    public List<IfcProduct_IFC2X3> RelatedElements;
    public IfcSpatialStructureElement_IFC2X3 RelatingStructure;

    public new List<string> param_order = new List<string>{"RelatedElements", "RelatingStructure"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelReferencedInSpatialStructure_IFC2X3(string line) : base(line){}
    public IfcRelReferencedInSpatialStructure_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelSchedulesCostItems_IFC2X3 : IfcRelAssignsToControl_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelSchedulesCostItems_IFC2X3(string line) : base(line){}
    public IfcRelSchedulesCostItems_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelSequence_IFC2X3 : IfcRelConnects_IFC2X3 {
    public IfcProcess_IFC2X3 RelatingProcess;
    public IfcProcess_IFC2X3 RelatedProcess;
    public string TimeLag;
    public string SequenceType;

    public new List<string> param_order = new List<string>{"RelatingProcess", "RelatedProcess", "TimeLag", "SequenceType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelSequence_IFC2X3(string line) : base(line){}
    public IfcRelSequence_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelServicesBuildings_IFC2X3 : IfcRelConnects_IFC2X3 {
    public IfcSystem_IFC2X3 RelatingSystem;
    public List<IfcSpatialStructureElement_IFC2X3> RelatedBuildings;

    public new List<string> param_order = new List<string>{"RelatingSystem", "RelatedBuildings"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelServicesBuildings_IFC2X3(string line) : base(line){}
    public IfcRelServicesBuildings_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelSpaceBoundary_IFC2X3 : IfcRelConnects_IFC2X3 {
    public IfcSpace_IFC2X3 RelatingSpace;
    public IfcElement_IFC2X3 RelatedBuildingElement;
    public IfcConnectionGeometry_IFC2X3 ConnectionGeometry;
    public string PhysicalOrVirtualBoundary;
    public string InternalOrExternalBoundary;

    public new List<string> param_order = new List<string>{"RelatingSpace", "RelatedBuildingElement", "ConnectionGeometry", "PhysicalOrVirtualBoundary", "InternalOrExternalBoundary"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelSpaceBoundary_IFC2X3(string line) : base(line){}
    public IfcRelSpaceBoundary_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelVoidsElement_IFC2X3 : IfcRelConnects_IFC2X3 {
    public IfcElement_IFC2X3 RelatingBuildingElement;
    public IfcFeatureElementSubtraction_IFC2X3 RelatedOpeningElement;

    public new List<string> param_order = new List<string>{"RelatingBuildingElement", "RelatedOpeningElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelVoidsElement_IFC2X3(string line) : base(line){}
    public IfcRelVoidsElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelationship_IFC2X3 : IfcRoot_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelationship_IFC2X3(string line) : base(line){}
    public IfcRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRelaxation_IFC2X3 : Entity {
    public string RelaxationValue;
    public string InitialStress;

    public new List<string> param_order = new List<string>{"RelaxationValue", "InitialStress"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelaxation_IFC2X3(string line) : base(line){}
    public IfcRelaxation_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRepresentation_IFC2X3 : Entity {
    public IfcRepresentationContext_IFC2X3 ContextOfItems;
    public string RepresentationIdentifier;
    public string RepresentationType;
    public List<IfcRepresentationItem_IFC2X3> Items;

    public new List<string> param_order = new List<string>{"ContextOfItems", "RepresentationIdentifier", "RepresentationType", "Items"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRepresentation_IFC2X3(string line) : base(line){}
    public IfcRepresentation_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRepresentationContext_IFC2X3 : Entity {
    public string ContextIdentifier;
    public string ContextType;

    public new List<string> param_order = new List<string>{"ContextIdentifier", "ContextType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRepresentationContext_IFC2X3(string line) : base(line){}
    public IfcRepresentationContext_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRepresentationItem_IFC2X3 : Entity {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRepresentationItem_IFC2X3(string line) : base(line){}
    public IfcRepresentationItem_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRepresentationMap_IFC2X3 : Entity {
    public IfcAxis2Placement_IFC2X3 MappingOrigin;
    public IfcRepresentation_IFC2X3 MappedRepresentation;

    public new List<string> param_order = new List<string>{"MappingOrigin", "MappedRepresentation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRepresentationMap_IFC2X3(string line) : base(line){}
    public IfcRepresentationMap_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcResource_IFC2X3 : IfcObject_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcResource_IFC2X3(string line) : base(line){}
    public IfcResource_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRevolvedAreaSolid_IFC2X3 : IfcSweptAreaSolid_IFC2X3 {
    public IfcAxis1Placement_IFC2X3 Axis;
    public string Angle;

    public new List<string> param_order = new List<string>{"Axis", "Angle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRevolvedAreaSolid_IFC2X3(string line) : base(line){}
    public IfcRevolvedAreaSolid_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRibPlateProfileProperties_IFC2X3 : IfcProfileProperties_IFC2X3 {
    public string Thickness;
    public string RibHeight;
    public string RibWidth;
    public string RibSpacing;
    public string Direction;

    public new List<string> param_order = new List<string>{"Thickness", "RibHeight", "RibWidth", "RibSpacing", "Direction"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRibPlateProfileProperties_IFC2X3(string line) : base(line){}
    public IfcRibPlateProfileProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRightCircularCone_IFC2X3 : IfcCsgPrimitive3D_IFC2X3 {
    public string Height;
    public string BottomRadius;

    public new List<string> param_order = new List<string>{"Height", "BottomRadius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRightCircularCone_IFC2X3(string line) : base(line){}
    public IfcRightCircularCone_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRightCircularCylinder_IFC2X3 : IfcCsgPrimitive3D_IFC2X3 {
    public string Height;
    public string Radius;

    public new List<string> param_order = new List<string>{"Height", "Radius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRightCircularCylinder_IFC2X3(string line) : base(line){}
    public IfcRightCircularCylinder_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRoof_IFC2X3 : IfcBuildingElement_IFC2X3 {
    public string ShapeType;

    public new List<string> param_order = new List<string>{"ShapeType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRoof_IFC2X3(string line) : base(line){}
    public IfcRoof_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRoot_IFC2X3 : Entity {
    public string GlobalId;
    public IfcOwnerHistory_IFC2X3 OwnerHistory;
    public string Name;
    public string Description;

    public new List<string> param_order = new List<string>{"GlobalId", "OwnerHistory", "Name", "Description"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRoot_IFC2X3(string line) : base(line){}
    public IfcRoot_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRoundedEdgeFeature_IFC2X3 : IfcEdgeFeature_IFC2X3 {
    public string Radius;

    public new List<string> param_order = new List<string>{"Radius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRoundedEdgeFeature_IFC2X3(string line) : base(line){}
    public IfcRoundedEdgeFeature_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcRoundedRectangleProfileDef_IFC2X3 : IfcRectangleProfileDef_IFC2X3 {
    public string RoundingRadius;

    public new List<string> param_order = new List<string>{"RoundingRadius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRoundedRectangleProfileDef_IFC2X3(string line) : base(line){}
    public IfcRoundedRectangleProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSIUnit_IFC2X3 : IfcNamedUnit_IFC2X3 {
    public string Prefix;
    public string Name;

    public new List<string> param_order = new List<string>{"Prefix", "Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSIUnit_IFC2X3(string line) : base(line){}
    public IfcSIUnit_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSanitaryTerminalType_IFC2X3 : IfcFlowTerminalType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSanitaryTerminalType_IFC2X3(string line) : base(line){}
    public IfcSanitaryTerminalType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcScheduleTimeControl_IFC2X3 : IfcControl_IFC2X3 {
    public IfcDateTimeSelect_IFC2X3 ActualStart;
    public IfcDateTimeSelect_IFC2X3 EarlyStart;
    public IfcDateTimeSelect_IFC2X3 LateStart;
    public IfcDateTimeSelect_IFC2X3 ScheduleStart;
    public IfcDateTimeSelect_IFC2X3 ActualFinish;
    public IfcDateTimeSelect_IFC2X3 EarlyFinish;
    public IfcDateTimeSelect_IFC2X3 LateFinish;
    public IfcDateTimeSelect_IFC2X3 ScheduleFinish;
    public string ScheduleDuration;
    public string ActualDuration;
    public string RemainingTime;
    public string FreeFloat;
    public string TotalFloat;
    public string IsCritical;
    public IfcDateTimeSelect_IFC2X3 StatusTime;
    public string StartFloat;
    public string FinishFloat;
    public string Completion;

    public new List<string> param_order = new List<string>{"ActualStart", "EarlyStart", "LateStart", "ScheduleStart", "ActualFinish", "EarlyFinish", "LateFinish", "ScheduleFinish", "ScheduleDuration", "ActualDuration", "RemainingTime", "FreeFloat", "TotalFloat", "IsCritical", "StatusTime", "StartFloat", "FinishFloat", "Completion"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcScheduleTimeControl_IFC2X3(string line) : base(line){}
    public IfcScheduleTimeControl_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSectionProperties_IFC2X3 : Entity {
    public string SectionType;
    public IfcProfileDef_IFC2X3 StartProfile;
    public IfcProfileDef_IFC2X3 EndProfile;

    public new List<string> param_order = new List<string>{"SectionType", "StartProfile", "EndProfile"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSectionProperties_IFC2X3(string line) : base(line){}
    public IfcSectionProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSectionReinforcementProperties_IFC2X3 : Entity {
    public string LongitudinalStartPosition;
    public string LongitudinalEndPosition;
    public string TransversePosition;
    public string ReinforcementRole;
    public IfcSectionProperties_IFC2X3 SectionDefinition;
    public List<IfcReinforcementBarProperties_IFC2X3> CrossSectionReinforcementDefinitions;

    public new List<string> param_order = new List<string>{"LongitudinalStartPosition", "LongitudinalEndPosition", "TransversePosition", "ReinforcementRole", "SectionDefinition", "CrossSectionReinforcementDefinitions"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSectionReinforcementProperties_IFC2X3(string line) : base(line){}
    public IfcSectionReinforcementProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSectionedSpine_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public IfcCompositeCurve_IFC2X3 SpineCurve;
    public List<IfcProfileDef_IFC2X3> CrossSections;
    public List<IfcAxis2Placement3D_IFC2X3> CrossSectionPositions;

    public new List<string> param_order = new List<string>{"SpineCurve", "CrossSections", "CrossSectionPositions"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSectionedSpine_IFC2X3(string line) : base(line){}
    public IfcSectionedSpine_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSensorType_IFC2X3 : IfcDistributionControlElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSensorType_IFC2X3(string line) : base(line){}
    public IfcSensorType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcServiceLife_IFC2X3 : IfcControl_IFC2X3 {
    public string ServiceLifeType;
    public string ServiceLifeDuration;

    public new List<string> param_order = new List<string>{"ServiceLifeType", "ServiceLifeDuration"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcServiceLife_IFC2X3(string line) : base(line){}
    public IfcServiceLife_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcServiceLifeFactor_IFC2X3 : IfcPropertySetDefinition_IFC2X3 {
    public string PredefinedType;
    public IfcMeasureValue_IFC2X3 UpperValue;
    public IfcMeasureValue_IFC2X3 MostUsedValue;
    public IfcMeasureValue_IFC2X3 LowerValue;

    public new List<string> param_order = new List<string>{"PredefinedType", "UpperValue", "MostUsedValue", "LowerValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcServiceLifeFactor_IFC2X3(string line) : base(line){}
    public IfcServiceLifeFactor_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcShapeAspect_IFC2X3 : Entity {
    public List<IfcShapeModel_IFC2X3> ShapeRepresentations;
    public string Name;
    public string Description;
    public string ProductDefinitional;
    public IfcProductDefinitionShape_IFC2X3 PartOfProductDefinitionShape;

    public new List<string> param_order = new List<string>{"ShapeRepresentations", "Name", "Description", "ProductDefinitional", "PartOfProductDefinitionShape"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcShapeAspect_IFC2X3(string line) : base(line){}
    public IfcShapeAspect_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcShapeModel_IFC2X3 : IfcRepresentation_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcShapeModel_IFC2X3(string line) : base(line){}
    public IfcShapeModel_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcShapeRepresentation_IFC2X3 : IfcShapeModel_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcShapeRepresentation_IFC2X3(string line) : base(line){}
    public IfcShapeRepresentation_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcShellBasedSurfaceModel_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public List<IfcShell_IFC2X3> SbsmBoundary;

    public new List<string> param_order = new List<string>{"SbsmBoundary"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcShellBasedSurfaceModel_IFC2X3(string line) : base(line){}
    public IfcShellBasedSurfaceModel_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSimpleProperty_IFC2X3 : IfcProperty_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSimpleProperty_IFC2X3(string line) : base(line){}
    public IfcSimpleProperty_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSite_IFC2X3 : IfcSpatialStructureElement_IFC2X3 {
    public string RefLatitude;
    public string RefLongitude;
    public string RefElevation;
    public string LandTitleNumber;
    public IfcPostalAddress_IFC2X3 SiteAddress;

    public new List<string> param_order = new List<string>{"RefLatitude", "RefLongitude", "RefElevation", "LandTitleNumber", "SiteAddress"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSite_IFC2X3(string line) : base(line){}
    public IfcSite_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSlab_IFC2X3 : IfcBuildingElement_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSlab_IFC2X3(string line) : base(line){}
    public IfcSlab_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSlabType_IFC2X3 : IfcBuildingElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSlabType_IFC2X3(string line) : base(line){}
    public IfcSlabType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSlippageConnectionCondition_IFC2X3 : IfcStructuralConnectionCondition_IFC2X3 {
    public string SlippageX;
    public string SlippageY;
    public string SlippageZ;

    public new List<string> param_order = new List<string>{"SlippageX", "SlippageY", "SlippageZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSlippageConnectionCondition_IFC2X3(string line) : base(line){}
    public IfcSlippageConnectionCondition_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSolidModel_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSolidModel_IFC2X3(string line) : base(line){}
    public IfcSolidModel_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSoundProperties_IFC2X3 : IfcPropertySetDefinition_IFC2X3 {
    public string IsAttenuating;
    public string SoundScale;
    public List<IfcSoundValue_IFC2X3> SoundValues;

    public new List<string> param_order = new List<string>{"IsAttenuating", "SoundScale", "SoundValues"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSoundProperties_IFC2X3(string line) : base(line){}
    public IfcSoundProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSoundValue_IFC2X3 : IfcPropertySetDefinition_IFC2X3 {
    public IfcTimeSeries_IFC2X3 SoundLevelTimeSeries;
    public string Frequency;
    public IfcDerivedMeasureValue_IFC2X3 SoundLevelSingleValue;

    public new List<string> param_order = new List<string>{"SoundLevelTimeSeries", "Frequency", "SoundLevelSingleValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSoundValue_IFC2X3(string line) : base(line){}
    public IfcSoundValue_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSpace_IFC2X3 : IfcSpatialStructureElement_IFC2X3 {
    public string InteriorOrExteriorSpace;
    public string ElevationWithFlooring;

    public new List<string> param_order = new List<string>{"InteriorOrExteriorSpace", "ElevationWithFlooring"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpace_IFC2X3(string line) : base(line){}
    public IfcSpace_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSpaceHeaterType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpaceHeaterType_IFC2X3(string line) : base(line){}
    public IfcSpaceHeaterType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSpaceProgram_IFC2X3 : IfcControl_IFC2X3 {
    public string SpaceProgramIdentifier;
    public string MaxRequiredArea;
    public string MinRequiredArea;
    public IfcSpatialStructureElement_IFC2X3 RequestedLocation;
    public string StandardRequiredArea;

    public new List<string> param_order = new List<string>{"SpaceProgramIdentifier", "MaxRequiredArea", "MinRequiredArea", "RequestedLocation", "StandardRequiredArea"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpaceProgram_IFC2X3(string line) : base(line){}
    public IfcSpaceProgram_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSpaceThermalLoadProperties_IFC2X3 : IfcPropertySetDefinition_IFC2X3 {
    public string ApplicableValueRatio;
    public string ThermalLoadSource;
    public string PropertySource;
    public string SourceDescription;
    public string MaximumValue;
    public string MinimumValue;
    public IfcTimeSeries_IFC2X3 ThermalLoadTimeSeriesValues;
    public string UserDefinedThermalLoadSource;
    public string UserDefinedPropertySource;
    public string ThermalLoadType;

    public new List<string> param_order = new List<string>{"ApplicableValueRatio", "ThermalLoadSource", "PropertySource", "SourceDescription", "MaximumValue", "MinimumValue", "ThermalLoadTimeSeriesValues", "UserDefinedThermalLoadSource", "UserDefinedPropertySource", "ThermalLoadType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpaceThermalLoadProperties_IFC2X3(string line) : base(line){}
    public IfcSpaceThermalLoadProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSpaceType_IFC2X3 : IfcSpatialStructureElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpaceType_IFC2X3(string line) : base(line){}
    public IfcSpaceType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSpatialStructureElement_IFC2X3 : IfcProduct_IFC2X3 {
    public string LongName;
    public string CompositionType;

    public new List<string> param_order = new List<string>{"LongName", "CompositionType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpatialStructureElement_IFC2X3(string line) : base(line){}
    public IfcSpatialStructureElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSpatialStructureElementType_IFC2X3 : IfcElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpatialStructureElementType_IFC2X3(string line) : base(line){}
    public IfcSpatialStructureElementType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSphere_IFC2X3 : IfcCsgPrimitive3D_IFC2X3 {
    public string Radius;

    public new List<string> param_order = new List<string>{"Radius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSphere_IFC2X3(string line) : base(line){}
    public IfcSphere_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStackTerminalType_IFC2X3 : IfcFlowTerminalType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStackTerminalType_IFC2X3(string line) : base(line){}
    public IfcStackTerminalType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStair_IFC2X3 : IfcBuildingElement_IFC2X3 {
    public string ShapeType;

    public new List<string> param_order = new List<string>{"ShapeType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStair_IFC2X3(string line) : base(line){}
    public IfcStair_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStairFlight_IFC2X3 : IfcBuildingElement_IFC2X3 {
    public string NumberOfRiser;
    public string NumberOfTreads;
    public string RiserHeight;
    public string TreadLength;

    public new List<string> param_order = new List<string>{"NumberOfRiser", "NumberOfTreads", "RiserHeight", "TreadLength"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStairFlight_IFC2X3(string line) : base(line){}
    public IfcStairFlight_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStairFlightType_IFC2X3 : IfcBuildingElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStairFlightType_IFC2X3(string line) : base(line){}
    public IfcStairFlightType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralAction_IFC2X3 : IfcStructuralActivity_IFC2X3 {
    public string DestabilizingLoad;
    public IfcStructuralReaction_IFC2X3 CausedBy;

    public new List<string> param_order = new List<string>{"DestabilizingLoad", "CausedBy"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralAction_IFC2X3(string line) : base(line){}
    public IfcStructuralAction_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralActivity_IFC2X3 : IfcProduct_IFC2X3 {
    public IfcStructuralLoad_IFC2X3 AppliedLoad;
    public string GlobalOrLocal;

    public new List<string> param_order = new List<string>{"AppliedLoad", "GlobalOrLocal"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralActivity_IFC2X3(string line) : base(line){}
    public IfcStructuralActivity_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralAnalysisModel_IFC2X3 : IfcSystem_IFC2X3 {
    public string PredefinedType;
    public IfcAxis2Placement3D_IFC2X3 OrientationOf2DPlane;
    public List<IfcStructuralLoadGroup_IFC2X3> LoadedBy;
    public List<IfcStructuralResultGroup_IFC2X3> HasResults;

    public new List<string> param_order = new List<string>{"PredefinedType", "OrientationOf2DPlane", "LoadedBy", "HasResults"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralAnalysisModel_IFC2X3(string line) : base(line){}
    public IfcStructuralAnalysisModel_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralConnection_IFC2X3 : IfcStructuralItem_IFC2X3 {
    public IfcBoundaryCondition_IFC2X3 AppliedCondition;

    public new List<string> param_order = new List<string>{"AppliedCondition"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralConnection_IFC2X3(string line) : base(line){}
    public IfcStructuralConnection_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralConnectionCondition_IFC2X3 : Entity {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralConnectionCondition_IFC2X3(string line) : base(line){}
    public IfcStructuralConnectionCondition_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralCurveConnection_IFC2X3 : IfcStructuralConnection_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralCurveConnection_IFC2X3(string line) : base(line){}
    public IfcStructuralCurveConnection_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralCurveMember_IFC2X3 : IfcStructuralMember_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralCurveMember_IFC2X3(string line) : base(line){}
    public IfcStructuralCurveMember_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralCurveMemberVarying_IFC2X3 : IfcStructuralCurveMember_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralCurveMemberVarying_IFC2X3(string line) : base(line){}
    public IfcStructuralCurveMemberVarying_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralItem_IFC2X3 : IfcProduct_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralItem_IFC2X3(string line) : base(line){}
    public IfcStructuralItem_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLinearAction_IFC2X3 : IfcStructuralAction_IFC2X3 {
    public string ProjectedOrTrue;

    public new List<string> param_order = new List<string>{"ProjectedOrTrue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLinearAction_IFC2X3(string line) : base(line){}
    public IfcStructuralLinearAction_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLinearActionVarying_IFC2X3 : IfcStructuralLinearAction_IFC2X3 {
    public IfcShapeAspect_IFC2X3 VaryingAppliedLoadLocation;
    public List<IfcStructuralLoad_IFC2X3> SubsequentAppliedLoads;

    public new List<string> param_order = new List<string>{"VaryingAppliedLoadLocation", "SubsequentAppliedLoads"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLinearActionVarying_IFC2X3(string line) : base(line){}
    public IfcStructuralLinearActionVarying_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoad_IFC2X3 : Entity {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoad_IFC2X3(string line) : base(line){}
    public IfcStructuralLoad_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadGroup_IFC2X3 : IfcGroup_IFC2X3 {
    public string PredefinedType;
    public string ActionType;
    public string ActionSource;
    public string Coefficient;
    public string Purpose;

    public new List<string> param_order = new List<string>{"PredefinedType", "ActionType", "ActionSource", "Coefficient", "Purpose"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadGroup_IFC2X3(string line) : base(line){}
    public IfcStructuralLoadGroup_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadLinearForce_IFC2X3 : IfcStructuralLoadStatic_IFC2X3 {
    public string LinearForceX;
    public string LinearForceY;
    public string LinearForceZ;
    public string LinearMomentX;
    public string LinearMomentY;
    public string LinearMomentZ;

    public new List<string> param_order = new List<string>{"LinearForceX", "LinearForceY", "LinearForceZ", "LinearMomentX", "LinearMomentY", "LinearMomentZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadLinearForce_IFC2X3(string line) : base(line){}
    public IfcStructuralLoadLinearForce_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadPlanarForce_IFC2X3 : IfcStructuralLoadStatic_IFC2X3 {
    public string PlanarForceX;
    public string PlanarForceY;
    public string PlanarForceZ;

    public new List<string> param_order = new List<string>{"PlanarForceX", "PlanarForceY", "PlanarForceZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadPlanarForce_IFC2X3(string line) : base(line){}
    public IfcStructuralLoadPlanarForce_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadSingleDisplacement_IFC2X3 : IfcStructuralLoadStatic_IFC2X3 {
    public string DisplacementX;
    public string DisplacementY;
    public string DisplacementZ;
    public string RotationalDisplacementRX;
    public string RotationalDisplacementRY;
    public string RotationalDisplacementRZ;

    public new List<string> param_order = new List<string>{"DisplacementX", "DisplacementY", "DisplacementZ", "RotationalDisplacementRX", "RotationalDisplacementRY", "RotationalDisplacementRZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadSingleDisplacement_IFC2X3(string line) : base(line){}
    public IfcStructuralLoadSingleDisplacement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadSingleDisplacementDistortion_IFC2X3 : IfcStructuralLoadSingleDisplacement_IFC2X3 {
    public string Distortion;

    public new List<string> param_order = new List<string>{"Distortion"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadSingleDisplacementDistortion_IFC2X3(string line) : base(line){}
    public IfcStructuralLoadSingleDisplacementDistortion_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadSingleForce_IFC2X3 : IfcStructuralLoadStatic_IFC2X3 {
    public string ForceX;
    public string ForceY;
    public string ForceZ;
    public string MomentX;
    public string MomentY;
    public string MomentZ;

    public new List<string> param_order = new List<string>{"ForceX", "ForceY", "ForceZ", "MomentX", "MomentY", "MomentZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadSingleForce_IFC2X3(string line) : base(line){}
    public IfcStructuralLoadSingleForce_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadSingleForceWarping_IFC2X3 : IfcStructuralLoadSingleForce_IFC2X3 {
    public string WarpingMoment;

    public new List<string> param_order = new List<string>{"WarpingMoment"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadSingleForceWarping_IFC2X3(string line) : base(line){}
    public IfcStructuralLoadSingleForceWarping_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadStatic_IFC2X3 : IfcStructuralLoad_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadStatic_IFC2X3(string line) : base(line){}
    public IfcStructuralLoadStatic_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadTemperature_IFC2X3 : IfcStructuralLoadStatic_IFC2X3 {
    public string DeltaT_Constant;
    public string DeltaT_Y;
    public string DeltaT_Z;

    public new List<string> param_order = new List<string>{"DeltaT_Constant", "DeltaT_Y", "DeltaT_Z"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadTemperature_IFC2X3(string line) : base(line){}
    public IfcStructuralLoadTemperature_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralMember_IFC2X3 : IfcStructuralItem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralMember_IFC2X3(string line) : base(line){}
    public IfcStructuralMember_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralPlanarAction_IFC2X3 : IfcStructuralAction_IFC2X3 {
    public string ProjectedOrTrue;

    public new List<string> param_order = new List<string>{"ProjectedOrTrue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralPlanarAction_IFC2X3(string line) : base(line){}
    public IfcStructuralPlanarAction_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralPlanarActionVarying_IFC2X3 : IfcStructuralPlanarAction_IFC2X3 {
    public IfcShapeAspect_IFC2X3 VaryingAppliedLoadLocation;
    public List<IfcStructuralLoad_IFC2X3> SubsequentAppliedLoads;

    public new List<string> param_order = new List<string>{"VaryingAppliedLoadLocation", "SubsequentAppliedLoads"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralPlanarActionVarying_IFC2X3(string line) : base(line){}
    public IfcStructuralPlanarActionVarying_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralPointAction_IFC2X3 : IfcStructuralAction_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralPointAction_IFC2X3(string line) : base(line){}
    public IfcStructuralPointAction_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralPointConnection_IFC2X3 : IfcStructuralConnection_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralPointConnection_IFC2X3(string line) : base(line){}
    public IfcStructuralPointConnection_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralPointReaction_IFC2X3 : IfcStructuralReaction_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralPointReaction_IFC2X3(string line) : base(line){}
    public IfcStructuralPointReaction_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralProfileProperties_IFC2X3 : IfcGeneralProfileProperties_IFC2X3 {
    public string TorsionalConstantX;
    public string MomentOfInertiaYZ;
    public string MomentOfInertiaY;
    public string MomentOfInertiaZ;
    public string WarpingConstant;
    public string ShearCentreZ;
    public string ShearCentreY;
    public string ShearDeformationAreaZ;
    public string ShearDeformationAreaY;
    public string MaximumSectionModulusY;
    public string MinimumSectionModulusY;
    public string MaximumSectionModulusZ;
    public string MinimumSectionModulusZ;
    public string TorsionalSectionModulus;
    public string CentreOfGravityInX;
    public string CentreOfGravityInY;

    public new List<string> param_order = new List<string>{"TorsionalConstantX", "MomentOfInertiaYZ", "MomentOfInertiaY", "MomentOfInertiaZ", "WarpingConstant", "ShearCentreZ", "ShearCentreY", "ShearDeformationAreaZ", "ShearDeformationAreaY", "MaximumSectionModulusY", "MinimumSectionModulusY", "MaximumSectionModulusZ", "MinimumSectionModulusZ", "TorsionalSectionModulus", "CentreOfGravityInX", "CentreOfGravityInY"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralProfileProperties_IFC2X3(string line) : base(line){}
    public IfcStructuralProfileProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralReaction_IFC2X3 : IfcStructuralActivity_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralReaction_IFC2X3(string line) : base(line){}
    public IfcStructuralReaction_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralResultGroup_IFC2X3 : IfcGroup_IFC2X3 {
    public string TheoryType;
    public IfcStructuralLoadGroup_IFC2X3 ResultForLoadGroup;
    public string IsLinear;

    public new List<string> param_order = new List<string>{"TheoryType", "ResultForLoadGroup", "IsLinear"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralResultGroup_IFC2X3(string line) : base(line){}
    public IfcStructuralResultGroup_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralSteelProfileProperties_IFC2X3 : IfcStructuralProfileProperties_IFC2X3 {
    public string ShearAreaZ;
    public string ShearAreaY;
    public string PlasticShapeFactorY;
    public string PlasticShapeFactorZ;

    public new List<string> param_order = new List<string>{"ShearAreaZ", "ShearAreaY", "PlasticShapeFactorY", "PlasticShapeFactorZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralSteelProfileProperties_IFC2X3(string line) : base(line){}
    public IfcStructuralSteelProfileProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralSurfaceConnection_IFC2X3 : IfcStructuralConnection_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralSurfaceConnection_IFC2X3(string line) : base(line){}
    public IfcStructuralSurfaceConnection_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralSurfaceMember_IFC2X3 : IfcStructuralMember_IFC2X3 {
    public string PredefinedType;
    public string Thickness;

    public new List<string> param_order = new List<string>{"PredefinedType", "Thickness"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralSurfaceMember_IFC2X3(string line) : base(line){}
    public IfcStructuralSurfaceMember_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralSurfaceMemberVarying_IFC2X3 : IfcStructuralSurfaceMember_IFC2X3 {
    public List<string> SubsequentThickness;
    public IfcShapeAspect_IFC2X3 VaryingThicknessLocation;

    public new List<string> param_order = new List<string>{"SubsequentThickness", "VaryingThicknessLocation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralSurfaceMemberVarying_IFC2X3(string line) : base(line){}
    public IfcStructuralSurfaceMemberVarying_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuredDimensionCallout_IFC2X3 : IfcDraughtingCallout_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuredDimensionCallout_IFC2X3(string line) : base(line){}
    public IfcStructuredDimensionCallout_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStyleModel_IFC2X3 : IfcRepresentation_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStyleModel_IFC2X3(string line) : base(line){}
    public IfcStyleModel_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStyledItem_IFC2X3 : IfcRepresentationItem_IFC2X3 {
    public IfcRepresentationItem_IFC2X3 Item;
    public List<IfcPresentationStyleAssignment_IFC2X3> Styles;
    public string Name;

    public new List<string> param_order = new List<string>{"Item", "Styles", "Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStyledItem_IFC2X3(string line) : base(line){}
    public IfcStyledItem_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcStyledRepresentation_IFC2X3 : IfcStyleModel_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStyledRepresentation_IFC2X3(string line) : base(line){}
    public IfcStyledRepresentation_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSubContractResource_IFC2X3 : IfcConstructionResource_IFC2X3 {
    public IfcActorSelect_IFC2X3 SubContractor;
    public string JobDescription;

    public new List<string> param_order = new List<string>{"SubContractor", "JobDescription"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSubContractResource_IFC2X3(string line) : base(line){}
    public IfcSubContractResource_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSubedge_IFC2X3 : IfcEdge_IFC2X3 {
    public IfcEdge_IFC2X3 ParentEdge;

    public new List<string> param_order = new List<string>{"ParentEdge"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSubedge_IFC2X3(string line) : base(line){}
    public IfcSubedge_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSurface_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurface_IFC2X3(string line) : base(line){}
    public IfcSurface_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceCurveSweptAreaSolid_IFC2X3 : IfcSweptAreaSolid_IFC2X3 {
    public IfcCurve_IFC2X3 Directrix;
    public string StartParam;
    public string EndParam;
    public IfcSurface_IFC2X3 ReferenceSurface;

    public new List<string> param_order = new List<string>{"Directrix", "StartParam", "EndParam", "ReferenceSurface"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceCurveSweptAreaSolid_IFC2X3(string line) : base(line){}
    public IfcSurfaceCurveSweptAreaSolid_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceOfLinearExtrusion_IFC2X3 : IfcSweptSurface_IFC2X3 {
    public IfcDirection_IFC2X3 ExtrudedDirection;
    public string Depth;

    public new List<string> param_order = new List<string>{"ExtrudedDirection", "Depth"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceOfLinearExtrusion_IFC2X3(string line) : base(line){}
    public IfcSurfaceOfLinearExtrusion_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceOfRevolution_IFC2X3 : IfcSweptSurface_IFC2X3 {
    public IfcAxis1Placement_IFC2X3 AxisPosition;

    public new List<string> param_order = new List<string>{"AxisPosition"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceOfRevolution_IFC2X3(string line) : base(line){}
    public IfcSurfaceOfRevolution_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceStyle_IFC2X3 : IfcPresentationStyle_IFC2X3 {
    public string Side;
    public List<IfcSurfaceStyleElementSelect_IFC2X3> Styles;

    public new List<string> param_order = new List<string>{"Side", "Styles"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceStyle_IFC2X3(string line) : base(line){}
    public IfcSurfaceStyle_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceStyleLighting_IFC2X3 : Entity {
    public IfcColourRgb_IFC2X3 DiffuseTransmissionColour;
    public IfcColourRgb_IFC2X3 DiffuseReflectionColour;
    public IfcColourRgb_IFC2X3 TransmissionColour;
    public IfcColourRgb_IFC2X3 ReflectanceColour;

    public new List<string> param_order = new List<string>{"DiffuseTransmissionColour", "DiffuseReflectionColour", "TransmissionColour", "ReflectanceColour"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceStyleLighting_IFC2X3(string line) : base(line){}
    public IfcSurfaceStyleLighting_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceStyleRefraction_IFC2X3 : Entity {
    public string RefractionIndex;
    public string DispersionFactor;

    public new List<string> param_order = new List<string>{"RefractionIndex", "DispersionFactor"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceStyleRefraction_IFC2X3(string line) : base(line){}
    public IfcSurfaceStyleRefraction_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceStyleRendering_IFC2X3 : IfcSurfaceStyleShading_IFC2X3 {
    public string Transparency;
    public IfcColourOrFactor_IFC2X3 DiffuseColour;
    public IfcColourOrFactor_IFC2X3 TransmissionColour;
    public IfcColourOrFactor_IFC2X3 DiffuseTransmissionColour;
    public IfcColourOrFactor_IFC2X3 ReflectionColour;
    public IfcColourOrFactor_IFC2X3 SpecularColour;
    public IfcSpecularHighlightSelect_IFC2X3 SpecularHighlight;
    public string ReflectanceMethod;

    public new List<string> param_order = new List<string>{"Transparency", "DiffuseColour", "TransmissionColour", "DiffuseTransmissionColour", "ReflectionColour", "SpecularColour", "SpecularHighlight", "ReflectanceMethod"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceStyleRendering_IFC2X3(string line) : base(line){}
    public IfcSurfaceStyleRendering_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceStyleShading_IFC2X3 : Entity {
    public IfcColourRgb_IFC2X3 SurfaceColour;

    public new List<string> param_order = new List<string>{"SurfaceColour"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceStyleShading_IFC2X3(string line) : base(line){}
    public IfcSurfaceStyleShading_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceStyleWithTextures_IFC2X3 : Entity {
    public List<IfcSurfaceTexture_IFC2X3> Textures;

    public new List<string> param_order = new List<string>{"Textures"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceStyleWithTextures_IFC2X3(string line) : base(line){}
    public IfcSurfaceStyleWithTextures_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceTexture_IFC2X3 : Entity {
    public string RepeatS;
    public string RepeatT;
    public string TextureType;
    public IfcCartesianTransformationOperator2D_IFC2X3 TextureTransform;

    public new List<string> param_order = new List<string>{"RepeatS", "RepeatT", "TextureType", "TextureTransform"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceTexture_IFC2X3(string line) : base(line){}
    public IfcSurfaceTexture_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSweptAreaSolid_IFC2X3 : IfcSolidModel_IFC2X3 {
    public IfcProfileDef_IFC2X3 SweptArea;
    public IfcAxis2Placement3D_IFC2X3 Position;

    public new List<string> param_order = new List<string>{"SweptArea", "Position"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSweptAreaSolid_IFC2X3(string line) : base(line){}
    public IfcSweptAreaSolid_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSweptDiskSolid_IFC2X3 : IfcSolidModel_IFC2X3 {
    public IfcCurve_IFC2X3 Directrix;
    public string Radius;
    public string InnerRadius;
    public string StartParam;
    public string EndParam;

    public new List<string> param_order = new List<string>{"Directrix", "Radius", "InnerRadius", "StartParam", "EndParam"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSweptDiskSolid_IFC2X3(string line) : base(line){}
    public IfcSweptDiskSolid_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSweptSurface_IFC2X3 : IfcSurface_IFC2X3 {
    public IfcProfileDef_IFC2X3 SweptCurve;
    public IfcAxis2Placement3D_IFC2X3 Position;

    public new List<string> param_order = new List<string>{"SweptCurve", "Position"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSweptSurface_IFC2X3(string line) : base(line){}
    public IfcSweptSurface_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSwitchingDeviceType_IFC2X3 : IfcFlowControllerType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSwitchingDeviceType_IFC2X3(string line) : base(line){}
    public IfcSwitchingDeviceType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSymbolStyle_IFC2X3 : IfcPresentationStyle_IFC2X3 {
    public IfcSymbolStyleSelect_IFC2X3 StyleOfSymbol;

    public new List<string> param_order = new List<string>{"StyleOfSymbol"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSymbolStyle_IFC2X3(string line) : base(line){}
    public IfcSymbolStyle_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSystem_IFC2X3 : IfcGroup_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSystem_IFC2X3(string line) : base(line){}
    public IfcSystem_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcSystemFurnitureElementType_IFC2X3 : IfcFurnishingElementType_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSystemFurnitureElementType_IFC2X3(string line) : base(line){}
    public IfcSystemFurnitureElementType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTShapeProfileDef_IFC2X3 : IfcParameterizedProfileDef_IFC2X3 {
    public string Depth;
    public string FlangeWidth;
    public string WebThickness;
    public string FlangeThickness;
    public string FilletRadius;
    public string FlangeEdgeRadius;
    public string WebEdgeRadius;
    public string WebSlope;
    public string FlangeSlope;
    public string CentreOfGravityInY;

    public new List<string> param_order = new List<string>{"Depth", "FlangeWidth", "WebThickness", "FlangeThickness", "FilletRadius", "FlangeEdgeRadius", "WebEdgeRadius", "WebSlope", "FlangeSlope", "CentreOfGravityInY"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTShapeProfileDef_IFC2X3(string line) : base(line){}
    public IfcTShapeProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTable_IFC2X3 : Entity {
    public string Name;
    public List<IfcTableRow_IFC2X3> Rows;

    public new List<string> param_order = new List<string>{"Name", "Rows"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTable_IFC2X3(string line) : base(line){}
    public IfcTable_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTableRow_IFC2X3 : Entity {
    public List<IfcValue_IFC2X3> RowCells;
    public string IsHeading;

    public new List<string> param_order = new List<string>{"RowCells", "IsHeading"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTableRow_IFC2X3(string line) : base(line){}
    public IfcTableRow_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTankType_IFC2X3 : IfcFlowStorageDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTankType_IFC2X3(string line) : base(line){}
    public IfcTankType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTask_IFC2X3 : IfcProcess_IFC2X3 {
    public string TaskId;
    public string Status;
    public string WorkMethod;
    public string IsMilestone;
    public string Priority;

    public new List<string> param_order = new List<string>{"TaskId", "Status", "WorkMethod", "IsMilestone", "Priority"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTask_IFC2X3(string line) : base(line){}
    public IfcTask_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTelecomAddress_IFC2X3 : IfcAddress_IFC2X3 {
    public List<string> TelephoneNumbers;
    public List<string> FacsimileNumbers;
    public string PagerNumber;
    public List<string> ElectronicMailAddresses;
    public string WWWHomePageURL;

    public new List<string> param_order = new List<string>{"TelephoneNumbers", "FacsimileNumbers", "PagerNumber", "ElectronicMailAddresses", "WWWHomePageURL"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTelecomAddress_IFC2X3(string line) : base(line){}
    public IfcTelecomAddress_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTendon_IFC2X3 : IfcReinforcingElement_IFC2X3 {
    public string PredefinedType;
    public string NominalDiameter;
    public string CrossSectionArea;
    public string TensionForce;
    public string PreStress;
    public string FrictionCoefficient;
    public string AnchorageSlip;
    public string MinCurvatureRadius;

    public new List<string> param_order = new List<string>{"PredefinedType", "NominalDiameter", "CrossSectionArea", "TensionForce", "PreStress", "FrictionCoefficient", "AnchorageSlip", "MinCurvatureRadius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTendon_IFC2X3(string line) : base(line){}
    public IfcTendon_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTendonAnchor_IFC2X3 : IfcReinforcingElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTendonAnchor_IFC2X3(string line) : base(line){}
    public IfcTendonAnchor_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTerminatorSymbol_IFC2X3 : IfcAnnotationSymbolOccurrence_IFC2X3 {
    public IfcAnnotationCurveOccurrence_IFC2X3 AnnotatedCurve;

    public new List<string> param_order = new List<string>{"AnnotatedCurve"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTerminatorSymbol_IFC2X3(string line) : base(line){}
    public IfcTerminatorSymbol_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTextLiteral_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public string Literal;
    public IfcAxis2Placement_IFC2X3 Placement;
    public string Path;

    public new List<string> param_order = new List<string>{"Literal", "Placement", "Path"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextLiteral_IFC2X3(string line) : base(line){}
    public IfcTextLiteral_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTextLiteralWithExtent_IFC2X3 : IfcTextLiteral_IFC2X3 {
    public IfcPlanarExtent_IFC2X3 Extent;
    public string BoxAlignment;

    public new List<string> param_order = new List<string>{"Extent", "BoxAlignment"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextLiteralWithExtent_IFC2X3(string line) : base(line){}
    public IfcTextLiteralWithExtent_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTextStyle_IFC2X3 : IfcPresentationStyle_IFC2X3 {
    public IfcCharacterStyleSelect_IFC2X3 TextCharacterAppearance;
    public IfcTextStyleSelect_IFC2X3 TextStyle;
    public IfcTextFontSelect_IFC2X3 TextFontStyle;

    public new List<string> param_order = new List<string>{"TextCharacterAppearance", "TextStyle", "TextFontStyle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextStyle_IFC2X3(string line) : base(line){}
    public IfcTextStyle_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTextStyleFontModel_IFC2X3 : IfcPreDefinedTextFont_IFC2X3 {
    public List<string> FontFamily;
    public string FontStyle;
    public string FontVariant;
    public string FontWeight;
    public IfcSizeSelect_IFC2X3 FontSize;

    public new List<string> param_order = new List<string>{"FontFamily", "FontStyle", "FontVariant", "FontWeight", "FontSize"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextStyleFontModel_IFC2X3(string line) : base(line){}
    public IfcTextStyleFontModel_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTextStyleForDefinedFont_IFC2X3 : Entity {
    public IfcColour_IFC2X3 Colour;
    public IfcColour_IFC2X3 BackgroundColour;

    public new List<string> param_order = new List<string>{"Colour", "BackgroundColour"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextStyleForDefinedFont_IFC2X3(string line) : base(line){}
    public IfcTextStyleForDefinedFont_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTextStyleTextModel_IFC2X3 : Entity {
    public IfcSizeSelect_IFC2X3 TextIndent;
    public string TextAlign;
    public string TextDecoration;
    public IfcSizeSelect_IFC2X3 LetterSpacing;
    public IfcSizeSelect_IFC2X3 WordSpacing;
    public string TextTransform;
    public IfcSizeSelect_IFC2X3 LineHeight;

    public new List<string> param_order = new List<string>{"TextIndent", "TextAlign", "TextDecoration", "LetterSpacing", "WordSpacing", "TextTransform", "LineHeight"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextStyleTextModel_IFC2X3(string line) : base(line){}
    public IfcTextStyleTextModel_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTextStyleWithBoxCharacteristics_IFC2X3 : Entity {
    public string BoxHeight;
    public string BoxWidth;
    public string BoxSlantAngle;
    public string BoxRotateAngle;
    public IfcSizeSelect_IFC2X3 CharacterSpacing;

    public new List<string> param_order = new List<string>{"BoxHeight", "BoxWidth", "BoxSlantAngle", "BoxRotateAngle", "CharacterSpacing"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextStyleWithBoxCharacteristics_IFC2X3(string line) : base(line){}
    public IfcTextStyleWithBoxCharacteristics_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTextureCoordinate_IFC2X3 : Entity {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextureCoordinate_IFC2X3(string line) : base(line){}
    public IfcTextureCoordinate_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTextureCoordinateGenerator_IFC2X3 : IfcTextureCoordinate_IFC2X3 {
    public string Mode;
    public List<IfcSimpleValue_IFC2X3> Parameter;

    public new List<string> param_order = new List<string>{"Mode", "Parameter"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextureCoordinateGenerator_IFC2X3(string line) : base(line){}
    public IfcTextureCoordinateGenerator_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTextureMap_IFC2X3 : IfcTextureCoordinate_IFC2X3 {
    public List<IfcVertexBasedTextureMap_IFC2X3> TextureMaps;

    public new List<string> param_order = new List<string>{"TextureMaps"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextureMap_IFC2X3(string line) : base(line){}
    public IfcTextureMap_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTextureVertex_IFC2X3 : Entity {
    public List<string> Coordinates;

    public new List<string> param_order = new List<string>{"Coordinates"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextureVertex_IFC2X3(string line) : base(line){}
    public IfcTextureVertex_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcThermalMaterialProperties_IFC2X3 : IfcMaterialProperties_IFC2X3 {
    public string SpecificHeatCapacity;
    public string BoilingPoint;
    public string FreezingPoint;
    public string ThermalConductivity;

    public new List<string> param_order = new List<string>{"SpecificHeatCapacity", "BoilingPoint", "FreezingPoint", "ThermalConductivity"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcThermalMaterialProperties_IFC2X3(string line) : base(line){}
    public IfcThermalMaterialProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTimeSeries_IFC2X3 : Entity {
    public string Name;
    public string Description;
    public IfcDateTimeSelect_IFC2X3 StartTime;
    public IfcDateTimeSelect_IFC2X3 EndTime;
    public string TimeSeriesDataType;
    public string DataOrigin;
    public string UserDefinedDataOrigin;
    public IfcUnit_IFC2X3 Unit;

    public new List<string> param_order = new List<string>{"Name", "Description", "StartTime", "EndTime", "TimeSeriesDataType", "DataOrigin", "UserDefinedDataOrigin", "Unit"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTimeSeries_IFC2X3(string line) : base(line){}
    public IfcTimeSeries_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTimeSeriesReferenceRelationship_IFC2X3 : Entity {
    public IfcTimeSeries_IFC2X3 ReferencedTimeSeries;
    public List<IfcDocumentSelect_IFC2X3> TimeSeriesReferences;

    public new List<string> param_order = new List<string>{"ReferencedTimeSeries", "TimeSeriesReferences"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTimeSeriesReferenceRelationship_IFC2X3(string line) : base(line){}
    public IfcTimeSeriesReferenceRelationship_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTimeSeriesSchedule_IFC2X3 : IfcControl_IFC2X3 {
    public List<IfcDateTimeSelect_IFC2X3> ApplicableDates;
    public string TimeSeriesScheduleType;
    public IfcTimeSeries_IFC2X3 TimeSeries;

    public new List<string> param_order = new List<string>{"ApplicableDates", "TimeSeriesScheduleType", "TimeSeries"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTimeSeriesSchedule_IFC2X3(string line) : base(line){}
    public IfcTimeSeriesSchedule_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTimeSeriesValue_IFC2X3 : Entity {
    public List<IfcValue_IFC2X3> ListValues;

    public new List<string> param_order = new List<string>{"ListValues"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTimeSeriesValue_IFC2X3(string line) : base(line){}
    public IfcTimeSeriesValue_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTopologicalRepresentationItem_IFC2X3 : IfcRepresentationItem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTopologicalRepresentationItem_IFC2X3(string line) : base(line){}
    public IfcTopologicalRepresentationItem_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTopologyRepresentation_IFC2X3 : IfcShapeModel_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTopologyRepresentation_IFC2X3(string line) : base(line){}
    public IfcTopologyRepresentation_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTransformerType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTransformerType_IFC2X3(string line) : base(line){}
    public IfcTransformerType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTransportElement_IFC2X3 : IfcElement_IFC2X3 {
    public string OperationType;
    public string CapacityByWeight;
    public string CapacityByNumber;

    public new List<string> param_order = new List<string>{"OperationType", "CapacityByWeight", "CapacityByNumber"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTransportElement_IFC2X3(string line) : base(line){}
    public IfcTransportElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTransportElementType_IFC2X3 : IfcElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTransportElementType_IFC2X3(string line) : base(line){}
    public IfcTransportElementType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTrapeziumProfileDef_IFC2X3 : IfcParameterizedProfileDef_IFC2X3 {
    public string BottomXDim;
    public string TopXDim;
    public string YDim;
    public string TopXOffset;

    public new List<string> param_order = new List<string>{"BottomXDim", "TopXDim", "YDim", "TopXOffset"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTrapeziumProfileDef_IFC2X3(string line) : base(line){}
    public IfcTrapeziumProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTrimmedCurve_IFC2X3 : IfcBoundedCurve_IFC2X3 {
    public IfcCurve_IFC2X3 BasisCurve;
    public List<IfcTrimmingSelect_IFC2X3> Trim1;
    public List<IfcTrimmingSelect_IFC2X3> Trim2;
    public string SenseAgreement;
    public string MasterRepresentation;

    public new List<string> param_order = new List<string>{"BasisCurve", "Trim1", "Trim2", "SenseAgreement", "MasterRepresentation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTrimmedCurve_IFC2X3(string line) : base(line){}
    public IfcTrimmedCurve_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTubeBundleType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTubeBundleType_IFC2X3(string line) : base(line){}
    public IfcTubeBundleType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTwoDirectionRepeatFactor_IFC2X3 : IfcOneDirectionRepeatFactor_IFC2X3 {
    public IfcVector_IFC2X3 SecondRepeatFactor;

    public new List<string> param_order = new List<string>{"SecondRepeatFactor"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTwoDirectionRepeatFactor_IFC2X3(string line) : base(line){}
    public IfcTwoDirectionRepeatFactor_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTypeObject_IFC2X3 : IfcObjectDefinition_IFC2X3 {
    public string ApplicableOccurrence;
    public List<IfcPropertySetDefinition_IFC2X3> HasPropertySets;

    public new List<string> param_order = new List<string>{"ApplicableOccurrence", "HasPropertySets"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTypeObject_IFC2X3(string line) : base(line){}
    public IfcTypeObject_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcTypeProduct_IFC2X3 : IfcTypeObject_IFC2X3 {
    public List<IfcRepresentationMap_IFC2X3> RepresentationMaps;
    public string Tag;

    public new List<string> param_order = new List<string>{"RepresentationMaps", "Tag"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTypeProduct_IFC2X3(string line) : base(line){}
    public IfcTypeProduct_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcUShapeProfileDef_IFC2X3 : IfcParameterizedProfileDef_IFC2X3 {
    public string Depth;
    public string FlangeWidth;
    public string WebThickness;
    public string FlangeThickness;
    public string FilletRadius;
    public string EdgeRadius;
    public string FlangeSlope;
    public string CentreOfGravityInX;

    public new List<string> param_order = new List<string>{"Depth", "FlangeWidth", "WebThickness", "FlangeThickness", "FilletRadius", "EdgeRadius", "FlangeSlope", "CentreOfGravityInX"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcUShapeProfileDef_IFC2X3(string line) : base(line){}
    public IfcUShapeProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcUnitAssignment_IFC2X3 : Entity {
    public List<IfcUnit_IFC2X3> Units;

    public new List<string> param_order = new List<string>{"Units"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcUnitAssignment_IFC2X3(string line) : base(line){}
    public IfcUnitAssignment_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcUnitaryEquipmentType_IFC2X3 : IfcEnergyConversionDeviceType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcUnitaryEquipmentType_IFC2X3(string line) : base(line){}
    public IfcUnitaryEquipmentType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcValveType_IFC2X3 : IfcFlowControllerType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcValveType_IFC2X3(string line) : base(line){}
    public IfcValveType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcVector_IFC2X3 : IfcGeometricRepresentationItem_IFC2X3 {
    public IfcDirection_IFC2X3 Orientation;
    public string Magnitude;

    public new List<string> param_order = new List<string>{"Orientation", "Magnitude"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVector_IFC2X3(string line) : base(line){}
    public IfcVector_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcVertex_IFC2X3 : IfcTopologicalRepresentationItem_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVertex_IFC2X3(string line) : base(line){}
    public IfcVertex_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcVertexBasedTextureMap_IFC2X3 : Entity {
    public List<IfcTextureVertex_IFC2X3> TextureVertices;
    public List<IfcCartesianPoint_IFC2X3> TexturePoints;

    public new List<string> param_order = new List<string>{"TextureVertices", "TexturePoints"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVertexBasedTextureMap_IFC2X3(string line) : base(line){}
    public IfcVertexBasedTextureMap_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcVertexLoop_IFC2X3 : IfcLoop_IFC2X3 {
    public IfcVertex_IFC2X3 LoopVertex;

    public new List<string> param_order = new List<string>{"LoopVertex"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVertexLoop_IFC2X3(string line) : base(line){}
    public IfcVertexLoop_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcVertexPoint_IFC2X3 : IfcVertex_IFC2X3 {
    public IfcPoint_IFC2X3 VertexGeometry;

    public new List<string> param_order = new List<string>{"VertexGeometry"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVertexPoint_IFC2X3(string line) : base(line){}
    public IfcVertexPoint_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcVibrationIsolatorType_IFC2X3 : IfcDiscreteAccessoryType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVibrationIsolatorType_IFC2X3(string line) : base(line){}
    public IfcVibrationIsolatorType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcVirtualElement_IFC2X3 : IfcElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVirtualElement_IFC2X3(string line) : base(line){}
    public IfcVirtualElement_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcVirtualGridIntersection_IFC2X3 : Entity {
    public List<IfcGridAxis_IFC2X3> IntersectingAxes;
    public List<string> OffsetDistances;

    public new List<string> param_order = new List<string>{"IntersectingAxes", "OffsetDistances"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVirtualGridIntersection_IFC2X3(string line) : base(line){}
    public IfcVirtualGridIntersection_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcWall_IFC2X3 : IfcBuildingElement_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWall_IFC2X3(string line) : base(line){}
    public IfcWall_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcWallStandardCase_IFC2X3 : IfcWall_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWallStandardCase_IFC2X3(string line) : base(line){}
    public IfcWallStandardCase_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcWallType_IFC2X3 : IfcBuildingElementType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWallType_IFC2X3(string line) : base(line){}
    public IfcWallType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcWasteTerminalType_IFC2X3 : IfcFlowTerminalType_IFC2X3 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWasteTerminalType_IFC2X3(string line) : base(line){}
    public IfcWasteTerminalType_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcWaterProperties_IFC2X3 : IfcMaterialProperties_IFC2X3 {
    public string IsPotable;
    public string Hardness;
    public string AlkalinityConcentration;
    public string AcidityConcentration;
    public string ImpuritiesContent;
    public string PHLevel;
    public string DissolvedSolidsContent;

    public new List<string> param_order = new List<string>{"IsPotable", "Hardness", "AlkalinityConcentration", "AcidityConcentration", "ImpuritiesContent", "PHLevel", "DissolvedSolidsContent"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWaterProperties_IFC2X3(string line) : base(line){}
    public IfcWaterProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcWindow_IFC2X3 : IfcBuildingElement_IFC2X3 {
    public string OverallHeight;
    public string OverallWidth;

    public new List<string> param_order = new List<string>{"OverallHeight", "OverallWidth"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWindow_IFC2X3(string line) : base(line){}
    public IfcWindow_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcWindowLiningProperties_IFC2X3 : IfcPropertySetDefinition_IFC2X3 {
    public string LiningDepth;
    public string LiningThickness;
    public string TransomThickness;
    public string MullionThickness;
    public string FirstTransomOffset;
    public string SecondTransomOffset;
    public string FirstMullionOffset;
    public string SecondMullionOffset;
    public IfcShapeAspect_IFC2X3 ShapeAspectStyle;

    public new List<string> param_order = new List<string>{"LiningDepth", "LiningThickness", "TransomThickness", "MullionThickness", "FirstTransomOffset", "SecondTransomOffset", "FirstMullionOffset", "SecondMullionOffset", "ShapeAspectStyle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWindowLiningProperties_IFC2X3(string line) : base(line){}
    public IfcWindowLiningProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcWindowPanelProperties_IFC2X3 : IfcPropertySetDefinition_IFC2X3 {
    public string OperationType;
    public string PanelPosition;
    public string FrameDepth;
    public string FrameThickness;
    public IfcShapeAspect_IFC2X3 ShapeAspectStyle;

    public new List<string> param_order = new List<string>{"OperationType", "PanelPosition", "FrameDepth", "FrameThickness", "ShapeAspectStyle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWindowPanelProperties_IFC2X3(string line) : base(line){}
    public IfcWindowPanelProperties_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcWindowStyle_IFC2X3 : IfcTypeProduct_IFC2X3 {
    public string ConstructionType;
    public string OperationType;
    public string ParameterTakesPrecedence;
    public string Sizeable;

    public new List<string> param_order = new List<string>{"ConstructionType", "OperationType", "ParameterTakesPrecedence", "Sizeable"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWindowStyle_IFC2X3(string line) : base(line){}
    public IfcWindowStyle_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcWorkControl_IFC2X3 : IfcControl_IFC2X3 {
    public string Identifier;
    public IfcDateTimeSelect_IFC2X3 CreationDate;
    public List<IfcPerson_IFC2X3> Creators;
    public string Purpose;
    public string Duration;
    public string TotalFloat;
    public IfcDateTimeSelect_IFC2X3 StartTime;
    public IfcDateTimeSelect_IFC2X3 FinishTime;
    public string WorkControlType;
    public string UserDefinedControlType;

    public new List<string> param_order = new List<string>{"Identifier", "CreationDate", "Creators", "Purpose", "Duration", "TotalFloat", "StartTime", "FinishTime", "WorkControlType", "UserDefinedControlType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWorkControl_IFC2X3(string line) : base(line){}
    public IfcWorkControl_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcWorkPlan_IFC2X3 : IfcWorkControl_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWorkPlan_IFC2X3(string line) : base(line){}
    public IfcWorkPlan_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcWorkSchedule_IFC2X3 : IfcWorkControl_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWorkSchedule_IFC2X3(string line) : base(line){}
    public IfcWorkSchedule_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcZShapeProfileDef_IFC2X3 : IfcParameterizedProfileDef_IFC2X3 {
    public string Depth;
    public string FlangeWidth;
    public string WebThickness;
    public string FlangeThickness;
    public string FilletRadius;
    public string EdgeRadius;

    public new List<string> param_order = new List<string>{"Depth", "FlangeWidth", "WebThickness", "FlangeThickness", "FilletRadius", "EdgeRadius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcZShapeProfileDef_IFC2X3(string line) : base(line){}
    public IfcZShapeProfileDef_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class IfcZone_IFC2X3 : IfcGroup_IFC2X3 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcZone_IFC2X3(string line) : base(line){}
    public IfcZone_IFC2X3(Dictionary<string, object> p) : base(p){}
}

public class Entity : IfcRow {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public Entity(string line) : base(line){}
    public Entity(Dictionary<string, object> p) : base(p){}
}

public class IfcActorSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcOrganization_IFC2X3), typeof(IfcPersonAndOrganization_IFC2X3), typeof(IfcPerson_IFC2X3)};
    public IfcActorSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcAppliedValueSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcMeasureWithUnit_IFC2X3), typeof(string)};
    public IfcAppliedValueSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcAxis2Placement_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcAxis2Placement2D_IFC2X3), typeof(IfcAxis2Placement3D_IFC2X3)};
    public IfcAxis2Placement_IFC2X3 (object value) : base(value) {}
}

public class IfcBooleanOperand_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcBooleanResult_IFC2X3), typeof(IfcCsgPrimitive3D_IFC2X3), typeof(IfcHalfSpaceSolid_IFC2X3), typeof(IfcSolidModel_IFC2X3)};
    public IfcBooleanOperand_IFC2X3 (object value) : base(value) {}
}

public class IfcCharacterStyleSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcTextStyleForDefinedFont_IFC2X3)};
    public IfcCharacterStyleSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcClassificationNotationSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcClassificationNotation_IFC2X3), typeof(IfcClassificationReference_IFC2X3)};
    public IfcClassificationNotationSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcColour_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcColourSpecification_IFC2X3), typeof(IfcPreDefinedColour_IFC2X3)};
    public IfcColour_IFC2X3 (object value) : base(value) {}
}

public class IfcColourOrFactor_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcColourRgb_IFC2X3), typeof(string)};
    public IfcColourOrFactor_IFC2X3 (object value) : base(value) {}
}

public class IfcConditionCriterionSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcMeasureWithUnit_IFC2X3), typeof(string)};
    public IfcConditionCriterionSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcCsgSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcBooleanResult_IFC2X3), typeof(IfcCsgPrimitive3D_IFC2X3)};
    public IfcCsgSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcCurveFontOrScaledCurveFontSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcCurveStyleFontAndScaling_IFC2X3), typeof(IfcCurveStyleFont_IFC2X3), typeof(IfcPreDefinedCurveFont_IFC2X3)};
    public IfcCurveFontOrScaledCurveFontSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcCurveOrEdgeCurve_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcBoundedCurve_IFC2X3), typeof(IfcEdgeCurve_IFC2X3)};
    public IfcCurveOrEdgeCurve_IFC2X3 (object value) : base(value) {}
}

public class IfcCurveStyleFontSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcCurveStyleFont_IFC2X3), typeof(IfcPreDefinedCurveFont_IFC2X3)};
    public IfcCurveStyleFontSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcDateTimeSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcCalendarDate_IFC2X3), typeof(IfcDateAndTime_IFC2X3), typeof(IfcLocalTime_IFC2X3)};
    public IfcDateTimeSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcDefinedSymbolSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcExternallyDefinedSymbol_IFC2X3), typeof(IfcPreDefinedSymbol_IFC2X3)};
    public IfcDefinedSymbolSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcDerivedMeasureValue_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcDerivedMeasureValue_IFC2X3 (object value) : base(value) {}
}

public class IfcDocumentSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcDocumentInformation_IFC2X3), typeof(IfcDocumentReference_IFC2X3)};
    public IfcDocumentSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcDraughtingCalloutElement_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcAnnotationCurveOccurrence_IFC2X3), typeof(IfcAnnotationSymbolOccurrence_IFC2X3), typeof(IfcAnnotationTextOccurrence_IFC2X3)};
    public IfcDraughtingCalloutElement_IFC2X3 (object value) : base(value) {}
}

public class IfcFillAreaStyleTileShapeSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcFillAreaStyleTileSymbolWithStyle_IFC2X3)};
    public IfcFillAreaStyleTileShapeSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcFillStyleSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcColourSpecification_IFC2X3), typeof(IfcExternallyDefinedHatchStyle_IFC2X3), typeof(IfcFillAreaStyleHatching_IFC2X3), typeof(IfcFillAreaStyleTiles_IFC2X3), typeof(IfcPreDefinedColour_IFC2X3)};
    public IfcFillStyleSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcGeometricSetSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcCurve_IFC2X3), typeof(IfcPoint_IFC2X3), typeof(IfcSurface_IFC2X3)};
    public IfcGeometricSetSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcHatchLineDistanceSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcOneDirectionRepeatFactor_IFC2X3), typeof(string)};
    public IfcHatchLineDistanceSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcLayeredItem_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcRepresentationItem_IFC2X3), typeof(IfcRepresentation_IFC2X3)};
    public IfcLayeredItem_IFC2X3 (object value) : base(value) {}
}

public class IfcLibrarySelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcLibraryInformation_IFC2X3), typeof(IfcLibraryReference_IFC2X3)};
    public IfcLibrarySelect_IFC2X3 (object value) : base(value) {}
}

public class IfcLightDistributionDataSourceSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcExternalReference_IFC2X3), typeof(IfcLightIntensityDistribution_IFC2X3)};
    public IfcLightDistributionDataSourceSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcMaterialSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcMaterialLayerSetUsage_IFC2X3), typeof(IfcMaterialLayerSet_IFC2X3), typeof(IfcMaterialLayer_IFC2X3), typeof(IfcMaterialList_IFC2X3), typeof(IfcMaterial_IFC2X3)};
    public IfcMaterialSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcMeasureValue_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcMeasureValue_IFC2X3 (object value) : base(value) {}
}

public class IfcMetricValueSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcCalendarDate_IFC2X3), typeof(IfcCostValue_IFC2X3), typeof(IfcDateAndTime_IFC2X3), typeof(IfcLocalTime_IFC2X3), typeof(IfcMeasureWithUnit_IFC2X3), typeof(IfcTable_IFC2X3), typeof(IfcTimeSeries_IFC2X3), typeof(string)};
    public IfcMetricValueSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcObjectReferenceSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcAddress_IFC2X3), typeof(IfcAppliedValue_IFC2X3), typeof(IfcCalendarDate_IFC2X3), typeof(IfcDateAndTime_IFC2X3), typeof(IfcExternalReference_IFC2X3), typeof(IfcLocalTime_IFC2X3), typeof(IfcMaterialLayer_IFC2X3), typeof(IfcMaterialList_IFC2X3), typeof(IfcMaterial_IFC2X3), typeof(IfcOrganization_IFC2X3), typeof(IfcPersonAndOrganization_IFC2X3), typeof(IfcPerson_IFC2X3), typeof(IfcTimeSeries_IFC2X3)};
    public IfcObjectReferenceSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcOrientationSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcDirection_IFC2X3), typeof(string)};
    public IfcOrientationSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcPointOrVertexPoint_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcPoint_IFC2X3), typeof(IfcVertexPoint_IFC2X3)};
    public IfcPointOrVertexPoint_IFC2X3 (object value) : base(value) {}
}

public class IfcPresentationStyleSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcCurveStyle_IFC2X3), typeof(IfcFillAreaStyle_IFC2X3), typeof(IfcSurfaceStyle_IFC2X3), typeof(IfcSymbolStyle_IFC2X3), typeof(IfcTextStyle_IFC2X3), typeof(string)};
    public IfcPresentationStyleSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcShell_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcClosedShell_IFC2X3), typeof(IfcOpenShell_IFC2X3)};
    public IfcShell_IFC2X3 (object value) : base(value) {}
}

public class IfcSimpleValue_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcSimpleValue_IFC2X3 (object value) : base(value) {}
}

public class IfcSizeSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcSizeSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcSpecularHighlightSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcSpecularHighlightSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcStructuralActivityAssignmentSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcElement_IFC2X3), typeof(IfcStructuralItem_IFC2X3)};
    public IfcStructuralActivityAssignmentSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcSurfaceOrFaceSurface_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcFaceBasedSurfaceModel_IFC2X3), typeof(IfcFaceSurface_IFC2X3), typeof(IfcSurface_IFC2X3)};
    public IfcSurfaceOrFaceSurface_IFC2X3 (object value) : base(value) {}
}

public class IfcSurfaceStyleElementSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcExternallyDefinedSurfaceStyle_IFC2X3), typeof(IfcSurfaceStyleLighting_IFC2X3), typeof(IfcSurfaceStyleRefraction_IFC2X3), typeof(IfcSurfaceStyleShading_IFC2X3), typeof(IfcSurfaceStyleWithTextures_IFC2X3)};
    public IfcSurfaceStyleElementSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcSymbolStyleSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcColourSpecification_IFC2X3), typeof(IfcPreDefinedColour_IFC2X3)};
    public IfcSymbolStyleSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcTextFontSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcExternallyDefinedTextFont_IFC2X3), typeof(IfcPreDefinedTextFont_IFC2X3)};
    public IfcTextFontSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcTextStyleSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcTextStyleTextModel_IFC2X3), typeof(IfcTextStyleWithBoxCharacteristics_IFC2X3)};
    public IfcTextStyleSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcTrimmingSelect_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcCartesianPoint_IFC2X3), typeof(string)};
    public IfcTrimmingSelect_IFC2X3 (object value) : base(value) {}
}

public class IfcUnit_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcDerivedUnit_IFC2X3), typeof(IfcMonetaryUnit_IFC2X3), typeof(IfcNamedUnit_IFC2X3)};
    public IfcUnit_IFC2X3 (object value) : base(value) {}
}

public class IfcValue_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcValue_IFC2X3 (object value) : base(value) {}
}

public class IfcVectorOrDirection_IFC2X3 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcDirection_IFC2X3), typeof(IfcVector_IFC2X3)};
    public IfcVectorOrDirection_IFC2X3 (object value) : base(value) {}
}

public class IfcActionRequest_IFC4 : IfcControl_IFC4 {
    public string PredefinedType;
    public string Status;
    public string LongDescription;

    public new List<string> param_order = new List<string>{"PredefinedType", "Status", "LongDescription"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcActionRequest_IFC4(string line) : base(line){}
    public IfcActionRequest_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcActor_IFC4 : IfcObject_IFC4 {
    public IfcActorSelect_IFC4 TheActor;

    public new List<string> param_order = new List<string>{"TheActor"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcActor_IFC4(string line) : base(line){}
    public IfcActor_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcActorRole_IFC4 : Entity {
    public string Role;
    public string UserDefinedRole;
    public string Description;

    public new List<string> param_order = new List<string>{"Role", "UserDefinedRole", "Description"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcActorRole_IFC4(string line) : base(line){}
    public IfcActorRole_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcActuator_IFC4 : IfcDistributionControlElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcActuator_IFC4(string line) : base(line){}
    public IfcActuator_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcActuatorType_IFC4 : IfcDistributionControlElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcActuatorType_IFC4(string line) : base(line){}
    public IfcActuatorType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAddress_IFC4 : Entity {
    public string Purpose;
    public string Description;
    public string UserDefinedPurpose;

    public new List<string> param_order = new List<string>{"Purpose", "Description", "UserDefinedPurpose"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAddress_IFC4(string line) : base(line){}
    public IfcAddress_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAdvancedBrep_IFC4 : IfcManifoldSolidBrep_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAdvancedBrep_IFC4(string line) : base(line){}
    public IfcAdvancedBrep_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAdvancedBrepWithVoids_IFC4 : IfcAdvancedBrep_IFC4 {
    public List<IfcClosedShell_IFC4> Voids;

    public new List<string> param_order = new List<string>{"Voids"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAdvancedBrepWithVoids_IFC4(string line) : base(line){}
    public IfcAdvancedBrepWithVoids_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAdvancedFace_IFC4 : IfcFaceSurface_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAdvancedFace_IFC4(string line) : base(line){}
    public IfcAdvancedFace_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAirTerminal_IFC4 : IfcFlowTerminal_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAirTerminal_IFC4(string line) : base(line){}
    public IfcAirTerminal_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAirTerminalBox_IFC4 : IfcFlowController_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAirTerminalBox_IFC4(string line) : base(line){}
    public IfcAirTerminalBox_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAirTerminalBoxType_IFC4 : IfcFlowControllerType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAirTerminalBoxType_IFC4(string line) : base(line){}
    public IfcAirTerminalBoxType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAirTerminalType_IFC4 : IfcFlowTerminalType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAirTerminalType_IFC4(string line) : base(line){}
    public IfcAirTerminalType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAirToAirHeatRecovery_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAirToAirHeatRecovery_IFC4(string line) : base(line){}
    public IfcAirToAirHeatRecovery_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAirToAirHeatRecoveryType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAirToAirHeatRecoveryType_IFC4(string line) : base(line){}
    public IfcAirToAirHeatRecoveryType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAlarm_IFC4 : IfcDistributionControlElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAlarm_IFC4(string line) : base(line){}
    public IfcAlarm_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAlarmType_IFC4 : IfcDistributionControlElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAlarmType_IFC4(string line) : base(line){}
    public IfcAlarmType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAnnotation_IFC4 : IfcProduct_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAnnotation_IFC4(string line) : base(line){}
    public IfcAnnotation_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAnnotationFillArea_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public IfcCurve_IFC4 OuterBoundary;
    public List<IfcCurve_IFC4> InnerBoundaries;

    public new List<string> param_order = new List<string>{"OuterBoundary", "InnerBoundaries"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAnnotationFillArea_IFC4(string line) : base(line){}
    public IfcAnnotationFillArea_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcApplication_IFC4 : Entity {
    public IfcOrganization_IFC4 ApplicationDeveloper;
    public string Version;
    public string ApplicationFullName;
    public string ApplicationIdentifier;

    public new List<string> param_order = new List<string>{"ApplicationDeveloper", "Version", "ApplicationFullName", "ApplicationIdentifier"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcApplication_IFC4(string line) : base(line){}
    public IfcApplication_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAppliedValue_IFC4 : Entity {
    public string Name;
    public string Description;
    public IfcAppliedValueSelect_IFC4 AppliedValue;
    public IfcMeasureWithUnit_IFC4 UnitBasis;
    public string ApplicableDate;
    public string FixedUntilDate;
    public string Category;
    public string Condition;
    public string ArithmeticOperator;
    public List<IfcAppliedValue_IFC4> Components;

    public new List<string> param_order = new List<string>{"Name", "Description", "AppliedValue", "UnitBasis", "ApplicableDate", "FixedUntilDate", "Category", "Condition", "ArithmeticOperator", "Components"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAppliedValue_IFC4(string line) : base(line){}
    public IfcAppliedValue_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcApproval_IFC4 : Entity {
    public string Identifier;
    public string Name;
    public string Description;
    public string TimeOfApproval;
    public string Status;
    public string Level;
    public string Qualifier;
    public IfcActorSelect_IFC4 RequestingApproval;
    public IfcActorSelect_IFC4 GivingApproval;

    public new List<string> param_order = new List<string>{"Identifier", "Name", "Description", "TimeOfApproval", "Status", "Level", "Qualifier", "RequestingApproval", "GivingApproval"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcApproval_IFC4(string line) : base(line){}
    public IfcApproval_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcApprovalRelationship_IFC4 : IfcResourceLevelRelationship_IFC4 {
    public IfcApproval_IFC4 RelatingApproval;
    public List<IfcApproval_IFC4> RelatedApprovals;

    public new List<string> param_order = new List<string>{"RelatingApproval", "RelatedApprovals"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcApprovalRelationship_IFC4(string line) : base(line){}
    public IfcApprovalRelationship_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcArbitraryClosedProfileDef_IFC4 : IfcProfileDef_IFC4 {
    public IfcCurve_IFC4 OuterCurve;

    public new List<string> param_order = new List<string>{"OuterCurve"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcArbitraryClosedProfileDef_IFC4(string line) : base(line){}
    public IfcArbitraryClosedProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcArbitraryOpenProfileDef_IFC4 : IfcProfileDef_IFC4 {
    public IfcBoundedCurve_IFC4 Curve;

    public new List<string> param_order = new List<string>{"Curve"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcArbitraryOpenProfileDef_IFC4(string line) : base(line){}
    public IfcArbitraryOpenProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcArbitraryProfileDefWithVoids_IFC4 : IfcArbitraryClosedProfileDef_IFC4 {
    public List<IfcCurve_IFC4> InnerCurves;

    public new List<string> param_order = new List<string>{"InnerCurves"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcArbitraryProfileDefWithVoids_IFC4(string line) : base(line){}
    public IfcArbitraryProfileDefWithVoids_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAsset_IFC4 : IfcGroup_IFC4 {
    public string Identification;
    public IfcCostValue_IFC4 OriginalValue;
    public IfcCostValue_IFC4 CurrentValue;
    public IfcCostValue_IFC4 TotalReplacementCost;
    public IfcActorSelect_IFC4 Owner;
    public IfcActorSelect_IFC4 User;
    public IfcPerson_IFC4 ResponsiblePerson;
    public string IncorporationDate;
    public IfcCostValue_IFC4 DepreciatedValue;

    public new List<string> param_order = new List<string>{"Identification", "OriginalValue", "CurrentValue", "TotalReplacementCost", "Owner", "User", "ResponsiblePerson", "IncorporationDate", "DepreciatedValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAsset_IFC4(string line) : base(line){}
    public IfcAsset_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAsymmetricIShapeProfileDef_IFC4 : IfcParameterizedProfileDef_IFC4 {
    public string BottomFlangeWidth;
    public string OverallDepth;
    public string WebThickness;
    public string BottomFlangeThickness;
    public string BottomFlangeFilletRadius;
    public string TopFlangeWidth;
    public string TopFlangeThickness;
    public string TopFlangeFilletRadius;
    public string BottomFlangeEdgeRadius;
    public string BottomFlangeSlope;
    public string TopFlangeEdgeRadius;
    public string TopFlangeSlope;

    public new List<string> param_order = new List<string>{"BottomFlangeWidth", "OverallDepth", "WebThickness", "BottomFlangeThickness", "BottomFlangeFilletRadius", "TopFlangeWidth", "TopFlangeThickness", "TopFlangeFilletRadius", "BottomFlangeEdgeRadius", "BottomFlangeSlope", "TopFlangeEdgeRadius", "TopFlangeSlope"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAsymmetricIShapeProfileDef_IFC4(string line) : base(line){}
    public IfcAsymmetricIShapeProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAudioVisualAppliance_IFC4 : IfcFlowTerminal_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAudioVisualAppliance_IFC4(string line) : base(line){}
    public IfcAudioVisualAppliance_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAudioVisualApplianceType_IFC4 : IfcFlowTerminalType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAudioVisualApplianceType_IFC4(string line) : base(line){}
    public IfcAudioVisualApplianceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAxis1Placement_IFC4 : IfcPlacement_IFC4 {
    public IfcDirection_IFC4 Axis;

    public new List<string> param_order = new List<string>{"Axis"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAxis1Placement_IFC4(string line) : base(line){}
    public IfcAxis1Placement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAxis2Placement2D_IFC4 : IfcPlacement_IFC4 {
    public IfcDirection_IFC4 RefDirection;

    public new List<string> param_order = new List<string>{"RefDirection"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAxis2Placement2D_IFC4(string line) : base(line){}
    public IfcAxis2Placement2D_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcAxis2Placement3D_IFC4 : IfcPlacement_IFC4 {
    public IfcDirection_IFC4 Axis;
    public IfcDirection_IFC4 RefDirection;

    public new List<string> param_order = new List<string>{"Axis", "RefDirection"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcAxis2Placement3D_IFC4(string line) : base(line){}
    public IfcAxis2Placement3D_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBSplineCurve_IFC4 : IfcBoundedCurve_IFC4 {
    public string Degree;
    public List<IfcCartesianPoint_IFC4> ControlPointsList;
    public string CurveForm;
    public string ClosedCurve;
    public string SelfIntersect;

    public new List<string> param_order = new List<string>{"Degree", "ControlPointsList", "CurveForm", "ClosedCurve", "SelfIntersect"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBSplineCurve_IFC4(string line) : base(line){}
    public IfcBSplineCurve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBSplineCurveWithKnots_IFC4 : IfcBSplineCurve_IFC4 {
    public List<string> KnotMultiplicities;
    public List<string> Knots;
    public string KnotSpec;

    public new List<string> param_order = new List<string>{"KnotMultiplicities", "Knots", "KnotSpec"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBSplineCurveWithKnots_IFC4(string line) : base(line){}
    public IfcBSplineCurveWithKnots_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBSplineSurface_IFC4 : IfcBoundedSurface_IFC4 {
    public string UDegree;
    public string VDegree;
    public List<List<IfcCartesianPoint_IFC4>> ControlPointsList;
    public string SurfaceForm;
    public string UClosed;
    public string VClosed;
    public string SelfIntersect;

    public new List<string> param_order = new List<string>{"UDegree", "VDegree", "ControlPointsList", "SurfaceForm", "UClosed", "VClosed", "SelfIntersect"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBSplineSurface_IFC4(string line) : base(line){}
    public IfcBSplineSurface_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBSplineSurfaceWithKnots_IFC4 : IfcBSplineSurface_IFC4 {
    public List<string> UMultiplicities;
    public List<string> VMultiplicities;
    public List<string> UKnots;
    public List<string> VKnots;
    public string KnotSpec;

    public new List<string> param_order = new List<string>{"UMultiplicities", "VMultiplicities", "UKnots", "VKnots", "KnotSpec"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBSplineSurfaceWithKnots_IFC4(string line) : base(line){}
    public IfcBSplineSurfaceWithKnots_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBeam_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBeam_IFC4(string line) : base(line){}
    public IfcBeam_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBeamStandardCase_IFC4 : IfcBeam_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBeamStandardCase_IFC4(string line) : base(line){}
    public IfcBeamStandardCase_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBeamType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBeamType_IFC4(string line) : base(line){}
    public IfcBeamType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBlobTexture_IFC4 : IfcSurfaceTexture_IFC4 {
    public string RasterFormat;
    public string RasterCode;

    public new List<string> param_order = new List<string>{"RasterFormat", "RasterCode"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBlobTexture_IFC4(string line) : base(line){}
    public IfcBlobTexture_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBlock_IFC4 : IfcCsgPrimitive3D_IFC4 {
    public string XLength;
    public string YLength;
    public string ZLength;

    public new List<string> param_order = new List<string>{"XLength", "YLength", "ZLength"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBlock_IFC4(string line) : base(line){}
    public IfcBlock_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBoiler_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoiler_IFC4(string line) : base(line){}
    public IfcBoiler_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBoilerType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoilerType_IFC4(string line) : base(line){}
    public IfcBoilerType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBooleanClippingResult_IFC4 : IfcBooleanResult_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBooleanClippingResult_IFC4(string line) : base(line){}
    public IfcBooleanClippingResult_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBooleanResult_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public string Operator;
    public IfcBooleanOperand_IFC4 FirstOperand;
    public IfcBooleanOperand_IFC4 SecondOperand;

    public new List<string> param_order = new List<string>{"Operator", "FirstOperand", "SecondOperand"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBooleanResult_IFC4(string line) : base(line){}
    public IfcBooleanResult_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundaryCondition_IFC4 : Entity {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundaryCondition_IFC4(string line) : base(line){}
    public IfcBoundaryCondition_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundaryCurve_IFC4 : IfcCompositeCurveOnSurface_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundaryCurve_IFC4(string line) : base(line){}
    public IfcBoundaryCurve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundaryEdgeCondition_IFC4 : IfcBoundaryCondition_IFC4 {
    public IfcModulusOfTranslationalSubgradeReactionSelect_IFC4 TranslationalStiffnessByLengthX;
    public IfcModulusOfTranslationalSubgradeReactionSelect_IFC4 TranslationalStiffnessByLengthY;
    public IfcModulusOfTranslationalSubgradeReactionSelect_IFC4 TranslationalStiffnessByLengthZ;
    public IfcModulusOfRotationalSubgradeReactionSelect_IFC4 RotationalStiffnessByLengthX;
    public IfcModulusOfRotationalSubgradeReactionSelect_IFC4 RotationalStiffnessByLengthY;
    public IfcModulusOfRotationalSubgradeReactionSelect_IFC4 RotationalStiffnessByLengthZ;

    public new List<string> param_order = new List<string>{"TranslationalStiffnessByLengthX", "TranslationalStiffnessByLengthY", "TranslationalStiffnessByLengthZ", "RotationalStiffnessByLengthX", "RotationalStiffnessByLengthY", "RotationalStiffnessByLengthZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundaryEdgeCondition_IFC4(string line) : base(line){}
    public IfcBoundaryEdgeCondition_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundaryFaceCondition_IFC4 : IfcBoundaryCondition_IFC4 {
    public IfcModulusOfSubgradeReactionSelect_IFC4 TranslationalStiffnessByAreaX;
    public IfcModulusOfSubgradeReactionSelect_IFC4 TranslationalStiffnessByAreaY;
    public IfcModulusOfSubgradeReactionSelect_IFC4 TranslationalStiffnessByAreaZ;

    public new List<string> param_order = new List<string>{"TranslationalStiffnessByAreaX", "TranslationalStiffnessByAreaY", "TranslationalStiffnessByAreaZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundaryFaceCondition_IFC4(string line) : base(line){}
    public IfcBoundaryFaceCondition_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundaryNodeCondition_IFC4 : IfcBoundaryCondition_IFC4 {
    public IfcTranslationalStiffnessSelect_IFC4 TranslationalStiffnessX;
    public IfcTranslationalStiffnessSelect_IFC4 TranslationalStiffnessY;
    public IfcTranslationalStiffnessSelect_IFC4 TranslationalStiffnessZ;
    public IfcRotationalStiffnessSelect_IFC4 RotationalStiffnessX;
    public IfcRotationalStiffnessSelect_IFC4 RotationalStiffnessY;
    public IfcRotationalStiffnessSelect_IFC4 RotationalStiffnessZ;

    public new List<string> param_order = new List<string>{"TranslationalStiffnessX", "TranslationalStiffnessY", "TranslationalStiffnessZ", "RotationalStiffnessX", "RotationalStiffnessY", "RotationalStiffnessZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundaryNodeCondition_IFC4(string line) : base(line){}
    public IfcBoundaryNodeCondition_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundaryNodeConditionWarping_IFC4 : IfcBoundaryNodeCondition_IFC4 {
    public IfcWarpingStiffnessSelect_IFC4 WarpingStiffness;

    public new List<string> param_order = new List<string>{"WarpingStiffness"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundaryNodeConditionWarping_IFC4(string line) : base(line){}
    public IfcBoundaryNodeConditionWarping_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundedCurve_IFC4 : IfcCurve_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundedCurve_IFC4(string line) : base(line){}
    public IfcBoundedCurve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundedSurface_IFC4 : IfcSurface_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundedSurface_IFC4(string line) : base(line){}
    public IfcBoundedSurface_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBoundingBox_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public IfcCartesianPoint_IFC4 Corner;
    public string XDim;
    public string YDim;
    public string ZDim;

    public new List<string> param_order = new List<string>{"Corner", "XDim", "YDim", "ZDim"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoundingBox_IFC4(string line) : base(line){}
    public IfcBoundingBox_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBoxedHalfSpace_IFC4 : IfcHalfSpaceSolid_IFC4 {
    public IfcBoundingBox_IFC4 Enclosure;

    public new List<string> param_order = new List<string>{"Enclosure"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBoxedHalfSpace_IFC4(string line) : base(line){}
    public IfcBoxedHalfSpace_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBuilding_IFC4 : IfcSpatialStructureElement_IFC4 {
    public string ElevationOfRefHeight;
    public string ElevationOfTerrain;
    public IfcPostalAddress_IFC4 BuildingAddress;

    public new List<string> param_order = new List<string>{"ElevationOfRefHeight", "ElevationOfTerrain", "BuildingAddress"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuilding_IFC4(string line) : base(line){}
    public IfcBuilding_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingElement_IFC4 : IfcElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingElement_IFC4(string line) : base(line){}
    public IfcBuildingElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingElementPart_IFC4 : IfcElementComponent_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingElementPart_IFC4(string line) : base(line){}
    public IfcBuildingElementPart_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingElementPartType_IFC4 : IfcElementComponentType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingElementPartType_IFC4(string line) : base(line){}
    public IfcBuildingElementPartType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingElementProxy_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingElementProxy_IFC4(string line) : base(line){}
    public IfcBuildingElementProxy_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingElementProxyType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingElementProxyType_IFC4(string line) : base(line){}
    public IfcBuildingElementProxyType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingElementType_IFC4 : IfcElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingElementType_IFC4(string line) : base(line){}
    public IfcBuildingElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingStorey_IFC4 : IfcSpatialStructureElement_IFC4 {
    public string Elevation;

    public new List<string> param_order = new List<string>{"Elevation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingStorey_IFC4(string line) : base(line){}
    public IfcBuildingStorey_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBuildingSystem_IFC4 : IfcSystem_IFC4 {
    public string PredefinedType;
    public string LongName;

    public new List<string> param_order = new List<string>{"PredefinedType", "LongName"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBuildingSystem_IFC4(string line) : base(line){}
    public IfcBuildingSystem_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBurner_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBurner_IFC4(string line) : base(line){}
    public IfcBurner_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcBurnerType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcBurnerType_IFC4(string line) : base(line){}
    public IfcBurnerType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCShapeProfileDef_IFC4 : IfcParameterizedProfileDef_IFC4 {
    public string Depth;
    public string Width;
    public string WallThickness;
    public string Girth;
    public string InternalFilletRadius;

    public new List<string> param_order = new List<string>{"Depth", "Width", "WallThickness", "Girth", "InternalFilletRadius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCShapeProfileDef_IFC4(string line) : base(line){}
    public IfcCShapeProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCableCarrierFitting_IFC4 : IfcFlowFitting_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCableCarrierFitting_IFC4(string line) : base(line){}
    public IfcCableCarrierFitting_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCableCarrierFittingType_IFC4 : IfcFlowFittingType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCableCarrierFittingType_IFC4(string line) : base(line){}
    public IfcCableCarrierFittingType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCableCarrierSegment_IFC4 : IfcFlowSegment_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCableCarrierSegment_IFC4(string line) : base(line){}
    public IfcCableCarrierSegment_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCableCarrierSegmentType_IFC4 : IfcFlowSegmentType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCableCarrierSegmentType_IFC4(string line) : base(line){}
    public IfcCableCarrierSegmentType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCableFitting_IFC4 : IfcFlowFitting_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCableFitting_IFC4(string line) : base(line){}
    public IfcCableFitting_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCableFittingType_IFC4 : IfcFlowFittingType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCableFittingType_IFC4(string line) : base(line){}
    public IfcCableFittingType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCableSegment_IFC4 : IfcFlowSegment_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCableSegment_IFC4(string line) : base(line){}
    public IfcCableSegment_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCableSegmentType_IFC4 : IfcFlowSegmentType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCableSegmentType_IFC4(string line) : base(line){}
    public IfcCableSegmentType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianPoint_IFC4 : IfcPoint_IFC4 {
    public List<string> Coordinates;

    public new List<string> param_order = new List<string>{"Coordinates"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianPoint_IFC4(string line) : base(line){}
    public IfcCartesianPoint_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianPointList_IFC4 : IfcGeometricRepresentationItem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianPointList_IFC4(string line) : base(line){}
    public IfcCartesianPointList_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianPointList2D_IFC4 : IfcCartesianPointList_IFC4 {
    public List<List<string>> CoordList;

    public new List<string> param_order = new List<string>{"CoordList"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianPointList2D_IFC4(string line) : base(line){}
    public IfcCartesianPointList2D_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianPointList3D_IFC4 : IfcCartesianPointList_IFC4 {
    public List<List<string>> CoordList;

    public new List<string> param_order = new List<string>{"CoordList"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianPointList3D_IFC4(string line) : base(line){}
    public IfcCartesianPointList3D_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianTransformationOperator_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public IfcDirection_IFC4 Axis1;
    public IfcDirection_IFC4 Axis2;
    public IfcCartesianPoint_IFC4 LocalOrigin;
    public string Scale;

    public new List<string> param_order = new List<string>{"Axis1", "Axis2", "LocalOrigin", "Scale"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianTransformationOperator_IFC4(string line) : base(line){}
    public IfcCartesianTransformationOperator_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianTransformationOperator2D_IFC4 : IfcCartesianTransformationOperator_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianTransformationOperator2D_IFC4(string line) : base(line){}
    public IfcCartesianTransformationOperator2D_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianTransformationOperator2DnonUniform_IFC4 : IfcCartesianTransformationOperator2D_IFC4 {
    public string Scale2;

    public new List<string> param_order = new List<string>{"Scale2"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianTransformationOperator2DnonUniform_IFC4(string line) : base(line){}
    public IfcCartesianTransformationOperator2DnonUniform_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianTransformationOperator3D_IFC4 : IfcCartesianTransformationOperator_IFC4 {
    public IfcDirection_IFC4 Axis3;

    public new List<string> param_order = new List<string>{"Axis3"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianTransformationOperator3D_IFC4(string line) : base(line){}
    public IfcCartesianTransformationOperator3D_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCartesianTransformationOperator3DnonUniform_IFC4 : IfcCartesianTransformationOperator3D_IFC4 {
    public string Scale2;
    public string Scale3;

    public new List<string> param_order = new List<string>{"Scale2", "Scale3"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCartesianTransformationOperator3DnonUniform_IFC4(string line) : base(line){}
    public IfcCartesianTransformationOperator3DnonUniform_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCenterLineProfileDef_IFC4 : IfcArbitraryOpenProfileDef_IFC4 {
    public string Thickness;

    public new List<string> param_order = new List<string>{"Thickness"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCenterLineProfileDef_IFC4(string line) : base(line){}
    public IfcCenterLineProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcChiller_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcChiller_IFC4(string line) : base(line){}
    public IfcChiller_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcChillerType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcChillerType_IFC4(string line) : base(line){}
    public IfcChillerType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcChimney_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcChimney_IFC4(string line) : base(line){}
    public IfcChimney_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcChimneyType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcChimneyType_IFC4(string line) : base(line){}
    public IfcChimneyType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCircle_IFC4 : IfcConic_IFC4 {
    public string Radius;

    public new List<string> param_order = new List<string>{"Radius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCircle_IFC4(string line) : base(line){}
    public IfcCircle_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCircleHollowProfileDef_IFC4 : IfcCircleProfileDef_IFC4 {
    public string WallThickness;

    public new List<string> param_order = new List<string>{"WallThickness"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCircleHollowProfileDef_IFC4(string line) : base(line){}
    public IfcCircleHollowProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCircleProfileDef_IFC4 : IfcParameterizedProfileDef_IFC4 {
    public string Radius;

    public new List<string> param_order = new List<string>{"Radius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCircleProfileDef_IFC4(string line) : base(line){}
    public IfcCircleProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCivilElement_IFC4 : IfcElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCivilElement_IFC4(string line) : base(line){}
    public IfcCivilElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCivilElementType_IFC4 : IfcElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCivilElementType_IFC4(string line) : base(line){}
    public IfcCivilElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcClassification_IFC4 : IfcExternalInformation_IFC4 {
    public string Source;
    public string Edition;
    public string EditionDate;
    public string Name;
    public string Description;
    public string Location;
    public List<string> ReferenceTokens;

    public new List<string> param_order = new List<string>{"Source", "Edition", "EditionDate", "Name", "Description", "Location", "ReferenceTokens"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcClassification_IFC4(string line) : base(line){}
    public IfcClassification_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcClassificationReference_IFC4 : IfcExternalReference_IFC4 {
    public IfcClassificationReferenceSelect_IFC4 ReferencedSource;
    public string Description;
    public string Sort;

    public new List<string> param_order = new List<string>{"ReferencedSource", "Description", "Sort"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcClassificationReference_IFC4(string line) : base(line){}
    public IfcClassificationReference_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcClosedShell_IFC4 : IfcConnectedFaceSet_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcClosedShell_IFC4(string line) : base(line){}
    public IfcClosedShell_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCoil_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCoil_IFC4(string line) : base(line){}
    public IfcCoil_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCoilType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCoilType_IFC4(string line) : base(line){}
    public IfcCoilType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcColourRgb_IFC4 : IfcColourSpecification_IFC4 {
    public string Red;
    public string Green;
    public string Blue;

    public new List<string> param_order = new List<string>{"Red", "Green", "Blue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcColourRgb_IFC4(string line) : base(line){}
    public IfcColourRgb_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcColourRgbList_IFC4 : IfcPresentationItem_IFC4 {
    public List<List<string>> ColourList;

    public new List<string> param_order = new List<string>{"ColourList"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcColourRgbList_IFC4(string line) : base(line){}
    public IfcColourRgbList_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcColourSpecification_IFC4 : IfcPresentationItem_IFC4 {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcColourSpecification_IFC4(string line) : base(line){}
    public IfcColourSpecification_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcColumn_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcColumn_IFC4(string line) : base(line){}
    public IfcColumn_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcColumnStandardCase_IFC4 : IfcColumn_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcColumnStandardCase_IFC4(string line) : base(line){}
    public IfcColumnStandardCase_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcColumnType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcColumnType_IFC4(string line) : base(line){}
    public IfcColumnType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCommunicationsAppliance_IFC4 : IfcFlowTerminal_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCommunicationsAppliance_IFC4(string line) : base(line){}
    public IfcCommunicationsAppliance_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCommunicationsApplianceType_IFC4 : IfcFlowTerminalType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCommunicationsApplianceType_IFC4(string line) : base(line){}
    public IfcCommunicationsApplianceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcComplexProperty_IFC4 : IfcProperty_IFC4 {
    public string UsageName;
    public List<IfcProperty_IFC4> HasProperties;

    public new List<string> param_order = new List<string>{"UsageName", "HasProperties"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcComplexProperty_IFC4(string line) : base(line){}
    public IfcComplexProperty_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcComplexPropertyTemplate_IFC4 : IfcPropertyTemplate_IFC4 {
    public string UsageName;
    public string TemplateType;
    public List<IfcPropertyTemplate_IFC4> HasPropertyTemplates;

    public new List<string> param_order = new List<string>{"UsageName", "TemplateType", "HasPropertyTemplates"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcComplexPropertyTemplate_IFC4(string line) : base(line){}
    public IfcComplexPropertyTemplate_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCompositeCurve_IFC4 : IfcBoundedCurve_IFC4 {
    public List<IfcCompositeCurveSegment_IFC4> Segments;
    public string SelfIntersect;

    public new List<string> param_order = new List<string>{"Segments", "SelfIntersect"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCompositeCurve_IFC4(string line) : base(line){}
    public IfcCompositeCurve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCompositeCurveOnSurface_IFC4 : IfcCompositeCurve_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCompositeCurveOnSurface_IFC4(string line) : base(line){}
    public IfcCompositeCurveOnSurface_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCompositeCurveSegment_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public string Transition;
    public string SameSense;
    public IfcCurve_IFC4 ParentCurve;

    public new List<string> param_order = new List<string>{"Transition", "SameSense", "ParentCurve"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCompositeCurveSegment_IFC4(string line) : base(line){}
    public IfcCompositeCurveSegment_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCompositeProfileDef_IFC4 : IfcProfileDef_IFC4 {
    public List<IfcProfileDef_IFC4> Profiles;
    public string Label;

    public new List<string> param_order = new List<string>{"Profiles", "Label"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCompositeProfileDef_IFC4(string line) : base(line){}
    public IfcCompositeProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCompressor_IFC4 : IfcFlowMovingDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCompressor_IFC4(string line) : base(line){}
    public IfcCompressor_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCompressorType_IFC4 : IfcFlowMovingDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCompressorType_IFC4(string line) : base(line){}
    public IfcCompressorType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCondenser_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCondenser_IFC4(string line) : base(line){}
    public IfcCondenser_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCondenserType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCondenserType_IFC4(string line) : base(line){}
    public IfcCondenserType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConic_IFC4 : IfcCurve_IFC4 {
    public IfcAxis2Placement_IFC4 Position;

    public new List<string> param_order = new List<string>{"Position"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConic_IFC4(string line) : base(line){}
    public IfcConic_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConnectedFaceSet_IFC4 : IfcTopologicalRepresentationItem_IFC4 {
    public List<IfcFace_IFC4> CfsFaces;

    public new List<string> param_order = new List<string>{"CfsFaces"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConnectedFaceSet_IFC4(string line) : base(line){}
    public IfcConnectedFaceSet_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConnectionCurveGeometry_IFC4 : IfcConnectionGeometry_IFC4 {
    public IfcCurveOrEdgeCurve_IFC4 CurveOnRelatingElement;
    public IfcCurveOrEdgeCurve_IFC4 CurveOnRelatedElement;

    public new List<string> param_order = new List<string>{"CurveOnRelatingElement", "CurveOnRelatedElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConnectionCurveGeometry_IFC4(string line) : base(line){}
    public IfcConnectionCurveGeometry_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConnectionGeometry_IFC4 : Entity {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConnectionGeometry_IFC4(string line) : base(line){}
    public IfcConnectionGeometry_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConnectionPointEccentricity_IFC4 : IfcConnectionPointGeometry_IFC4 {
    public string EccentricityInX;
    public string EccentricityInY;
    public string EccentricityInZ;

    public new List<string> param_order = new List<string>{"EccentricityInX", "EccentricityInY", "EccentricityInZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConnectionPointEccentricity_IFC4(string line) : base(line){}
    public IfcConnectionPointEccentricity_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConnectionPointGeometry_IFC4 : IfcConnectionGeometry_IFC4 {
    public IfcPointOrVertexPoint_IFC4 PointOnRelatingElement;
    public IfcPointOrVertexPoint_IFC4 PointOnRelatedElement;

    public new List<string> param_order = new List<string>{"PointOnRelatingElement", "PointOnRelatedElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConnectionPointGeometry_IFC4(string line) : base(line){}
    public IfcConnectionPointGeometry_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConnectionSurfaceGeometry_IFC4 : IfcConnectionGeometry_IFC4 {
    public IfcSurfaceOrFaceSurface_IFC4 SurfaceOnRelatingElement;
    public IfcSurfaceOrFaceSurface_IFC4 SurfaceOnRelatedElement;

    public new List<string> param_order = new List<string>{"SurfaceOnRelatingElement", "SurfaceOnRelatedElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConnectionSurfaceGeometry_IFC4(string line) : base(line){}
    public IfcConnectionSurfaceGeometry_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConnectionVolumeGeometry_IFC4 : IfcConnectionGeometry_IFC4 {
    public IfcSolidOrShell_IFC4 VolumeOnRelatingElement;
    public IfcSolidOrShell_IFC4 VolumeOnRelatedElement;

    public new List<string> param_order = new List<string>{"VolumeOnRelatingElement", "VolumeOnRelatedElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConnectionVolumeGeometry_IFC4(string line) : base(line){}
    public IfcConnectionVolumeGeometry_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConstraint_IFC4 : Entity {
    public string Name;
    public string Description;
    public string ConstraintGrade;
    public string ConstraintSource;
    public IfcActorSelect_IFC4 CreatingActor;
    public string CreationTime;
    public string UserDefinedGrade;

    public new List<string> param_order = new List<string>{"Name", "Description", "ConstraintGrade", "ConstraintSource", "CreatingActor", "CreationTime", "UserDefinedGrade"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstraint_IFC4(string line) : base(line){}
    public IfcConstraint_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConstructionEquipmentResource_IFC4 : IfcConstructionResource_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstructionEquipmentResource_IFC4(string line) : base(line){}
    public IfcConstructionEquipmentResource_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConstructionEquipmentResourceType_IFC4 : IfcConstructionResourceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstructionEquipmentResourceType_IFC4(string line) : base(line){}
    public IfcConstructionEquipmentResourceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConstructionMaterialResource_IFC4 : IfcConstructionResource_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstructionMaterialResource_IFC4(string line) : base(line){}
    public IfcConstructionMaterialResource_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConstructionMaterialResourceType_IFC4 : IfcConstructionResourceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstructionMaterialResourceType_IFC4(string line) : base(line){}
    public IfcConstructionMaterialResourceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConstructionProductResource_IFC4 : IfcConstructionResource_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstructionProductResource_IFC4(string line) : base(line){}
    public IfcConstructionProductResource_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConstructionProductResourceType_IFC4 : IfcConstructionResourceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstructionProductResourceType_IFC4(string line) : base(line){}
    public IfcConstructionProductResourceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConstructionResource_IFC4 : IfcResource_IFC4 {
    public IfcResourceTime_IFC4 Usage;
    public List<IfcAppliedValue_IFC4> BaseCosts;
    public IfcPhysicalQuantity_IFC4 BaseQuantity;

    public new List<string> param_order = new List<string>{"Usage", "BaseCosts", "BaseQuantity"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstructionResource_IFC4(string line) : base(line){}
    public IfcConstructionResource_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConstructionResourceType_IFC4 : IfcTypeResource_IFC4 {
    public List<IfcAppliedValue_IFC4> BaseCosts;
    public IfcPhysicalQuantity_IFC4 BaseQuantity;

    public new List<string> param_order = new List<string>{"BaseCosts", "BaseQuantity"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConstructionResourceType_IFC4(string line) : base(line){}
    public IfcConstructionResourceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcContext_IFC4 : IfcObjectDefinition_IFC4 {
    public string ObjectType;
    public string LongName;
    public string Phase;
    public List<IfcRepresentationContext_IFC4> RepresentationContexts;
    public IfcUnitAssignment_IFC4 UnitsInContext;

    public new List<string> param_order = new List<string>{"ObjectType", "LongName", "Phase", "RepresentationContexts", "UnitsInContext"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcContext_IFC4(string line) : base(line){}
    public IfcContext_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcContextDependentUnit_IFC4 : IfcNamedUnit_IFC4 {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcContextDependentUnit_IFC4(string line) : base(line){}
    public IfcContextDependentUnit_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcControl_IFC4 : IfcObject_IFC4 {
    public string Identification;

    public new List<string> param_order = new List<string>{"Identification"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcControl_IFC4(string line) : base(line){}
    public IfcControl_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcController_IFC4 : IfcDistributionControlElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcController_IFC4(string line) : base(line){}
    public IfcController_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcControllerType_IFC4 : IfcDistributionControlElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcControllerType_IFC4(string line) : base(line){}
    public IfcControllerType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConversionBasedUnit_IFC4 : IfcNamedUnit_IFC4 {
    public string Name;
    public IfcMeasureWithUnit_IFC4 ConversionFactor;

    public new List<string> param_order = new List<string>{"Name", "ConversionFactor"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConversionBasedUnit_IFC4(string line) : base(line){}
    public IfcConversionBasedUnit_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcConversionBasedUnitWithOffset_IFC4 : IfcConversionBasedUnit_IFC4 {
    public string ConversionOffset;

    public new List<string> param_order = new List<string>{"ConversionOffset"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcConversionBasedUnitWithOffset_IFC4(string line) : base(line){}
    public IfcConversionBasedUnitWithOffset_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCooledBeam_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCooledBeam_IFC4(string line) : base(line){}
    public IfcCooledBeam_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCooledBeamType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCooledBeamType_IFC4(string line) : base(line){}
    public IfcCooledBeamType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCoolingTower_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCoolingTower_IFC4(string line) : base(line){}
    public IfcCoolingTower_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCoolingTowerType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCoolingTowerType_IFC4(string line) : base(line){}
    public IfcCoolingTowerType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCoordinateOperation_IFC4 : Entity {
    public IfcCoordinateReferenceSystemSelect_IFC4 SourceCRS;
    public IfcCoordinateReferenceSystem_IFC4 TargetCRS;

    public new List<string> param_order = new List<string>{"SourceCRS", "TargetCRS"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCoordinateOperation_IFC4(string line) : base(line){}
    public IfcCoordinateOperation_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCoordinateReferenceSystem_IFC4 : Entity {
    public string Name;
    public string Description;
    public string GeodeticDatum;
    public string VerticalDatum;

    public new List<string> param_order = new List<string>{"Name", "Description", "GeodeticDatum", "VerticalDatum"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCoordinateReferenceSystem_IFC4(string line) : base(line){}
    public IfcCoordinateReferenceSystem_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCostItem_IFC4 : IfcControl_IFC4 {
    public string PredefinedType;
    public List<IfcCostValue_IFC4> CostValues;
    public List<IfcPhysicalQuantity_IFC4> CostQuantities;

    public new List<string> param_order = new List<string>{"PredefinedType", "CostValues", "CostQuantities"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCostItem_IFC4(string line) : base(line){}
    public IfcCostItem_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCostSchedule_IFC4 : IfcControl_IFC4 {
    public string PredefinedType;
    public string Status;
    public string SubmittedOn;
    public string UpdateDate;

    public new List<string> param_order = new List<string>{"PredefinedType", "Status", "SubmittedOn", "UpdateDate"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCostSchedule_IFC4(string line) : base(line){}
    public IfcCostSchedule_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCostValue_IFC4 : IfcAppliedValue_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCostValue_IFC4(string line) : base(line){}
    public IfcCostValue_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCovering_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCovering_IFC4(string line) : base(line){}
    public IfcCovering_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCoveringType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCoveringType_IFC4(string line) : base(line){}
    public IfcCoveringType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCrewResource_IFC4 : IfcConstructionResource_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCrewResource_IFC4(string line) : base(line){}
    public IfcCrewResource_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCrewResourceType_IFC4 : IfcConstructionResourceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCrewResourceType_IFC4(string line) : base(line){}
    public IfcCrewResourceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCsgPrimitive3D_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public IfcAxis2Placement3D_IFC4 Position;

    public new List<string> param_order = new List<string>{"Position"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCsgPrimitive3D_IFC4(string line) : base(line){}
    public IfcCsgPrimitive3D_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCsgSolid_IFC4 : IfcSolidModel_IFC4 {
    public IfcCsgSelect_IFC4 TreeRootExpression;

    public new List<string> param_order = new List<string>{"TreeRootExpression"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCsgSolid_IFC4(string line) : base(line){}
    public IfcCsgSolid_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCurrencyRelationship_IFC4 : IfcResourceLevelRelationship_IFC4 {
    public IfcMonetaryUnit_IFC4 RelatingMonetaryUnit;
    public IfcMonetaryUnit_IFC4 RelatedMonetaryUnit;
    public string ExchangeRate;
    public string RateDateTime;
    public IfcLibraryInformation_IFC4 RateSource;

    public new List<string> param_order = new List<string>{"RelatingMonetaryUnit", "RelatedMonetaryUnit", "ExchangeRate", "RateDateTime", "RateSource"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurrencyRelationship_IFC4(string line) : base(line){}
    public IfcCurrencyRelationship_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCurtainWall_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurtainWall_IFC4(string line) : base(line){}
    public IfcCurtainWall_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCurtainWallType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurtainWallType_IFC4(string line) : base(line){}
    public IfcCurtainWallType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCurve_IFC4 : IfcGeometricRepresentationItem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurve_IFC4(string line) : base(line){}
    public IfcCurve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCurveBoundedPlane_IFC4 : IfcBoundedSurface_IFC4 {
    public IfcPlane_IFC4 BasisSurface;
    public IfcCurve_IFC4 OuterBoundary;
    public List<IfcCurve_IFC4> InnerBoundaries;

    public new List<string> param_order = new List<string>{"BasisSurface", "OuterBoundary", "InnerBoundaries"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurveBoundedPlane_IFC4(string line) : base(line){}
    public IfcCurveBoundedPlane_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCurveBoundedSurface_IFC4 : IfcBoundedSurface_IFC4 {
    public IfcSurface_IFC4 BasisSurface;
    public List<IfcBoundaryCurve_IFC4> Boundaries;
    public string ImplicitOuter;

    public new List<string> param_order = new List<string>{"BasisSurface", "Boundaries", "ImplicitOuter"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurveBoundedSurface_IFC4(string line) : base(line){}
    public IfcCurveBoundedSurface_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCurveStyle_IFC4 : IfcPresentationStyle_IFC4 {
    public IfcCurveFontOrScaledCurveFontSelect_IFC4 CurveFont;
    public IfcSizeSelect_IFC4 CurveWidth;
    public IfcColour_IFC4 CurveColour;
    public string ModelOrDraughting;

    public new List<string> param_order = new List<string>{"CurveFont", "CurveWidth", "CurveColour", "ModelOrDraughting"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurveStyle_IFC4(string line) : base(line){}
    public IfcCurveStyle_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCurveStyleFont_IFC4 : IfcPresentationItem_IFC4 {
    public string Name;
    public List<IfcCurveStyleFontPattern_IFC4> PatternList;

    public new List<string> param_order = new List<string>{"Name", "PatternList"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurveStyleFont_IFC4(string line) : base(line){}
    public IfcCurveStyleFont_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCurveStyleFontAndScaling_IFC4 : IfcPresentationItem_IFC4 {
    public string Name;
    public IfcCurveStyleFontSelect_IFC4 CurveFont;
    public string CurveFontScaling;

    public new List<string> param_order = new List<string>{"Name", "CurveFont", "CurveFontScaling"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurveStyleFontAndScaling_IFC4(string line) : base(line){}
    public IfcCurveStyleFontAndScaling_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCurveStyleFontPattern_IFC4 : IfcPresentationItem_IFC4 {
    public string VisibleSegmentLength;
    public string InvisibleSegmentLength;

    public new List<string> param_order = new List<string>{"VisibleSegmentLength", "InvisibleSegmentLength"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCurveStyleFontPattern_IFC4(string line) : base(line){}
    public IfcCurveStyleFontPattern_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcCylindricalSurface_IFC4 : IfcElementarySurface_IFC4 {
    public string Radius;

    public new List<string> param_order = new List<string>{"Radius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcCylindricalSurface_IFC4(string line) : base(line){}
    public IfcCylindricalSurface_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDamper_IFC4 : IfcFlowController_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDamper_IFC4(string line) : base(line){}
    public IfcDamper_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDamperType_IFC4 : IfcFlowControllerType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDamperType_IFC4(string line) : base(line){}
    public IfcDamperType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDerivedProfileDef_IFC4 : IfcProfileDef_IFC4 {
    public IfcProfileDef_IFC4 ParentProfile;
    public IfcCartesianTransformationOperator2D_IFC4 Operator;
    public string Label;

    public new List<string> param_order = new List<string>{"ParentProfile", "Operator", "Label"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDerivedProfileDef_IFC4(string line) : base(line){}
    public IfcDerivedProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDerivedUnit_IFC4 : Entity {
    public List<IfcDerivedUnitElement_IFC4> Elements;
    public string UnitType;
    public string UserDefinedType;

    public new List<string> param_order = new List<string>{"Elements", "UnitType", "UserDefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDerivedUnit_IFC4(string line) : base(line){}
    public IfcDerivedUnit_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDerivedUnitElement_IFC4 : Entity {
    public IfcNamedUnit_IFC4 Unit;
    public string Exponent;

    public new List<string> param_order = new List<string>{"Unit", "Exponent"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDerivedUnitElement_IFC4(string line) : base(line){}
    public IfcDerivedUnitElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDimensionalExponents_IFC4 : Entity {
    public string LengthExponent;
    public string MassExponent;
    public string TimeExponent;
    public string ElectricCurrentExponent;
    public string ThermodynamicTemperatureExponent;
    public string AmountOfSubstanceExponent;
    public string LuminousIntensityExponent;

    public new List<string> param_order = new List<string>{"LengthExponent", "MassExponent", "TimeExponent", "ElectricCurrentExponent", "ThermodynamicTemperatureExponent", "AmountOfSubstanceExponent", "LuminousIntensityExponent"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDimensionalExponents_IFC4(string line) : base(line){}
    public IfcDimensionalExponents_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDirection_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public List<string> DirectionRatios;

    public new List<string> param_order = new List<string>{"DirectionRatios"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDirection_IFC4(string line) : base(line){}
    public IfcDirection_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDiscreteAccessory_IFC4 : IfcElementComponent_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDiscreteAccessory_IFC4(string line) : base(line){}
    public IfcDiscreteAccessory_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDiscreteAccessoryType_IFC4 : IfcElementComponentType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDiscreteAccessoryType_IFC4(string line) : base(line){}
    public IfcDiscreteAccessoryType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionChamberElement_IFC4 : IfcDistributionFlowElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionChamberElement_IFC4(string line) : base(line){}
    public IfcDistributionChamberElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionChamberElementType_IFC4 : IfcDistributionFlowElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionChamberElementType_IFC4(string line) : base(line){}
    public IfcDistributionChamberElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionCircuit_IFC4 : IfcDistributionSystem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionCircuit_IFC4(string line) : base(line){}
    public IfcDistributionCircuit_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionControlElement_IFC4 : IfcDistributionElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionControlElement_IFC4(string line) : base(line){}
    public IfcDistributionControlElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionControlElementType_IFC4 : IfcDistributionElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionControlElementType_IFC4(string line) : base(line){}
    public IfcDistributionControlElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionElement_IFC4 : IfcElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionElement_IFC4(string line) : base(line){}
    public IfcDistributionElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionElementType_IFC4 : IfcElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionElementType_IFC4(string line) : base(line){}
    public IfcDistributionElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionFlowElement_IFC4 : IfcDistributionElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionFlowElement_IFC4(string line) : base(line){}
    public IfcDistributionFlowElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionFlowElementType_IFC4 : IfcDistributionElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionFlowElementType_IFC4(string line) : base(line){}
    public IfcDistributionFlowElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionPort_IFC4 : IfcPort_IFC4 {
    public string FlowDirection;
    public string PredefinedType;
    public string SystemType;

    public new List<string> param_order = new List<string>{"FlowDirection", "PredefinedType", "SystemType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionPort_IFC4(string line) : base(line){}
    public IfcDistributionPort_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDistributionSystem_IFC4 : IfcSystem_IFC4 {
    public string LongName;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"LongName", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDistributionSystem_IFC4(string line) : base(line){}
    public IfcDistributionSystem_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDocumentInformation_IFC4 : IfcExternalInformation_IFC4 {
    public string Identification;
    public string Name;
    public string Description;
    public string Location;
    public string Purpose;
    public string IntendedUse;
    public string Scope;
    public string Revision;
    public IfcActorSelect_IFC4 DocumentOwner;
    public List<IfcActorSelect_IFC4> Editors;
    public string CreationTime;
    public string LastRevisionTime;
    public string ElectronicFormat;
    public string ValidFrom;
    public string ValidUntil;
    public string Confidentiality;
    public string Status;

    public new List<string> param_order = new List<string>{"Identification", "Name", "Description", "Location", "Purpose", "IntendedUse", "Scope", "Revision", "DocumentOwner", "Editors", "CreationTime", "LastRevisionTime", "ElectronicFormat", "ValidFrom", "ValidUntil", "Confidentiality", "Status"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDocumentInformation_IFC4(string line) : base(line){}
    public IfcDocumentInformation_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDocumentInformationRelationship_IFC4 : IfcResourceLevelRelationship_IFC4 {
    public IfcDocumentInformation_IFC4 RelatingDocument;
    public List<IfcDocumentInformation_IFC4> RelatedDocuments;
    public string RelationshipType;

    public new List<string> param_order = new List<string>{"RelatingDocument", "RelatedDocuments", "RelationshipType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDocumentInformationRelationship_IFC4(string line) : base(line){}
    public IfcDocumentInformationRelationship_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDocumentReference_IFC4 : IfcExternalReference_IFC4 {
    public string Description;
    public IfcDocumentInformation_IFC4 ReferencedDocument;

    public new List<string> param_order = new List<string>{"Description", "ReferencedDocument"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDocumentReference_IFC4(string line) : base(line){}
    public IfcDocumentReference_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDoor_IFC4 : IfcBuildingElement_IFC4 {
    public string OverallHeight;
    public string OverallWidth;
    public string PredefinedType;
    public string OperationType;
    public string UserDefinedOperationType;

    public new List<string> param_order = new List<string>{"OverallHeight", "OverallWidth", "PredefinedType", "OperationType", "UserDefinedOperationType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDoor_IFC4(string line) : base(line){}
    public IfcDoor_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDoorLiningProperties_IFC4 : IfcPreDefinedPropertySet_IFC4 {
    public string LiningDepth;
    public string LiningThickness;
    public string ThresholdDepth;
    public string ThresholdThickness;
    public string TransomThickness;
    public string TransomOffset;
    public string LiningOffset;
    public string ThresholdOffset;
    public string CasingThickness;
    public string CasingDepth;
    public IfcShapeAspect_IFC4 ShapeAspectStyle;
    public string LiningToPanelOffsetX;
    public string LiningToPanelOffsetY;

    public new List<string> param_order = new List<string>{"LiningDepth", "LiningThickness", "ThresholdDepth", "ThresholdThickness", "TransomThickness", "TransomOffset", "LiningOffset", "ThresholdOffset", "CasingThickness", "CasingDepth", "ShapeAspectStyle", "LiningToPanelOffsetX", "LiningToPanelOffsetY"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDoorLiningProperties_IFC4(string line) : base(line){}
    public IfcDoorLiningProperties_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDoorPanelProperties_IFC4 : IfcPreDefinedPropertySet_IFC4 {
    public string PanelDepth;
    public string PanelOperation;
    public string PanelWidth;
    public string PanelPosition;
    public IfcShapeAspect_IFC4 ShapeAspectStyle;

    public new List<string> param_order = new List<string>{"PanelDepth", "PanelOperation", "PanelWidth", "PanelPosition", "ShapeAspectStyle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDoorPanelProperties_IFC4(string line) : base(line){}
    public IfcDoorPanelProperties_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDoorStandardCase_IFC4 : IfcDoor_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDoorStandardCase_IFC4(string line) : base(line){}
    public IfcDoorStandardCase_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDoorStyle_IFC4 : IfcTypeProduct_IFC4 {
    public string OperationType;
    public string ConstructionType;
    public string ParameterTakesPrecedence;
    public string Sizeable;

    public new List<string> param_order = new List<string>{"OperationType", "ConstructionType", "ParameterTakesPrecedence", "Sizeable"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDoorStyle_IFC4(string line) : base(line){}
    public IfcDoorStyle_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDoorType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;
    public string OperationType;
    public string ParameterTakesPrecedence;
    public string UserDefinedOperationType;

    public new List<string> param_order = new List<string>{"PredefinedType", "OperationType", "ParameterTakesPrecedence", "UserDefinedOperationType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDoorType_IFC4(string line) : base(line){}
    public IfcDoorType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDraughtingPreDefinedColour_IFC4 : IfcPreDefinedColour_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDraughtingPreDefinedColour_IFC4(string line) : base(line){}
    public IfcDraughtingPreDefinedColour_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDraughtingPreDefinedCurveFont_IFC4 : IfcPreDefinedCurveFont_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDraughtingPreDefinedCurveFont_IFC4(string line) : base(line){}
    public IfcDraughtingPreDefinedCurveFont_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDuctFitting_IFC4 : IfcFlowFitting_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDuctFitting_IFC4(string line) : base(line){}
    public IfcDuctFitting_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDuctFittingType_IFC4 : IfcFlowFittingType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDuctFittingType_IFC4(string line) : base(line){}
    public IfcDuctFittingType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDuctSegment_IFC4 : IfcFlowSegment_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDuctSegment_IFC4(string line) : base(line){}
    public IfcDuctSegment_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDuctSegmentType_IFC4 : IfcFlowSegmentType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDuctSegmentType_IFC4(string line) : base(line){}
    public IfcDuctSegmentType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDuctSilencer_IFC4 : IfcFlowTreatmentDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDuctSilencer_IFC4(string line) : base(line){}
    public IfcDuctSilencer_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcDuctSilencerType_IFC4 : IfcFlowTreatmentDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcDuctSilencerType_IFC4(string line) : base(line){}
    public IfcDuctSilencerType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEdge_IFC4 : IfcTopologicalRepresentationItem_IFC4 {
    public IfcVertex_IFC4 EdgeStart;
    public IfcVertex_IFC4 EdgeEnd;

    public new List<string> param_order = new List<string>{"EdgeStart", "EdgeEnd"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEdge_IFC4(string line) : base(line){}
    public IfcEdge_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEdgeCurve_IFC4 : IfcEdge_IFC4 {
    public IfcCurve_IFC4 EdgeGeometry;
    public string SameSense;

    public new List<string> param_order = new List<string>{"EdgeGeometry", "SameSense"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEdgeCurve_IFC4(string line) : base(line){}
    public IfcEdgeCurve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEdgeLoop_IFC4 : IfcLoop_IFC4 {
    public List<IfcOrientedEdge_IFC4> EdgeList;

    public new List<string> param_order = new List<string>{"EdgeList"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEdgeLoop_IFC4(string line) : base(line){}
    public IfcEdgeLoop_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricAppliance_IFC4 : IfcFlowTerminal_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricAppliance_IFC4(string line) : base(line){}
    public IfcElectricAppliance_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricApplianceType_IFC4 : IfcFlowTerminalType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricApplianceType_IFC4(string line) : base(line){}
    public IfcElectricApplianceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricDistributionBoard_IFC4 : IfcFlowController_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricDistributionBoard_IFC4(string line) : base(line){}
    public IfcElectricDistributionBoard_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricDistributionBoardType_IFC4 : IfcFlowControllerType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricDistributionBoardType_IFC4(string line) : base(line){}
    public IfcElectricDistributionBoardType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricFlowStorageDevice_IFC4 : IfcFlowStorageDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricFlowStorageDevice_IFC4(string line) : base(line){}
    public IfcElectricFlowStorageDevice_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricFlowStorageDeviceType_IFC4 : IfcFlowStorageDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricFlowStorageDeviceType_IFC4(string line) : base(line){}
    public IfcElectricFlowStorageDeviceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricGenerator_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricGenerator_IFC4(string line) : base(line){}
    public IfcElectricGenerator_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricGeneratorType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricGeneratorType_IFC4(string line) : base(line){}
    public IfcElectricGeneratorType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricMotor_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricMotor_IFC4(string line) : base(line){}
    public IfcElectricMotor_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricMotorType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricMotorType_IFC4(string line) : base(line){}
    public IfcElectricMotorType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricTimeControl_IFC4 : IfcFlowController_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricTimeControl_IFC4(string line) : base(line){}
    public IfcElectricTimeControl_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElectricTimeControlType_IFC4 : IfcFlowControllerType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElectricTimeControlType_IFC4(string line) : base(line){}
    public IfcElectricTimeControlType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElement_IFC4 : IfcProduct_IFC4 {
    public string Tag;

    public new List<string> param_order = new List<string>{"Tag"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElement_IFC4(string line) : base(line){}
    public IfcElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElementAssembly_IFC4 : IfcElement_IFC4 {
    public string AssemblyPlace;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"AssemblyPlace", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElementAssembly_IFC4(string line) : base(line){}
    public IfcElementAssembly_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElementAssemblyType_IFC4 : IfcElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElementAssemblyType_IFC4(string line) : base(line){}
    public IfcElementAssemblyType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElementComponent_IFC4 : IfcElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElementComponent_IFC4(string line) : base(line){}
    public IfcElementComponent_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElementComponentType_IFC4 : IfcElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElementComponentType_IFC4(string line) : base(line){}
    public IfcElementComponentType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElementQuantity_IFC4 : IfcQuantitySet_IFC4 {
    public string MethodOfMeasurement;
    public List<IfcPhysicalQuantity_IFC4> Quantities;

    public new List<string> param_order = new List<string>{"MethodOfMeasurement", "Quantities"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElementQuantity_IFC4(string line) : base(line){}
    public IfcElementQuantity_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElementType_IFC4 : IfcTypeProduct_IFC4 {
    public string ElementType;

    public new List<string> param_order = new List<string>{"ElementType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElementType_IFC4(string line) : base(line){}
    public IfcElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcElementarySurface_IFC4 : IfcSurface_IFC4 {
    public IfcAxis2Placement3D_IFC4 Position;

    public new List<string> param_order = new List<string>{"Position"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcElementarySurface_IFC4(string line) : base(line){}
    public IfcElementarySurface_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEllipse_IFC4 : IfcConic_IFC4 {
    public string SemiAxis1;
    public string SemiAxis2;

    public new List<string> param_order = new List<string>{"SemiAxis1", "SemiAxis2"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEllipse_IFC4(string line) : base(line){}
    public IfcEllipse_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEllipseProfileDef_IFC4 : IfcParameterizedProfileDef_IFC4 {
    public string SemiAxis1;
    public string SemiAxis2;

    public new List<string> param_order = new List<string>{"SemiAxis1", "SemiAxis2"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEllipseProfileDef_IFC4(string line) : base(line){}
    public IfcEllipseProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEnergyConversionDevice_IFC4 : IfcDistributionFlowElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEnergyConversionDevice_IFC4(string line) : base(line){}
    public IfcEnergyConversionDevice_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEnergyConversionDeviceType_IFC4 : IfcDistributionFlowElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEnergyConversionDeviceType_IFC4(string line) : base(line){}
    public IfcEnergyConversionDeviceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEngine_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEngine_IFC4(string line) : base(line){}
    public IfcEngine_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEngineType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEngineType_IFC4(string line) : base(line){}
    public IfcEngineType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEvaporativeCooler_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEvaporativeCooler_IFC4(string line) : base(line){}
    public IfcEvaporativeCooler_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEvaporativeCoolerType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEvaporativeCoolerType_IFC4(string line) : base(line){}
    public IfcEvaporativeCoolerType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEvaporator_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEvaporator_IFC4(string line) : base(line){}
    public IfcEvaporator_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEvaporatorType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEvaporatorType_IFC4(string line) : base(line){}
    public IfcEvaporatorType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEvent_IFC4 : IfcProcess_IFC4 {
    public string PredefinedType;
    public string EventTriggerType;
    public string UserDefinedEventTriggerType;
    public IfcEventTime_IFC4 EventOccurenceTime;

    public new List<string> param_order = new List<string>{"PredefinedType", "EventTriggerType", "UserDefinedEventTriggerType", "EventOccurenceTime"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEvent_IFC4(string line) : base(line){}
    public IfcEvent_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEventTime_IFC4 : IfcSchedulingTime_IFC4 {
    public string ActualDate;
    public string EarlyDate;
    public string LateDate;
    public string ScheduleDate;

    public new List<string> param_order = new List<string>{"ActualDate", "EarlyDate", "LateDate", "ScheduleDate"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEventTime_IFC4(string line) : base(line){}
    public IfcEventTime_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcEventType_IFC4 : IfcTypeProcess_IFC4 {
    public string PredefinedType;
    public string EventTriggerType;
    public string UserDefinedEventTriggerType;

    public new List<string> param_order = new List<string>{"PredefinedType", "EventTriggerType", "UserDefinedEventTriggerType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcEventType_IFC4(string line) : base(line){}
    public IfcEventType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcExtendedProperties_IFC4 : IfcPropertyAbstraction_IFC4 {
    public string Name;
    public string Description;
    public List<IfcProperty_IFC4> Properties;

    public new List<string> param_order = new List<string>{"Name", "Description", "Properties"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExtendedProperties_IFC4(string line) : base(line){}
    public IfcExtendedProperties_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcExternalInformation_IFC4 : Entity {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExternalInformation_IFC4(string line) : base(line){}
    public IfcExternalInformation_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcExternalReference_IFC4 : Entity {
    public string Location;
    public string Identification;
    public string Name;

    public new List<string> param_order = new List<string>{"Location", "Identification", "Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExternalReference_IFC4(string line) : base(line){}
    public IfcExternalReference_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcExternalReferenceRelationship_IFC4 : IfcResourceLevelRelationship_IFC4 {
    public IfcExternalReference_IFC4 RelatingReference;
    public List<IfcResourceObjectSelect_IFC4> RelatedResourceObjects;

    public new List<string> param_order = new List<string>{"RelatingReference", "RelatedResourceObjects"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExternalReferenceRelationship_IFC4(string line) : base(line){}
    public IfcExternalReferenceRelationship_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcExternalSpatialElement_IFC4 : IfcExternalSpatialStructureElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExternalSpatialElement_IFC4(string line) : base(line){}
    public IfcExternalSpatialElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcExternalSpatialStructureElement_IFC4 : IfcSpatialElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExternalSpatialStructureElement_IFC4(string line) : base(line){}
    public IfcExternalSpatialStructureElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcExternallyDefinedHatchStyle_IFC4 : IfcExternalReference_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExternallyDefinedHatchStyle_IFC4(string line) : base(line){}
    public IfcExternallyDefinedHatchStyle_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcExternallyDefinedSurfaceStyle_IFC4 : IfcExternalReference_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExternallyDefinedSurfaceStyle_IFC4(string line) : base(line){}
    public IfcExternallyDefinedSurfaceStyle_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcExternallyDefinedTextFont_IFC4 : IfcExternalReference_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExternallyDefinedTextFont_IFC4(string line) : base(line){}
    public IfcExternallyDefinedTextFont_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcExtrudedAreaSolid_IFC4 : IfcSweptAreaSolid_IFC4 {
    public IfcDirection_IFC4 ExtrudedDirection;
    public string Depth;

    public new List<string> param_order = new List<string>{"ExtrudedDirection", "Depth"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExtrudedAreaSolid_IFC4(string line) : base(line){}
    public IfcExtrudedAreaSolid_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcExtrudedAreaSolidTapered_IFC4 : IfcExtrudedAreaSolid_IFC4 {
    public IfcProfileDef_IFC4 EndSweptArea;

    public new List<string> param_order = new List<string>{"EndSweptArea"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcExtrudedAreaSolidTapered_IFC4(string line) : base(line){}
    public IfcExtrudedAreaSolidTapered_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFace_IFC4 : IfcTopologicalRepresentationItem_IFC4 {
    public List<IfcFaceBound_IFC4> Bounds;

    public new List<string> param_order = new List<string>{"Bounds"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFace_IFC4(string line) : base(line){}
    public IfcFace_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFaceBasedSurfaceModel_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public List<IfcConnectedFaceSet_IFC4> FbsmFaces;

    public new List<string> param_order = new List<string>{"FbsmFaces"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFaceBasedSurfaceModel_IFC4(string line) : base(line){}
    public IfcFaceBasedSurfaceModel_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFaceBound_IFC4 : IfcTopologicalRepresentationItem_IFC4 {
    public IfcLoop_IFC4 Bound;
    public string Orientation;

    public new List<string> param_order = new List<string>{"Bound", "Orientation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFaceBound_IFC4(string line) : base(line){}
    public IfcFaceBound_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFaceOuterBound_IFC4 : IfcFaceBound_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFaceOuterBound_IFC4(string line) : base(line){}
    public IfcFaceOuterBound_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFaceSurface_IFC4 : IfcFace_IFC4 {
    public IfcSurface_IFC4 FaceSurface;
    public string SameSense;

    public new List<string> param_order = new List<string>{"FaceSurface", "SameSense"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFaceSurface_IFC4(string line) : base(line){}
    public IfcFaceSurface_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFacetedBrep_IFC4 : IfcManifoldSolidBrep_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFacetedBrep_IFC4(string line) : base(line){}
    public IfcFacetedBrep_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFacetedBrepWithVoids_IFC4 : IfcFacetedBrep_IFC4 {
    public List<IfcClosedShell_IFC4> Voids;

    public new List<string> param_order = new List<string>{"Voids"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFacetedBrepWithVoids_IFC4(string line) : base(line){}
    public IfcFacetedBrepWithVoids_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFailureConnectionCondition_IFC4 : IfcStructuralConnectionCondition_IFC4 {
    public string TensionFailureX;
    public string TensionFailureY;
    public string TensionFailureZ;
    public string CompressionFailureX;
    public string CompressionFailureY;
    public string CompressionFailureZ;

    public new List<string> param_order = new List<string>{"TensionFailureX", "TensionFailureY", "TensionFailureZ", "CompressionFailureX", "CompressionFailureY", "CompressionFailureZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFailureConnectionCondition_IFC4(string line) : base(line){}
    public IfcFailureConnectionCondition_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFan_IFC4 : IfcFlowMovingDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFan_IFC4(string line) : base(line){}
    public IfcFan_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFanType_IFC4 : IfcFlowMovingDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFanType_IFC4(string line) : base(line){}
    public IfcFanType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFastener_IFC4 : IfcElementComponent_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFastener_IFC4(string line) : base(line){}
    public IfcFastener_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFastenerType_IFC4 : IfcElementComponentType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFastenerType_IFC4(string line) : base(line){}
    public IfcFastenerType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFeatureElement_IFC4 : IfcElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFeatureElement_IFC4(string line) : base(line){}
    public IfcFeatureElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFeatureElementAddition_IFC4 : IfcFeatureElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFeatureElementAddition_IFC4(string line) : base(line){}
    public IfcFeatureElementAddition_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFeatureElementSubtraction_IFC4 : IfcFeatureElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFeatureElementSubtraction_IFC4(string line) : base(line){}
    public IfcFeatureElementSubtraction_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFillAreaStyle_IFC4 : IfcPresentationStyle_IFC4 {
    public List<IfcFillStyleSelect_IFC4> FillStyles;
    public string ModelorDraughting;

    public new List<string> param_order = new List<string>{"FillStyles", "ModelorDraughting"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFillAreaStyle_IFC4(string line) : base(line){}
    public IfcFillAreaStyle_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFillAreaStyleHatching_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public IfcCurveStyle_IFC4 HatchLineAppearance;
    public IfcHatchLineDistanceSelect_IFC4 StartOfNextHatchLine;
    public IfcCartesianPoint_IFC4 PointOfReferenceHatchLine;
    public IfcCartesianPoint_IFC4 PatternStart;
    public string HatchLineAngle;

    public new List<string> param_order = new List<string>{"HatchLineAppearance", "StartOfNextHatchLine", "PointOfReferenceHatchLine", "PatternStart", "HatchLineAngle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFillAreaStyleHatching_IFC4(string line) : base(line){}
    public IfcFillAreaStyleHatching_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFillAreaStyleTiles_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public List<IfcVector_IFC4> TilingPattern;
    public List<IfcStyledItem_IFC4> Tiles;
    public string TilingScale;

    public new List<string> param_order = new List<string>{"TilingPattern", "Tiles", "TilingScale"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFillAreaStyleTiles_IFC4(string line) : base(line){}
    public IfcFillAreaStyleTiles_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFilter_IFC4 : IfcFlowTreatmentDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFilter_IFC4(string line) : base(line){}
    public IfcFilter_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFilterType_IFC4 : IfcFlowTreatmentDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFilterType_IFC4(string line) : base(line){}
    public IfcFilterType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFireSuppressionTerminal_IFC4 : IfcFlowTerminal_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFireSuppressionTerminal_IFC4(string line) : base(line){}
    public IfcFireSuppressionTerminal_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFireSuppressionTerminalType_IFC4 : IfcFlowTerminalType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFireSuppressionTerminalType_IFC4(string line) : base(line){}
    public IfcFireSuppressionTerminalType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFixedReferenceSweptAreaSolid_IFC4 : IfcSweptAreaSolid_IFC4 {
    public IfcCurve_IFC4 Directrix;
    public string StartParam;
    public string EndParam;
    public IfcDirection_IFC4 FixedReference;

    public new List<string> param_order = new List<string>{"Directrix", "StartParam", "EndParam", "FixedReference"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFixedReferenceSweptAreaSolid_IFC4(string line) : base(line){}
    public IfcFixedReferenceSweptAreaSolid_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowController_IFC4 : IfcDistributionFlowElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowController_IFC4(string line) : base(line){}
    public IfcFlowController_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowControllerType_IFC4 : IfcDistributionFlowElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowControllerType_IFC4(string line) : base(line){}
    public IfcFlowControllerType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowFitting_IFC4 : IfcDistributionFlowElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowFitting_IFC4(string line) : base(line){}
    public IfcFlowFitting_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowFittingType_IFC4 : IfcDistributionFlowElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowFittingType_IFC4(string line) : base(line){}
    public IfcFlowFittingType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowInstrument_IFC4 : IfcDistributionControlElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowInstrument_IFC4(string line) : base(line){}
    public IfcFlowInstrument_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowInstrumentType_IFC4 : IfcDistributionControlElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowInstrumentType_IFC4(string line) : base(line){}
    public IfcFlowInstrumentType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowMeter_IFC4 : IfcFlowController_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowMeter_IFC4(string line) : base(line){}
    public IfcFlowMeter_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowMeterType_IFC4 : IfcFlowControllerType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowMeterType_IFC4(string line) : base(line){}
    public IfcFlowMeterType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowMovingDevice_IFC4 : IfcDistributionFlowElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowMovingDevice_IFC4(string line) : base(line){}
    public IfcFlowMovingDevice_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowMovingDeviceType_IFC4 : IfcDistributionFlowElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowMovingDeviceType_IFC4(string line) : base(line){}
    public IfcFlowMovingDeviceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowSegment_IFC4 : IfcDistributionFlowElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowSegment_IFC4(string line) : base(line){}
    public IfcFlowSegment_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowSegmentType_IFC4 : IfcDistributionFlowElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowSegmentType_IFC4(string line) : base(line){}
    public IfcFlowSegmentType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowStorageDevice_IFC4 : IfcDistributionFlowElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowStorageDevice_IFC4(string line) : base(line){}
    public IfcFlowStorageDevice_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowStorageDeviceType_IFC4 : IfcDistributionFlowElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowStorageDeviceType_IFC4(string line) : base(line){}
    public IfcFlowStorageDeviceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowTerminal_IFC4 : IfcDistributionFlowElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowTerminal_IFC4(string line) : base(line){}
    public IfcFlowTerminal_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowTerminalType_IFC4 : IfcDistributionFlowElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowTerminalType_IFC4(string line) : base(line){}
    public IfcFlowTerminalType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowTreatmentDevice_IFC4 : IfcDistributionFlowElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowTreatmentDevice_IFC4(string line) : base(line){}
    public IfcFlowTreatmentDevice_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFlowTreatmentDeviceType_IFC4 : IfcDistributionFlowElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFlowTreatmentDeviceType_IFC4(string line) : base(line){}
    public IfcFlowTreatmentDeviceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFooting_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFooting_IFC4(string line) : base(line){}
    public IfcFooting_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFootingType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFootingType_IFC4(string line) : base(line){}
    public IfcFootingType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFurnishingElement_IFC4 : IfcElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFurnishingElement_IFC4(string line) : base(line){}
    public IfcFurnishingElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFurnishingElementType_IFC4 : IfcElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFurnishingElementType_IFC4(string line) : base(line){}
    public IfcFurnishingElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFurniture_IFC4 : IfcFurnishingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFurniture_IFC4(string line) : base(line){}
    public IfcFurniture_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcFurnitureType_IFC4 : IfcFurnishingElementType_IFC4 {
    public string AssemblyPlace;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"AssemblyPlace", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcFurnitureType_IFC4(string line) : base(line){}
    public IfcFurnitureType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcGeographicElement_IFC4 : IfcElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGeographicElement_IFC4(string line) : base(line){}
    public IfcGeographicElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcGeographicElementType_IFC4 : IfcElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGeographicElementType_IFC4(string line) : base(line){}
    public IfcGeographicElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcGeometricCurveSet_IFC4 : IfcGeometricSet_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGeometricCurveSet_IFC4(string line) : base(line){}
    public IfcGeometricCurveSet_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcGeometricRepresentationContext_IFC4 : IfcRepresentationContext_IFC4 {
    public string CoordinateSpaceDimension;
    public string Precision;
    public IfcAxis2Placement_IFC4 WorldCoordinateSystem;
    public IfcDirection_IFC4 TrueNorth;

    public new List<string> param_order = new List<string>{"CoordinateSpaceDimension", "Precision", "WorldCoordinateSystem", "TrueNorth"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGeometricRepresentationContext_IFC4(string line) : base(line){}
    public IfcGeometricRepresentationContext_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcGeometricRepresentationItem_IFC4 : IfcRepresentationItem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGeometricRepresentationItem_IFC4(string line) : base(line){}
    public IfcGeometricRepresentationItem_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcGeometricRepresentationSubContext_IFC4 : IfcGeometricRepresentationContext_IFC4 {
    public IfcGeometricRepresentationContext_IFC4 ParentContext;
    public string TargetScale;
    public string TargetView;
    public string UserDefinedTargetView;

    public new List<string> param_order = new List<string>{"ParentContext", "TargetScale", "TargetView", "UserDefinedTargetView"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGeometricRepresentationSubContext_IFC4(string line) : base(line){}
    public IfcGeometricRepresentationSubContext_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcGeometricSet_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public List<IfcGeometricSetSelect_IFC4> Elements;

    public new List<string> param_order = new List<string>{"Elements"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGeometricSet_IFC4(string line) : base(line){}
    public IfcGeometricSet_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcGrid_IFC4 : IfcProduct_IFC4 {
    public List<IfcGridAxis_IFC4> UAxes;
    public List<IfcGridAxis_IFC4> VAxes;
    public List<IfcGridAxis_IFC4> WAxes;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"UAxes", "VAxes", "WAxes", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGrid_IFC4(string line) : base(line){}
    public IfcGrid_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcGridAxis_IFC4 : Entity {
    public string AxisTag;
    public IfcCurve_IFC4 AxisCurve;
    public string SameSense;

    public new List<string> param_order = new List<string>{"AxisTag", "AxisCurve", "SameSense"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGridAxis_IFC4(string line) : base(line){}
    public IfcGridAxis_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcGridPlacement_IFC4 : IfcObjectPlacement_IFC4 {
    public IfcVirtualGridIntersection_IFC4 PlacementLocation;
    public IfcGridPlacementDirectionSelect_IFC4 PlacementRefDirection;

    public new List<string> param_order = new List<string>{"PlacementLocation", "PlacementRefDirection"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGridPlacement_IFC4(string line) : base(line){}
    public IfcGridPlacement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcGroup_IFC4 : IfcObject_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcGroup_IFC4(string line) : base(line){}
    public IfcGroup_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcHalfSpaceSolid_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public IfcSurface_IFC4 BaseSurface;
    public string AgreementFlag;

    public new List<string> param_order = new List<string>{"BaseSurface", "AgreementFlag"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcHalfSpaceSolid_IFC4(string line) : base(line){}
    public IfcHalfSpaceSolid_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcHeatExchanger_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcHeatExchanger_IFC4(string line) : base(line){}
    public IfcHeatExchanger_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcHeatExchangerType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcHeatExchangerType_IFC4(string line) : base(line){}
    public IfcHeatExchangerType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcHumidifier_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcHumidifier_IFC4(string line) : base(line){}
    public IfcHumidifier_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcHumidifierType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcHumidifierType_IFC4(string line) : base(line){}
    public IfcHumidifierType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcIShapeProfileDef_IFC4 : IfcParameterizedProfileDef_IFC4 {
    public string OverallWidth;
    public string OverallDepth;
    public string WebThickness;
    public string FlangeThickness;
    public string FilletRadius;
    public string FlangeEdgeRadius;
    public string FlangeSlope;

    public new List<string> param_order = new List<string>{"OverallWidth", "OverallDepth", "WebThickness", "FlangeThickness", "FilletRadius", "FlangeEdgeRadius", "FlangeSlope"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcIShapeProfileDef_IFC4(string line) : base(line){}
    public IfcIShapeProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcImageTexture_IFC4 : IfcSurfaceTexture_IFC4 {
    public string URLReference;

    public new List<string> param_order = new List<string>{"URLReference"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcImageTexture_IFC4(string line) : base(line){}
    public IfcImageTexture_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcIndexedColourMap_IFC4 : IfcPresentationItem_IFC4 {
    public IfcTessellatedFaceSet_IFC4 MappedTo;
    public string Opacity;
    public IfcColourRgbList_IFC4 Colours;
    public List<string> ColourIndex;

    public new List<string> param_order = new List<string>{"MappedTo", "Opacity", "Colours", "ColourIndex"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcIndexedColourMap_IFC4(string line) : base(line){}
    public IfcIndexedColourMap_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcIndexedPolyCurve_IFC4 : IfcBoundedCurve_IFC4 {
    public IfcCartesianPointList_IFC4 Points;
    public List<IfcSegmentIndexSelect_IFC4> Segments;
    public string SelfIntersect;

    public new List<string> param_order = new List<string>{"Points", "Segments", "SelfIntersect"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcIndexedPolyCurve_IFC4(string line) : base(line){}
    public IfcIndexedPolyCurve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcIndexedPolygonalFace_IFC4 : IfcTessellatedItem_IFC4 {
    public List<string> CoordIndex;

    public new List<string> param_order = new List<string>{"CoordIndex"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcIndexedPolygonalFace_IFC4(string line) : base(line){}
    public IfcIndexedPolygonalFace_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcIndexedPolygonalFaceWithVoids_IFC4 : IfcIndexedPolygonalFace_IFC4 {
    public List<List<string>> InnerCoordIndices;

    public new List<string> param_order = new List<string>{"InnerCoordIndices"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcIndexedPolygonalFaceWithVoids_IFC4(string line) : base(line){}
    public IfcIndexedPolygonalFaceWithVoids_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcIndexedTextureMap_IFC4 : IfcTextureCoordinate_IFC4 {
    public IfcTessellatedFaceSet_IFC4 MappedTo;
    public IfcTextureVertexList_IFC4 TexCoords;

    public new List<string> param_order = new List<string>{"MappedTo", "TexCoords"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcIndexedTextureMap_IFC4(string line) : base(line){}
    public IfcIndexedTextureMap_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcIndexedTriangleTextureMap_IFC4 : IfcIndexedTextureMap_IFC4 {
    public List<List<string>> TexCoordIndex;

    public new List<string> param_order = new List<string>{"TexCoordIndex"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcIndexedTriangleTextureMap_IFC4(string line) : base(line){}
    public IfcIndexedTriangleTextureMap_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcInterceptor_IFC4 : IfcFlowTreatmentDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcInterceptor_IFC4(string line) : base(line){}
    public IfcInterceptor_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcInterceptorType_IFC4 : IfcFlowTreatmentDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcInterceptorType_IFC4(string line) : base(line){}
    public IfcInterceptorType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcIntersectionCurve_IFC4 : IfcSurfaceCurve_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcIntersectionCurve_IFC4(string line) : base(line){}
    public IfcIntersectionCurve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcInventory_IFC4 : IfcGroup_IFC4 {
    public string PredefinedType;
    public IfcActorSelect_IFC4 Jurisdiction;
    public List<IfcPerson_IFC4> ResponsiblePersons;
    public string LastUpdateDate;
    public IfcCostValue_IFC4 CurrentValue;
    public IfcCostValue_IFC4 OriginalValue;

    public new List<string> param_order = new List<string>{"PredefinedType", "Jurisdiction", "ResponsiblePersons", "LastUpdateDate", "CurrentValue", "OriginalValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcInventory_IFC4(string line) : base(line){}
    public IfcInventory_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcIrregularTimeSeries_IFC4 : IfcTimeSeries_IFC4 {
    public List<IfcIrregularTimeSeriesValue_IFC4> Values;

    public new List<string> param_order = new List<string>{"Values"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcIrregularTimeSeries_IFC4(string line) : base(line){}
    public IfcIrregularTimeSeries_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcIrregularTimeSeriesValue_IFC4 : Entity {
    public string TimeStamp;
    public List<IfcValue_IFC4> ListValues;

    public new List<string> param_order = new List<string>{"TimeStamp", "ListValues"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcIrregularTimeSeriesValue_IFC4(string line) : base(line){}
    public IfcIrregularTimeSeriesValue_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcJunctionBox_IFC4 : IfcFlowFitting_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcJunctionBox_IFC4(string line) : base(line){}
    public IfcJunctionBox_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcJunctionBoxType_IFC4 : IfcFlowFittingType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcJunctionBoxType_IFC4(string line) : base(line){}
    public IfcJunctionBoxType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLShapeProfileDef_IFC4 : IfcParameterizedProfileDef_IFC4 {
    public string Depth;
    public string Width;
    public string Thickness;
    public string FilletRadius;
    public string EdgeRadius;
    public string LegSlope;

    public new List<string> param_order = new List<string>{"Depth", "Width", "Thickness", "FilletRadius", "EdgeRadius", "LegSlope"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLShapeProfileDef_IFC4(string line) : base(line){}
    public IfcLShapeProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLaborResource_IFC4 : IfcConstructionResource_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLaborResource_IFC4(string line) : base(line){}
    public IfcLaborResource_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLaborResourceType_IFC4 : IfcConstructionResourceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLaborResourceType_IFC4(string line) : base(line){}
    public IfcLaborResourceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLagTime_IFC4 : IfcSchedulingTime_IFC4 {
    public IfcTimeOrRatioSelect_IFC4 LagValue;
    public string DurationType;

    public new List<string> param_order = new List<string>{"LagValue", "DurationType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLagTime_IFC4(string line) : base(line){}
    public IfcLagTime_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLamp_IFC4 : IfcFlowTerminal_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLamp_IFC4(string line) : base(line){}
    public IfcLamp_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLampType_IFC4 : IfcFlowTerminalType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLampType_IFC4(string line) : base(line){}
    public IfcLampType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLibraryInformation_IFC4 : IfcExternalInformation_IFC4 {
    public string Name;
    public string Version;
    public IfcActorSelect_IFC4 Publisher;
    public string VersionDate;
    public string Location;
    public string Description;

    public new List<string> param_order = new List<string>{"Name", "Version", "Publisher", "VersionDate", "Location", "Description"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLibraryInformation_IFC4(string line) : base(line){}
    public IfcLibraryInformation_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLibraryReference_IFC4 : IfcExternalReference_IFC4 {
    public string Description;
    public string Language;
    public IfcLibraryInformation_IFC4 ReferencedLibrary;

    public new List<string> param_order = new List<string>{"Description", "Language", "ReferencedLibrary"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLibraryReference_IFC4(string line) : base(line){}
    public IfcLibraryReference_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLightDistributionData_IFC4 : Entity {
    public string MainPlaneAngle;
    public List<string> SecondaryPlaneAngle;
    public List<string> LuminousIntensity;

    public new List<string> param_order = new List<string>{"MainPlaneAngle", "SecondaryPlaneAngle", "LuminousIntensity"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightDistributionData_IFC4(string line) : base(line){}
    public IfcLightDistributionData_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLightFixture_IFC4 : IfcFlowTerminal_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightFixture_IFC4(string line) : base(line){}
    public IfcLightFixture_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLightFixtureType_IFC4 : IfcFlowTerminalType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightFixtureType_IFC4(string line) : base(line){}
    public IfcLightFixtureType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLightIntensityDistribution_IFC4 : Entity {
    public string LightDistributionCurve;
    public List<IfcLightDistributionData_IFC4> DistributionData;

    public new List<string> param_order = new List<string>{"LightDistributionCurve", "DistributionData"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightIntensityDistribution_IFC4(string line) : base(line){}
    public IfcLightIntensityDistribution_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLightSource_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public string Name;
    public IfcColourRgb_IFC4 LightColour;
    public string AmbientIntensity;
    public string Intensity;

    public new List<string> param_order = new List<string>{"Name", "LightColour", "AmbientIntensity", "Intensity"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightSource_IFC4(string line) : base(line){}
    public IfcLightSource_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLightSourceAmbient_IFC4 : IfcLightSource_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightSourceAmbient_IFC4(string line) : base(line){}
    public IfcLightSourceAmbient_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLightSourceDirectional_IFC4 : IfcLightSource_IFC4 {
    public IfcDirection_IFC4 Orientation;

    public new List<string> param_order = new List<string>{"Orientation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightSourceDirectional_IFC4(string line) : base(line){}
    public IfcLightSourceDirectional_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLightSourceGoniometric_IFC4 : IfcLightSource_IFC4 {
    public IfcAxis2Placement3D_IFC4 Position;
    public IfcColourRgb_IFC4 ColourAppearance;
    public string ColourTemperature;
    public string LuminousFlux;
    public string LightEmissionSource;
    public IfcLightDistributionDataSourceSelect_IFC4 LightDistributionDataSource;

    public new List<string> param_order = new List<string>{"Position", "ColourAppearance", "ColourTemperature", "LuminousFlux", "LightEmissionSource", "LightDistributionDataSource"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightSourceGoniometric_IFC4(string line) : base(line){}
    public IfcLightSourceGoniometric_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLightSourcePositional_IFC4 : IfcLightSource_IFC4 {
    public IfcCartesianPoint_IFC4 Position;
    public string Radius;
    public string ConstantAttenuation;
    public string DistanceAttenuation;
    public string QuadricAttenuation;

    public new List<string> param_order = new List<string>{"Position", "Radius", "ConstantAttenuation", "DistanceAttenuation", "QuadricAttenuation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightSourcePositional_IFC4(string line) : base(line){}
    public IfcLightSourcePositional_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLightSourceSpot_IFC4 : IfcLightSourcePositional_IFC4 {
    public IfcDirection_IFC4 Orientation;
    public string ConcentrationExponent;
    public string SpreadAngle;
    public string BeamWidthAngle;

    public new List<string> param_order = new List<string>{"Orientation", "ConcentrationExponent", "SpreadAngle", "BeamWidthAngle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLightSourceSpot_IFC4(string line) : base(line){}
    public IfcLightSourceSpot_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLine_IFC4 : IfcCurve_IFC4 {
    public IfcCartesianPoint_IFC4 Pnt;
    public IfcVector_IFC4 Dir;

    public new List<string> param_order = new List<string>{"Pnt", "Dir"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLine_IFC4(string line) : base(line){}
    public IfcLine_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLocalPlacement_IFC4 : IfcObjectPlacement_IFC4 {
    public IfcObjectPlacement_IFC4 PlacementRelTo;
    public IfcAxis2Placement_IFC4 RelativePlacement;

    public new List<string> param_order = new List<string>{"PlacementRelTo", "RelativePlacement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLocalPlacement_IFC4(string line) : base(line){}
    public IfcLocalPlacement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcLoop_IFC4 : IfcTopologicalRepresentationItem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcLoop_IFC4(string line) : base(line){}
    public IfcLoop_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcManifoldSolidBrep_IFC4 : IfcSolidModel_IFC4 {
    public IfcClosedShell_IFC4 Outer;

    public new List<string> param_order = new List<string>{"Outer"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcManifoldSolidBrep_IFC4(string line) : base(line){}
    public IfcManifoldSolidBrep_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMapConversion_IFC4 : IfcCoordinateOperation_IFC4 {
    public string Eastings;
    public string Northings;
    public string OrthogonalHeight;
    public string XAxisAbscissa;
    public string XAxisOrdinate;
    public string Scale;

    public new List<string> param_order = new List<string>{"Eastings", "Northings", "OrthogonalHeight", "XAxisAbscissa", "XAxisOrdinate", "Scale"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMapConversion_IFC4(string line) : base(line){}
    public IfcMapConversion_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMappedItem_IFC4 : IfcRepresentationItem_IFC4 {
    public IfcRepresentationMap_IFC4 MappingSource;
    public IfcCartesianTransformationOperator_IFC4 MappingTarget;

    public new List<string> param_order = new List<string>{"MappingSource", "MappingTarget"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMappedItem_IFC4(string line) : base(line){}
    public IfcMappedItem_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterial_IFC4 : IfcMaterialDefinition_IFC4 {
    public string Name;
    public string Description;
    public string Category;

    public new List<string> param_order = new List<string>{"Name", "Description", "Category"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterial_IFC4(string line) : base(line){}
    public IfcMaterial_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialClassificationRelationship_IFC4 : Entity {
    public List<IfcClassificationSelect_IFC4> MaterialClassifications;
    public IfcMaterial_IFC4 ClassifiedMaterial;

    public new List<string> param_order = new List<string>{"MaterialClassifications", "ClassifiedMaterial"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialClassificationRelationship_IFC4(string line) : base(line){}
    public IfcMaterialClassificationRelationship_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialConstituent_IFC4 : IfcMaterialDefinition_IFC4 {
    public string Name;
    public string Description;
    public IfcMaterial_IFC4 Material;
    public string Fraction;
    public string Category;

    public new List<string> param_order = new List<string>{"Name", "Description", "Material", "Fraction", "Category"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialConstituent_IFC4(string line) : base(line){}
    public IfcMaterialConstituent_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialConstituentSet_IFC4 : IfcMaterialDefinition_IFC4 {
    public string Name;
    public string Description;
    public List<IfcMaterialConstituent_IFC4> MaterialConstituents;

    public new List<string> param_order = new List<string>{"Name", "Description", "MaterialConstituents"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialConstituentSet_IFC4(string line) : base(line){}
    public IfcMaterialConstituentSet_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialDefinition_IFC4 : Entity {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialDefinition_IFC4(string line) : base(line){}
    public IfcMaterialDefinition_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialDefinitionRepresentation_IFC4 : IfcProductRepresentation_IFC4 {
    public IfcMaterial_IFC4 RepresentedMaterial;

    public new List<string> param_order = new List<string>{"RepresentedMaterial"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialDefinitionRepresentation_IFC4(string line) : base(line){}
    public IfcMaterialDefinitionRepresentation_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialLayer_IFC4 : IfcMaterialDefinition_IFC4 {
    public IfcMaterial_IFC4 Material;
    public string LayerThickness;
    public string IsVentilated;
    public string Name;
    public string Description;
    public string Category;
    public string Priority;

    public new List<string> param_order = new List<string>{"Material", "LayerThickness", "IsVentilated", "Name", "Description", "Category", "Priority"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialLayer_IFC4(string line) : base(line){}
    public IfcMaterialLayer_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialLayerSet_IFC4 : IfcMaterialDefinition_IFC4 {
    public List<IfcMaterialLayer_IFC4> MaterialLayers;
    public string LayerSetName;
    public string Description;

    public new List<string> param_order = new List<string>{"MaterialLayers", "LayerSetName", "Description"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialLayerSet_IFC4(string line) : base(line){}
    public IfcMaterialLayerSet_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialLayerSetUsage_IFC4 : IfcMaterialUsageDefinition_IFC4 {
    public IfcMaterialLayerSet_IFC4 ForLayerSet;
    public string LayerSetDirection;
    public string DirectionSense;
    public string OffsetFromReferenceLine;
    public string ReferenceExtent;

    public new List<string> param_order = new List<string>{"ForLayerSet", "LayerSetDirection", "DirectionSense", "OffsetFromReferenceLine", "ReferenceExtent"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialLayerSetUsage_IFC4(string line) : base(line){}
    public IfcMaterialLayerSetUsage_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialLayerWithOffsets_IFC4 : IfcMaterialLayer_IFC4 {
    public string OffsetDirection;
    public List<string> OffsetValues;

    public new List<string> param_order = new List<string>{"OffsetDirection", "OffsetValues"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialLayerWithOffsets_IFC4(string line) : base(line){}
    public IfcMaterialLayerWithOffsets_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialList_IFC4 : Entity {
    public List<IfcMaterial_IFC4> Materials;

    public new List<string> param_order = new List<string>{"Materials"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialList_IFC4(string line) : base(line){}
    public IfcMaterialList_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialProfile_IFC4 : IfcMaterialDefinition_IFC4 {
    public string Name;
    public string Description;
    public IfcMaterial_IFC4 Material;
    public IfcProfileDef_IFC4 Profile;
    public string Priority;
    public string Category;

    public new List<string> param_order = new List<string>{"Name", "Description", "Material", "Profile", "Priority", "Category"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialProfile_IFC4(string line) : base(line){}
    public IfcMaterialProfile_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialProfileSet_IFC4 : IfcMaterialDefinition_IFC4 {
    public string Name;
    public string Description;
    public List<IfcMaterialProfile_IFC4> MaterialProfiles;
    public IfcCompositeProfileDef_IFC4 CompositeProfile;

    public new List<string> param_order = new List<string>{"Name", "Description", "MaterialProfiles", "CompositeProfile"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialProfileSet_IFC4(string line) : base(line){}
    public IfcMaterialProfileSet_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialProfileSetUsage_IFC4 : IfcMaterialUsageDefinition_IFC4 {
    public IfcMaterialProfileSet_IFC4 ForProfileSet;
    public string CardinalPoint;
    public string ReferenceExtent;

    public new List<string> param_order = new List<string>{"ForProfileSet", "CardinalPoint", "ReferenceExtent"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialProfileSetUsage_IFC4(string line) : base(line){}
    public IfcMaterialProfileSetUsage_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialProfileSetUsageTapering_IFC4 : IfcMaterialProfileSetUsage_IFC4 {
    public IfcMaterialProfileSet_IFC4 ForProfileEndSet;
    public string CardinalEndPoint;

    public new List<string> param_order = new List<string>{"ForProfileEndSet", "CardinalEndPoint"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialProfileSetUsageTapering_IFC4(string line) : base(line){}
    public IfcMaterialProfileSetUsageTapering_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialProfileWithOffsets_IFC4 : IfcMaterialProfile_IFC4 {
    public List<string> OffsetValues;

    public new List<string> param_order = new List<string>{"OffsetValues"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialProfileWithOffsets_IFC4(string line) : base(line){}
    public IfcMaterialProfileWithOffsets_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialProperties_IFC4 : IfcExtendedProperties_IFC4 {
    public IfcMaterialDefinition_IFC4 Material;

    public new List<string> param_order = new List<string>{"Material"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialProperties_IFC4(string line) : base(line){}
    public IfcMaterialProperties_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialRelationship_IFC4 : IfcResourceLevelRelationship_IFC4 {
    public IfcMaterial_IFC4 RelatingMaterial;
    public List<IfcMaterial_IFC4> RelatedMaterials;
    public string Expression;

    public new List<string> param_order = new List<string>{"RelatingMaterial", "RelatedMaterials", "Expression"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialRelationship_IFC4(string line) : base(line){}
    public IfcMaterialRelationship_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMaterialUsageDefinition_IFC4 : Entity {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMaterialUsageDefinition_IFC4(string line) : base(line){}
    public IfcMaterialUsageDefinition_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMeasureWithUnit_IFC4 : Entity {
    public IfcValue_IFC4 ValueComponent;
    public IfcUnit_IFC4 UnitComponent;

    public new List<string> param_order = new List<string>{"ValueComponent", "UnitComponent"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMeasureWithUnit_IFC4(string line) : base(line){}
    public IfcMeasureWithUnit_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMechanicalFastener_IFC4 : IfcElementComponent_IFC4 {
    public string NominalDiameter;
    public string NominalLength;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"NominalDiameter", "NominalLength", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMechanicalFastener_IFC4(string line) : base(line){}
    public IfcMechanicalFastener_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMechanicalFastenerType_IFC4 : IfcElementComponentType_IFC4 {
    public string PredefinedType;
    public string NominalDiameter;
    public string NominalLength;

    public new List<string> param_order = new List<string>{"PredefinedType", "NominalDiameter", "NominalLength"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMechanicalFastenerType_IFC4(string line) : base(line){}
    public IfcMechanicalFastenerType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMedicalDevice_IFC4 : IfcFlowTerminal_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMedicalDevice_IFC4(string line) : base(line){}
    public IfcMedicalDevice_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMedicalDeviceType_IFC4 : IfcFlowTerminalType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMedicalDeviceType_IFC4(string line) : base(line){}
    public IfcMedicalDeviceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMember_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMember_IFC4(string line) : base(line){}
    public IfcMember_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMemberStandardCase_IFC4 : IfcMember_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMemberStandardCase_IFC4(string line) : base(line){}
    public IfcMemberStandardCase_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMemberType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMemberType_IFC4(string line) : base(line){}
    public IfcMemberType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMetric_IFC4 : IfcConstraint_IFC4 {
    public string Benchmark;
    public string ValueSource;
    public IfcMetricValueSelect_IFC4 DataValue;
    public IfcReference_IFC4 ReferencePath;

    public new List<string> param_order = new List<string>{"Benchmark", "ValueSource", "DataValue", "ReferencePath"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMetric_IFC4(string line) : base(line){}
    public IfcMetric_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMirroredProfileDef_IFC4 : IfcDerivedProfileDef_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMirroredProfileDef_IFC4(string line) : base(line){}
    public IfcMirroredProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMonetaryUnit_IFC4 : Entity {
    public string Currency;

    public new List<string> param_order = new List<string>{"Currency"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMonetaryUnit_IFC4(string line) : base(line){}
    public IfcMonetaryUnit_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMotorConnection_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMotorConnection_IFC4(string line) : base(line){}
    public IfcMotorConnection_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcMotorConnectionType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcMotorConnectionType_IFC4(string line) : base(line){}
    public IfcMotorConnectionType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcNamedUnit_IFC4 : Entity {
    public IfcDimensionalExponents_IFC4 Dimensions;
    public string UnitType;

    public new List<string> param_order = new List<string>{"Dimensions", "UnitType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcNamedUnit_IFC4(string line) : base(line){}
    public IfcNamedUnit_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcObject_IFC4 : IfcObjectDefinition_IFC4 {
    public string ObjectType;

    public new List<string> param_order = new List<string>{"ObjectType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcObject_IFC4(string line) : base(line){}
    public IfcObject_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcObjectDefinition_IFC4 : IfcRoot_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcObjectDefinition_IFC4(string line) : base(line){}
    public IfcObjectDefinition_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcObjectPlacement_IFC4 : Entity {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcObjectPlacement_IFC4(string line) : base(line){}
    public IfcObjectPlacement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcObjective_IFC4 : IfcConstraint_IFC4 {
    public List<IfcConstraint_IFC4> BenchmarkValues;
    public string LogicalAggregator;
    public string ObjectiveQualifier;
    public string UserDefinedQualifier;

    public new List<string> param_order = new List<string>{"BenchmarkValues", "LogicalAggregator", "ObjectiveQualifier", "UserDefinedQualifier"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcObjective_IFC4(string line) : base(line){}
    public IfcObjective_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcOccupant_IFC4 : IfcActor_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOccupant_IFC4(string line) : base(line){}
    public IfcOccupant_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcOffsetCurve2D_IFC4 : IfcCurve_IFC4 {
    public IfcCurve_IFC4 BasisCurve;
    public string Distance;
    public string SelfIntersect;

    public new List<string> param_order = new List<string>{"BasisCurve", "Distance", "SelfIntersect"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOffsetCurve2D_IFC4(string line) : base(line){}
    public IfcOffsetCurve2D_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcOffsetCurve3D_IFC4 : IfcCurve_IFC4 {
    public IfcCurve_IFC4 BasisCurve;
    public string Distance;
    public string SelfIntersect;
    public IfcDirection_IFC4 RefDirection;

    public new List<string> param_order = new List<string>{"BasisCurve", "Distance", "SelfIntersect", "RefDirection"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOffsetCurve3D_IFC4(string line) : base(line){}
    public IfcOffsetCurve3D_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcOpenShell_IFC4 : IfcConnectedFaceSet_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOpenShell_IFC4(string line) : base(line){}
    public IfcOpenShell_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcOpeningElement_IFC4 : IfcFeatureElementSubtraction_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOpeningElement_IFC4(string line) : base(line){}
    public IfcOpeningElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcOpeningStandardCase_IFC4 : IfcOpeningElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOpeningStandardCase_IFC4(string line) : base(line){}
    public IfcOpeningStandardCase_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcOrganization_IFC4 : Entity {
    public string Identification;
    public string Name;
    public string Description;
    public List<IfcActorRole_IFC4> Roles;
    public List<IfcAddress_IFC4> Addresses;

    public new List<string> param_order = new List<string>{"Identification", "Name", "Description", "Roles", "Addresses"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOrganization_IFC4(string line) : base(line){}
    public IfcOrganization_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcOrganizationRelationship_IFC4 : IfcResourceLevelRelationship_IFC4 {
    public IfcOrganization_IFC4 RelatingOrganization;
    public List<IfcOrganization_IFC4> RelatedOrganizations;

    public new List<string> param_order = new List<string>{"RelatingOrganization", "RelatedOrganizations"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOrganizationRelationship_IFC4(string line) : base(line){}
    public IfcOrganizationRelationship_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcOrientedEdge_IFC4 : IfcEdge_IFC4 {
    public IfcEdge_IFC4 EdgeElement;
    public string Orientation;

    public new List<string> param_order = new List<string>{"EdgeElement", "Orientation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOrientedEdge_IFC4(string line) : base(line){}
    public IfcOrientedEdge_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcOuterBoundaryCurve_IFC4 : IfcBoundaryCurve_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOuterBoundaryCurve_IFC4(string line) : base(line){}
    public IfcOuterBoundaryCurve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcOutlet_IFC4 : IfcFlowTerminal_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOutlet_IFC4(string line) : base(line){}
    public IfcOutlet_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcOutletType_IFC4 : IfcFlowTerminalType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOutletType_IFC4(string line) : base(line){}
    public IfcOutletType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcOwnerHistory_IFC4 : Entity {
    public IfcPersonAndOrganization_IFC4 OwningUser;
    public IfcApplication_IFC4 OwningApplication;
    public string State;
    public string ChangeAction;
    public string LastModifiedDate;
    public IfcPersonAndOrganization_IFC4 LastModifyingUser;
    public IfcApplication_IFC4 LastModifyingApplication;
    public string CreationDate;

    public new List<string> param_order = new List<string>{"OwningUser", "OwningApplication", "State", "ChangeAction", "LastModifiedDate", "LastModifyingUser", "LastModifyingApplication", "CreationDate"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcOwnerHistory_IFC4(string line) : base(line){}
    public IfcOwnerHistory_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcParameterizedProfileDef_IFC4 : IfcProfileDef_IFC4 {
    public IfcAxis2Placement2D_IFC4 Position;

    public new List<string> param_order = new List<string>{"Position"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcParameterizedProfileDef_IFC4(string line) : base(line){}
    public IfcParameterizedProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPath_IFC4 : IfcTopologicalRepresentationItem_IFC4 {
    public List<IfcOrientedEdge_IFC4> EdgeList;

    public new List<string> param_order = new List<string>{"EdgeList"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPath_IFC4(string line) : base(line){}
    public IfcPath_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPcurve_IFC4 : IfcCurve_IFC4 {
    public IfcSurface_IFC4 BasisSurface;
    public IfcCurve_IFC4 ReferenceCurve;

    public new List<string> param_order = new List<string>{"BasisSurface", "ReferenceCurve"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPcurve_IFC4(string line) : base(line){}
    public IfcPcurve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPerformanceHistory_IFC4 : IfcControl_IFC4 {
    public string LifeCyclePhase;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"LifeCyclePhase", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPerformanceHistory_IFC4(string line) : base(line){}
    public IfcPerformanceHistory_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPermeableCoveringProperties_IFC4 : IfcPreDefinedPropertySet_IFC4 {
    public string OperationType;
    public string PanelPosition;
    public string FrameDepth;
    public string FrameThickness;
    public IfcShapeAspect_IFC4 ShapeAspectStyle;

    public new List<string> param_order = new List<string>{"OperationType", "PanelPosition", "FrameDepth", "FrameThickness", "ShapeAspectStyle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPermeableCoveringProperties_IFC4(string line) : base(line){}
    public IfcPermeableCoveringProperties_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPermit_IFC4 : IfcControl_IFC4 {
    public string PredefinedType;
    public string Status;
    public string LongDescription;

    public new List<string> param_order = new List<string>{"PredefinedType", "Status", "LongDescription"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPermit_IFC4(string line) : base(line){}
    public IfcPermit_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPerson_IFC4 : Entity {
    public string Identification;
    public string FamilyName;
    public string GivenName;
    public List<string> MiddleNames;
    public List<string> PrefixTitles;
    public List<string> SuffixTitles;
    public List<IfcActorRole_IFC4> Roles;
    public List<IfcAddress_IFC4> Addresses;

    public new List<string> param_order = new List<string>{"Identification", "FamilyName", "GivenName", "MiddleNames", "PrefixTitles", "SuffixTitles", "Roles", "Addresses"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPerson_IFC4(string line) : base(line){}
    public IfcPerson_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPersonAndOrganization_IFC4 : Entity {
    public IfcPerson_IFC4 ThePerson;
    public IfcOrganization_IFC4 TheOrganization;
    public List<IfcActorRole_IFC4> Roles;

    public new List<string> param_order = new List<string>{"ThePerson", "TheOrganization", "Roles"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPersonAndOrganization_IFC4(string line) : base(line){}
    public IfcPersonAndOrganization_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPhysicalComplexQuantity_IFC4 : IfcPhysicalQuantity_IFC4 {
    public List<IfcPhysicalQuantity_IFC4> HasQuantities;
    public string Discrimination;
    public string Quality;
    public string Usage;

    public new List<string> param_order = new List<string>{"HasQuantities", "Discrimination", "Quality", "Usage"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPhysicalComplexQuantity_IFC4(string line) : base(line){}
    public IfcPhysicalComplexQuantity_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPhysicalQuantity_IFC4 : Entity {
    public string Name;
    public string Description;

    public new List<string> param_order = new List<string>{"Name", "Description"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPhysicalQuantity_IFC4(string line) : base(line){}
    public IfcPhysicalQuantity_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPhysicalSimpleQuantity_IFC4 : IfcPhysicalQuantity_IFC4 {
    public IfcNamedUnit_IFC4 Unit;

    public new List<string> param_order = new List<string>{"Unit"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPhysicalSimpleQuantity_IFC4(string line) : base(line){}
    public IfcPhysicalSimpleQuantity_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPile_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;
    public string ConstructionType;

    public new List<string> param_order = new List<string>{"PredefinedType", "ConstructionType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPile_IFC4(string line) : base(line){}
    public IfcPile_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPileType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPileType_IFC4(string line) : base(line){}
    public IfcPileType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPipeFitting_IFC4 : IfcFlowFitting_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPipeFitting_IFC4(string line) : base(line){}
    public IfcPipeFitting_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPipeFittingType_IFC4 : IfcFlowFittingType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPipeFittingType_IFC4(string line) : base(line){}
    public IfcPipeFittingType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPipeSegment_IFC4 : IfcFlowSegment_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPipeSegment_IFC4(string line) : base(line){}
    public IfcPipeSegment_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPipeSegmentType_IFC4 : IfcFlowSegmentType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPipeSegmentType_IFC4(string line) : base(line){}
    public IfcPipeSegmentType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPixelTexture_IFC4 : IfcSurfaceTexture_IFC4 {
    public string Width;
    public string Height;
    public string ColourComponents;
    public List<string> Pixel;

    public new List<string> param_order = new List<string>{"Width", "Height", "ColourComponents", "Pixel"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPixelTexture_IFC4(string line) : base(line){}
    public IfcPixelTexture_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPlacement_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public IfcCartesianPoint_IFC4 Location;

    public new List<string> param_order = new List<string>{"Location"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPlacement_IFC4(string line) : base(line){}
    public IfcPlacement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPlanarBox_IFC4 : IfcPlanarExtent_IFC4 {
    public IfcAxis2Placement_IFC4 Placement;

    public new List<string> param_order = new List<string>{"Placement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPlanarBox_IFC4(string line) : base(line){}
    public IfcPlanarBox_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPlanarExtent_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public string SizeInX;
    public string SizeInY;

    public new List<string> param_order = new List<string>{"SizeInX", "SizeInY"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPlanarExtent_IFC4(string line) : base(line){}
    public IfcPlanarExtent_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPlane_IFC4 : IfcElementarySurface_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPlane_IFC4(string line) : base(line){}
    public IfcPlane_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPlate_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPlate_IFC4(string line) : base(line){}
    public IfcPlate_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPlateStandardCase_IFC4 : IfcPlate_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPlateStandardCase_IFC4(string line) : base(line){}
    public IfcPlateStandardCase_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPlateType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPlateType_IFC4(string line) : base(line){}
    public IfcPlateType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPoint_IFC4 : IfcGeometricRepresentationItem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPoint_IFC4(string line) : base(line){}
    public IfcPoint_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPointOnCurve_IFC4 : IfcPoint_IFC4 {
    public IfcCurve_IFC4 BasisCurve;
    public string PointParameter;

    public new List<string> param_order = new List<string>{"BasisCurve", "PointParameter"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPointOnCurve_IFC4(string line) : base(line){}
    public IfcPointOnCurve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPointOnSurface_IFC4 : IfcPoint_IFC4 {
    public IfcSurface_IFC4 BasisSurface;
    public string PointParameterU;
    public string PointParameterV;

    public new List<string> param_order = new List<string>{"BasisSurface", "PointParameterU", "PointParameterV"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPointOnSurface_IFC4(string line) : base(line){}
    public IfcPointOnSurface_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPolyLoop_IFC4 : IfcLoop_IFC4 {
    public List<IfcCartesianPoint_IFC4> Polygon;

    public new List<string> param_order = new List<string>{"Polygon"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPolyLoop_IFC4(string line) : base(line){}
    public IfcPolyLoop_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPolygonalBoundedHalfSpace_IFC4 : IfcHalfSpaceSolid_IFC4 {
    public IfcAxis2Placement3D_IFC4 Position;
    public IfcBoundedCurve_IFC4 PolygonalBoundary;

    public new List<string> param_order = new List<string>{"Position", "PolygonalBoundary"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPolygonalBoundedHalfSpace_IFC4(string line) : base(line){}
    public IfcPolygonalBoundedHalfSpace_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPolygonalFaceSet_IFC4 : IfcTessellatedFaceSet_IFC4 {
    public string Closed;
    public List<IfcIndexedPolygonalFace_IFC4> Faces;
    public List<string> PnIndex;

    public new List<string> param_order = new List<string>{"Closed", "Faces", "PnIndex"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPolygonalFaceSet_IFC4(string line) : base(line){}
    public IfcPolygonalFaceSet_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPolyline_IFC4 : IfcBoundedCurve_IFC4 {
    public List<IfcCartesianPoint_IFC4> Points;

    public new List<string> param_order = new List<string>{"Points"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPolyline_IFC4(string line) : base(line){}
    public IfcPolyline_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPort_IFC4 : IfcProduct_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPort_IFC4(string line) : base(line){}
    public IfcPort_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPostalAddress_IFC4 : IfcAddress_IFC4 {
    public string InternalLocation;
    public List<string> AddressLines;
    public string PostalBox;
    public string Town;
    public string Region;
    public string PostalCode;
    public string Country;

    public new List<string> param_order = new List<string>{"InternalLocation", "AddressLines", "PostalBox", "Town", "Region", "PostalCode", "Country"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPostalAddress_IFC4(string line) : base(line){}
    public IfcPostalAddress_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPreDefinedColour_IFC4 : IfcPreDefinedItem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPreDefinedColour_IFC4(string line) : base(line){}
    public IfcPreDefinedColour_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPreDefinedCurveFont_IFC4 : IfcPreDefinedItem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPreDefinedCurveFont_IFC4(string line) : base(line){}
    public IfcPreDefinedCurveFont_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPreDefinedItem_IFC4 : IfcPresentationItem_IFC4 {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPreDefinedItem_IFC4(string line) : base(line){}
    public IfcPreDefinedItem_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPreDefinedProperties_IFC4 : IfcPropertyAbstraction_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPreDefinedProperties_IFC4(string line) : base(line){}
    public IfcPreDefinedProperties_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPreDefinedPropertySet_IFC4 : IfcPropertySetDefinition_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPreDefinedPropertySet_IFC4(string line) : base(line){}
    public IfcPreDefinedPropertySet_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPreDefinedTextFont_IFC4 : IfcPreDefinedItem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPreDefinedTextFont_IFC4(string line) : base(line){}
    public IfcPreDefinedTextFont_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPresentationItem_IFC4 : Entity {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPresentationItem_IFC4(string line) : base(line){}
    public IfcPresentationItem_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPresentationLayerAssignment_IFC4 : Entity {
    public string Name;
    public string Description;
    public List<IfcLayeredItem_IFC4> AssignedItems;
    public string Identifier;

    public new List<string> param_order = new List<string>{"Name", "Description", "AssignedItems", "Identifier"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPresentationLayerAssignment_IFC4(string line) : base(line){}
    public IfcPresentationLayerAssignment_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPresentationLayerWithStyle_IFC4 : IfcPresentationLayerAssignment_IFC4 {
    public string LayerOn;
    public string LayerFrozen;
    public string LayerBlocked;
    public List<IfcPresentationStyle_IFC4> LayerStyles;

    public new List<string> param_order = new List<string>{"LayerOn", "LayerFrozen", "LayerBlocked", "LayerStyles"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPresentationLayerWithStyle_IFC4(string line) : base(line){}
    public IfcPresentationLayerWithStyle_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPresentationStyle_IFC4 : Entity {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPresentationStyle_IFC4(string line) : base(line){}
    public IfcPresentationStyle_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPresentationStyleAssignment_IFC4 : Entity {
    public List<IfcPresentationStyleSelect_IFC4> Styles;

    public new List<string> param_order = new List<string>{"Styles"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPresentationStyleAssignment_IFC4(string line) : base(line){}
    public IfcPresentationStyleAssignment_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProcedure_IFC4 : IfcProcess_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProcedure_IFC4(string line) : base(line){}
    public IfcProcedure_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProcedureType_IFC4 : IfcTypeProcess_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProcedureType_IFC4(string line) : base(line){}
    public IfcProcedureType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProcess_IFC4 : IfcObject_IFC4 {
    public string Identification;
    public string LongDescription;

    public new List<string> param_order = new List<string>{"Identification", "LongDescription"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProcess_IFC4(string line) : base(line){}
    public IfcProcess_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProduct_IFC4 : IfcObject_IFC4 {
    public IfcObjectPlacement_IFC4 ObjectPlacement;
    public IfcProductRepresentation_IFC4 Representation;

    public new List<string> param_order = new List<string>{"ObjectPlacement", "Representation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProduct_IFC4(string line) : base(line){}
    public IfcProduct_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProductDefinitionShape_IFC4 : IfcProductRepresentation_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProductDefinitionShape_IFC4(string line) : base(line){}
    public IfcProductDefinitionShape_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProductRepresentation_IFC4 : Entity {
    public string Name;
    public string Description;
    public List<IfcRepresentation_IFC4> Representations;

    public new List<string> param_order = new List<string>{"Name", "Description", "Representations"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProductRepresentation_IFC4(string line) : base(line){}
    public IfcProductRepresentation_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProfileDef_IFC4 : Entity {
    public string ProfileType;
    public string ProfileName;

    public new List<string> param_order = new List<string>{"ProfileType", "ProfileName"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProfileDef_IFC4(string line) : base(line){}
    public IfcProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProfileProperties_IFC4 : IfcExtendedProperties_IFC4 {
    public IfcProfileDef_IFC4 ProfileDefinition;

    public new List<string> param_order = new List<string>{"ProfileDefinition"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProfileProperties_IFC4(string line) : base(line){}
    public IfcProfileProperties_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProject_IFC4 : IfcContext_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProject_IFC4(string line) : base(line){}
    public IfcProject_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProjectLibrary_IFC4 : IfcContext_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProjectLibrary_IFC4(string line) : base(line){}
    public IfcProjectLibrary_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProjectOrder_IFC4 : IfcControl_IFC4 {
    public string PredefinedType;
    public string Status;
    public string LongDescription;

    public new List<string> param_order = new List<string>{"PredefinedType", "Status", "LongDescription"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProjectOrder_IFC4(string line) : base(line){}
    public IfcProjectOrder_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProjectedCRS_IFC4 : IfcCoordinateReferenceSystem_IFC4 {
    public string MapProjection;
    public string MapZone;
    public IfcNamedUnit_IFC4 MapUnit;

    public new List<string> param_order = new List<string>{"MapProjection", "MapZone", "MapUnit"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProjectedCRS_IFC4(string line) : base(line){}
    public IfcProjectedCRS_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProjectionElement_IFC4 : IfcFeatureElementAddition_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProjectionElement_IFC4(string line) : base(line){}
    public IfcProjectionElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProperty_IFC4 : IfcPropertyAbstraction_IFC4 {
    public string Name;
    public string Description;

    public new List<string> param_order = new List<string>{"Name", "Description"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProperty_IFC4(string line) : base(line){}
    public IfcProperty_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyAbstraction_IFC4 : Entity {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyAbstraction_IFC4(string line) : base(line){}
    public IfcPropertyAbstraction_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyBoundedValue_IFC4 : IfcSimpleProperty_IFC4 {
    public IfcValue_IFC4 UpperBoundValue;
    public IfcValue_IFC4 LowerBoundValue;
    public IfcUnit_IFC4 Unit;
    public IfcValue_IFC4 SetPointValue;

    public new List<string> param_order = new List<string>{"UpperBoundValue", "LowerBoundValue", "Unit", "SetPointValue"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyBoundedValue_IFC4(string line) : base(line){}
    public IfcPropertyBoundedValue_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyDefinition_IFC4 : IfcRoot_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyDefinition_IFC4(string line) : base(line){}
    public IfcPropertyDefinition_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyDependencyRelationship_IFC4 : IfcResourceLevelRelationship_IFC4 {
    public IfcProperty_IFC4 DependingProperty;
    public IfcProperty_IFC4 DependantProperty;
    public string Expression;

    public new List<string> param_order = new List<string>{"DependingProperty", "DependantProperty", "Expression"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyDependencyRelationship_IFC4(string line) : base(line){}
    public IfcPropertyDependencyRelationship_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyEnumeratedValue_IFC4 : IfcSimpleProperty_IFC4 {
    public List<IfcValue_IFC4> EnumerationValues;
    public IfcPropertyEnumeration_IFC4 EnumerationReference;

    public new List<string> param_order = new List<string>{"EnumerationValues", "EnumerationReference"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyEnumeratedValue_IFC4(string line) : base(line){}
    public IfcPropertyEnumeratedValue_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyEnumeration_IFC4 : IfcPropertyAbstraction_IFC4 {
    public string Name;
    public List<IfcValue_IFC4> EnumerationValues;
    public IfcUnit_IFC4 Unit;

    public new List<string> param_order = new List<string>{"Name", "EnumerationValues", "Unit"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyEnumeration_IFC4(string line) : base(line){}
    public IfcPropertyEnumeration_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyListValue_IFC4 : IfcSimpleProperty_IFC4 {
    public List<IfcValue_IFC4> ListValues;
    public IfcUnit_IFC4 Unit;

    public new List<string> param_order = new List<string>{"ListValues", "Unit"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyListValue_IFC4(string line) : base(line){}
    public IfcPropertyListValue_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyReferenceValue_IFC4 : IfcSimpleProperty_IFC4 {
    public string UsageName;
    public IfcObjectReferenceSelect_IFC4 PropertyReference;

    public new List<string> param_order = new List<string>{"UsageName", "PropertyReference"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyReferenceValue_IFC4(string line) : base(line){}
    public IfcPropertyReferenceValue_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertySet_IFC4 : IfcPropertySetDefinition_IFC4 {
    public List<IfcProperty_IFC4> HasProperties;

    public new List<string> param_order = new List<string>{"HasProperties"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertySet_IFC4(string line) : base(line){}
    public IfcPropertySet_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertySetDefinition_IFC4 : IfcPropertyDefinition_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertySetDefinition_IFC4(string line) : base(line){}
    public IfcPropertySetDefinition_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertySetTemplate_IFC4 : IfcPropertyTemplateDefinition_IFC4 {
    public string TemplateType;
    public string ApplicableEntity;
    public List<IfcPropertyTemplate_IFC4> HasPropertyTemplates;

    public new List<string> param_order = new List<string>{"TemplateType", "ApplicableEntity", "HasPropertyTemplates"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertySetTemplate_IFC4(string line) : base(line){}
    public IfcPropertySetTemplate_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertySingleValue_IFC4 : IfcSimpleProperty_IFC4 {
    public IfcValue_IFC4 NominalValue;
    public IfcUnit_IFC4 Unit;

    public new List<string> param_order = new List<string>{"NominalValue", "Unit"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertySingleValue_IFC4(string line) : base(line){}
    public IfcPropertySingleValue_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyTableValue_IFC4 : IfcSimpleProperty_IFC4 {
    public List<IfcValue_IFC4> DefiningValues;
    public List<IfcValue_IFC4> DefinedValues;
    public string Expression;
    public IfcUnit_IFC4 DefiningUnit;
    public IfcUnit_IFC4 DefinedUnit;
    public string CurveInterpolation;

    public new List<string> param_order = new List<string>{"DefiningValues", "DefinedValues", "Expression", "DefiningUnit", "DefinedUnit", "CurveInterpolation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyTableValue_IFC4(string line) : base(line){}
    public IfcPropertyTableValue_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyTemplate_IFC4 : IfcPropertyTemplateDefinition_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyTemplate_IFC4(string line) : base(line){}
    public IfcPropertyTemplate_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPropertyTemplateDefinition_IFC4 : IfcPropertyDefinition_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPropertyTemplateDefinition_IFC4(string line) : base(line){}
    public IfcPropertyTemplateDefinition_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProtectiveDevice_IFC4 : IfcFlowController_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProtectiveDevice_IFC4(string line) : base(line){}
    public IfcProtectiveDevice_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProtectiveDeviceTrippingUnit_IFC4 : IfcDistributionControlElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProtectiveDeviceTrippingUnit_IFC4(string line) : base(line){}
    public IfcProtectiveDeviceTrippingUnit_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProtectiveDeviceTrippingUnitType_IFC4 : IfcDistributionControlElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProtectiveDeviceTrippingUnitType_IFC4(string line) : base(line){}
    public IfcProtectiveDeviceTrippingUnitType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProtectiveDeviceType_IFC4 : IfcFlowControllerType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProtectiveDeviceType_IFC4(string line) : base(line){}
    public IfcProtectiveDeviceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcProxy_IFC4 : IfcProduct_IFC4 {
    public string ProxyType;
    public string Tag;

    public new List<string> param_order = new List<string>{"ProxyType", "Tag"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcProxy_IFC4(string line) : base(line){}
    public IfcProxy_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPump_IFC4 : IfcFlowMovingDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPump_IFC4(string line) : base(line){}
    public IfcPump_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcPumpType_IFC4 : IfcFlowMovingDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcPumpType_IFC4(string line) : base(line){}
    public IfcPumpType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcQuantityArea_IFC4 : IfcPhysicalSimpleQuantity_IFC4 {
    public string AreaValue;
    public string Formula;

    public new List<string> param_order = new List<string>{"AreaValue", "Formula"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcQuantityArea_IFC4(string line) : base(line){}
    public IfcQuantityArea_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcQuantityCount_IFC4 : IfcPhysicalSimpleQuantity_IFC4 {
    public string CountValue;
    public string Formula;

    public new List<string> param_order = new List<string>{"CountValue", "Formula"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcQuantityCount_IFC4(string line) : base(line){}
    public IfcQuantityCount_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcQuantityLength_IFC4 : IfcPhysicalSimpleQuantity_IFC4 {
    public string LengthValue;
    public string Formula;

    public new List<string> param_order = new List<string>{"LengthValue", "Formula"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcQuantityLength_IFC4(string line) : base(line){}
    public IfcQuantityLength_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcQuantitySet_IFC4 : IfcPropertySetDefinition_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcQuantitySet_IFC4(string line) : base(line){}
    public IfcQuantitySet_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcQuantityTime_IFC4 : IfcPhysicalSimpleQuantity_IFC4 {
    public string TimeValue;
    public string Formula;

    public new List<string> param_order = new List<string>{"TimeValue", "Formula"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcQuantityTime_IFC4(string line) : base(line){}
    public IfcQuantityTime_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcQuantityVolume_IFC4 : IfcPhysicalSimpleQuantity_IFC4 {
    public string VolumeValue;
    public string Formula;

    public new List<string> param_order = new List<string>{"VolumeValue", "Formula"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcQuantityVolume_IFC4(string line) : base(line){}
    public IfcQuantityVolume_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcQuantityWeight_IFC4 : IfcPhysicalSimpleQuantity_IFC4 {
    public string WeightValue;
    public string Formula;

    public new List<string> param_order = new List<string>{"WeightValue", "Formula"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcQuantityWeight_IFC4(string line) : base(line){}
    public IfcQuantityWeight_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRailing_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRailing_IFC4(string line) : base(line){}
    public IfcRailing_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRailingType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRailingType_IFC4(string line) : base(line){}
    public IfcRailingType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRamp_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRamp_IFC4(string line) : base(line){}
    public IfcRamp_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRampFlight_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRampFlight_IFC4(string line) : base(line){}
    public IfcRampFlight_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRampFlightType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRampFlightType_IFC4(string line) : base(line){}
    public IfcRampFlightType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRampType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRampType_IFC4(string line) : base(line){}
    public IfcRampType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRationalBSplineCurveWithKnots_IFC4 : IfcBSplineCurveWithKnots_IFC4 {
    public List<string> WeightsData;

    public new List<string> param_order = new List<string>{"WeightsData"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRationalBSplineCurveWithKnots_IFC4(string line) : base(line){}
    public IfcRationalBSplineCurveWithKnots_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRationalBSplineSurfaceWithKnots_IFC4 : IfcBSplineSurfaceWithKnots_IFC4 {
    public List<List<string>> WeightsData;

    public new List<string> param_order = new List<string>{"WeightsData"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRationalBSplineSurfaceWithKnots_IFC4(string line) : base(line){}
    public IfcRationalBSplineSurfaceWithKnots_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRectangleHollowProfileDef_IFC4 : IfcRectangleProfileDef_IFC4 {
    public string WallThickness;
    public string InnerFilletRadius;
    public string OuterFilletRadius;

    public new List<string> param_order = new List<string>{"WallThickness", "InnerFilletRadius", "OuterFilletRadius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRectangleHollowProfileDef_IFC4(string line) : base(line){}
    public IfcRectangleHollowProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRectangleProfileDef_IFC4 : IfcParameterizedProfileDef_IFC4 {
    public string XDim;
    public string YDim;

    public new List<string> param_order = new List<string>{"XDim", "YDim"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRectangleProfileDef_IFC4(string line) : base(line){}
    public IfcRectangleProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRectangularPyramid_IFC4 : IfcCsgPrimitive3D_IFC4 {
    public string XLength;
    public string YLength;
    public string Height;

    public new List<string> param_order = new List<string>{"XLength", "YLength", "Height"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRectangularPyramid_IFC4(string line) : base(line){}
    public IfcRectangularPyramid_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRectangularTrimmedSurface_IFC4 : IfcBoundedSurface_IFC4 {
    public IfcSurface_IFC4 BasisSurface;
    public string U1;
    public string V1;
    public string U2;
    public string V2;
    public string Usense;
    public string Vsense;

    public new List<string> param_order = new List<string>{"BasisSurface", "U1", "V1", "U2", "V2", "Usense", "Vsense"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRectangularTrimmedSurface_IFC4(string line) : base(line){}
    public IfcRectangularTrimmedSurface_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRecurrencePattern_IFC4 : Entity {
    public string RecurrenceType;
    public List<string> DayComponent;
    public List<string> WeekdayComponent;
    public List<string> MonthComponent;
    public string Position;
    public string Interval;
    public string Occurrences;
    public List<IfcTimePeriod_IFC4> TimePeriods;

    public new List<string> param_order = new List<string>{"RecurrenceType", "DayComponent", "WeekdayComponent", "MonthComponent", "Position", "Interval", "Occurrences", "TimePeriods"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRecurrencePattern_IFC4(string line) : base(line){}
    public IfcRecurrencePattern_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcReference_IFC4 : Entity {
    public string TypeIdentifier;
    public string AttributeIdentifier;
    public string InstanceName;
    public List<string> ListPositions;
    public IfcReference_IFC4 InnerReference;

    public new List<string> param_order = new List<string>{"TypeIdentifier", "AttributeIdentifier", "InstanceName", "ListPositions", "InnerReference"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReference_IFC4(string line) : base(line){}
    public IfcReference_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRegularTimeSeries_IFC4 : IfcTimeSeries_IFC4 {
    public string TimeStep;
    public List<IfcTimeSeriesValue_IFC4> Values;

    public new List<string> param_order = new List<string>{"TimeStep", "Values"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRegularTimeSeries_IFC4(string line) : base(line){}
    public IfcRegularTimeSeries_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcReinforcementBarProperties_IFC4 : IfcPreDefinedProperties_IFC4 {
    public string TotalCrossSectionArea;
    public string SteelGrade;
    public string BarSurface;
    public string EffectiveDepth;
    public string NominalBarDiameter;
    public string BarCount;

    public new List<string> param_order = new List<string>{"TotalCrossSectionArea", "SteelGrade", "BarSurface", "EffectiveDepth", "NominalBarDiameter", "BarCount"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReinforcementBarProperties_IFC4(string line) : base(line){}
    public IfcReinforcementBarProperties_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcReinforcementDefinitionProperties_IFC4 : IfcPreDefinedPropertySet_IFC4 {
    public string DefinitionType;
    public List<IfcSectionReinforcementProperties_IFC4> ReinforcementSectionDefinitions;

    public new List<string> param_order = new List<string>{"DefinitionType", "ReinforcementSectionDefinitions"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReinforcementDefinitionProperties_IFC4(string line) : base(line){}
    public IfcReinforcementDefinitionProperties_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcReinforcingBar_IFC4 : IfcReinforcingElement_IFC4 {
    public string NominalDiameter;
    public string CrossSectionArea;
    public string BarLength;
    public string PredefinedType;
    public string BarSurface;

    public new List<string> param_order = new List<string>{"NominalDiameter", "CrossSectionArea", "BarLength", "PredefinedType", "BarSurface"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReinforcingBar_IFC4(string line) : base(line){}
    public IfcReinforcingBar_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcReinforcingBarType_IFC4 : IfcReinforcingElementType_IFC4 {
    public string PredefinedType;
    public string NominalDiameter;
    public string CrossSectionArea;
    public string BarLength;
    public string BarSurface;
    public string BendingShapeCode;
    public List<IfcBendingParameterSelect_IFC4> BendingParameters;

    public new List<string> param_order = new List<string>{"PredefinedType", "NominalDiameter", "CrossSectionArea", "BarLength", "BarSurface", "BendingShapeCode", "BendingParameters"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReinforcingBarType_IFC4(string line) : base(line){}
    public IfcReinforcingBarType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcReinforcingElement_IFC4 : IfcElementComponent_IFC4 {
    public string SteelGrade;

    public new List<string> param_order = new List<string>{"SteelGrade"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReinforcingElement_IFC4(string line) : base(line){}
    public IfcReinforcingElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcReinforcingElementType_IFC4 : IfcElementComponentType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReinforcingElementType_IFC4(string line) : base(line){}
    public IfcReinforcingElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcReinforcingMesh_IFC4 : IfcReinforcingElement_IFC4 {
    public string MeshLength;
    public string MeshWidth;
    public string LongitudinalBarNominalDiameter;
    public string TransverseBarNominalDiameter;
    public string LongitudinalBarCrossSectionArea;
    public string TransverseBarCrossSectionArea;
    public string LongitudinalBarSpacing;
    public string TransverseBarSpacing;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"MeshLength", "MeshWidth", "LongitudinalBarNominalDiameter", "TransverseBarNominalDiameter", "LongitudinalBarCrossSectionArea", "TransverseBarCrossSectionArea", "LongitudinalBarSpacing", "TransverseBarSpacing", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReinforcingMesh_IFC4(string line) : base(line){}
    public IfcReinforcingMesh_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcReinforcingMeshType_IFC4 : IfcReinforcingElementType_IFC4 {
    public string PredefinedType;
    public string MeshLength;
    public string MeshWidth;
    public string LongitudinalBarNominalDiameter;
    public string TransverseBarNominalDiameter;
    public string LongitudinalBarCrossSectionArea;
    public string TransverseBarCrossSectionArea;
    public string LongitudinalBarSpacing;
    public string TransverseBarSpacing;
    public string BendingShapeCode;
    public List<IfcBendingParameterSelect_IFC4> BendingParameters;

    public new List<string> param_order = new List<string>{"PredefinedType", "MeshLength", "MeshWidth", "LongitudinalBarNominalDiameter", "TransverseBarNominalDiameter", "LongitudinalBarCrossSectionArea", "TransverseBarCrossSectionArea", "LongitudinalBarSpacing", "TransverseBarSpacing", "BendingShapeCode", "BendingParameters"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReinforcingMeshType_IFC4(string line) : base(line){}
    public IfcReinforcingMeshType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAggregates_IFC4 : IfcRelDecomposes_IFC4 {
    public IfcObjectDefinition_IFC4 RelatingObject;
    public List<IfcObjectDefinition_IFC4> RelatedObjects;

    public new List<string> param_order = new List<string>{"RelatingObject", "RelatedObjects"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAggregates_IFC4(string line) : base(line){}
    public IfcRelAggregates_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssigns_IFC4 : IfcRelationship_IFC4 {
    public List<IfcObjectDefinition_IFC4> RelatedObjects;
    public string RelatedObjectsType;

    public new List<string> param_order = new List<string>{"RelatedObjects", "RelatedObjectsType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssigns_IFC4(string line) : base(line){}
    public IfcRelAssigns_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsToActor_IFC4 : IfcRelAssigns_IFC4 {
    public IfcActor_IFC4 RelatingActor;
    public IfcActorRole_IFC4 ActingRole;

    public new List<string> param_order = new List<string>{"RelatingActor", "ActingRole"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsToActor_IFC4(string line) : base(line){}
    public IfcRelAssignsToActor_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsToControl_IFC4 : IfcRelAssigns_IFC4 {
    public IfcControl_IFC4 RelatingControl;

    public new List<string> param_order = new List<string>{"RelatingControl"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsToControl_IFC4(string line) : base(line){}
    public IfcRelAssignsToControl_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsToGroup_IFC4 : IfcRelAssigns_IFC4 {
    public IfcGroup_IFC4 RelatingGroup;

    public new List<string> param_order = new List<string>{"RelatingGroup"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsToGroup_IFC4(string line) : base(line){}
    public IfcRelAssignsToGroup_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsToGroupByFactor_IFC4 : IfcRelAssignsToGroup_IFC4 {
    public string Factor;

    public new List<string> param_order = new List<string>{"Factor"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsToGroupByFactor_IFC4(string line) : base(line){}
    public IfcRelAssignsToGroupByFactor_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsToProcess_IFC4 : IfcRelAssigns_IFC4 {
    public IfcProcessSelect_IFC4 RelatingProcess;
    public IfcMeasureWithUnit_IFC4 QuantityInProcess;

    public new List<string> param_order = new List<string>{"RelatingProcess", "QuantityInProcess"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsToProcess_IFC4(string line) : base(line){}
    public IfcRelAssignsToProcess_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsToProduct_IFC4 : IfcRelAssigns_IFC4 {
    public IfcProductSelect_IFC4 RelatingProduct;

    public new List<string> param_order = new List<string>{"RelatingProduct"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsToProduct_IFC4(string line) : base(line){}
    public IfcRelAssignsToProduct_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssignsToResource_IFC4 : IfcRelAssigns_IFC4 {
    public IfcResourceSelect_IFC4 RelatingResource;

    public new List<string> param_order = new List<string>{"RelatingResource"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssignsToResource_IFC4(string line) : base(line){}
    public IfcRelAssignsToResource_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociates_IFC4 : IfcRelationship_IFC4 {
    public List<IfcDefinitionSelect_IFC4> RelatedObjects;

    public new List<string> param_order = new List<string>{"RelatedObjects"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociates_IFC4(string line) : base(line){}
    public IfcRelAssociates_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociatesApproval_IFC4 : IfcRelAssociates_IFC4 {
    public IfcApproval_IFC4 RelatingApproval;

    public new List<string> param_order = new List<string>{"RelatingApproval"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociatesApproval_IFC4(string line) : base(line){}
    public IfcRelAssociatesApproval_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociatesClassification_IFC4 : IfcRelAssociates_IFC4 {
    public IfcClassificationSelect_IFC4 RelatingClassification;

    public new List<string> param_order = new List<string>{"RelatingClassification"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociatesClassification_IFC4(string line) : base(line){}
    public IfcRelAssociatesClassification_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociatesConstraint_IFC4 : IfcRelAssociates_IFC4 {
    public string Intent;
    public IfcConstraint_IFC4 RelatingConstraint;

    public new List<string> param_order = new List<string>{"Intent", "RelatingConstraint"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociatesConstraint_IFC4(string line) : base(line){}
    public IfcRelAssociatesConstraint_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociatesDocument_IFC4 : IfcRelAssociates_IFC4 {
    public IfcDocumentSelect_IFC4 RelatingDocument;

    public new List<string> param_order = new List<string>{"RelatingDocument"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociatesDocument_IFC4(string line) : base(line){}
    public IfcRelAssociatesDocument_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociatesLibrary_IFC4 : IfcRelAssociates_IFC4 {
    public IfcLibrarySelect_IFC4 RelatingLibrary;

    public new List<string> param_order = new List<string>{"RelatingLibrary"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociatesLibrary_IFC4(string line) : base(line){}
    public IfcRelAssociatesLibrary_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelAssociatesMaterial_IFC4 : IfcRelAssociates_IFC4 {
    public IfcMaterialSelect_IFC4 RelatingMaterial;

    public new List<string> param_order = new List<string>{"RelatingMaterial"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelAssociatesMaterial_IFC4(string line) : base(line){}
    public IfcRelAssociatesMaterial_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnects_IFC4 : IfcRelationship_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnects_IFC4(string line) : base(line){}
    public IfcRelConnects_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsElements_IFC4 : IfcRelConnects_IFC4 {
    public IfcConnectionGeometry_IFC4 ConnectionGeometry;
    public IfcElement_IFC4 RelatingElement;
    public IfcElement_IFC4 RelatedElement;

    public new List<string> param_order = new List<string>{"ConnectionGeometry", "RelatingElement", "RelatedElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsElements_IFC4(string line) : base(line){}
    public IfcRelConnectsElements_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsPathElements_IFC4 : IfcRelConnectsElements_IFC4 {
    public List<string> RelatingPriorities;
    public List<string> RelatedPriorities;
    public string RelatedConnectionType;
    public string RelatingConnectionType;

    public new List<string> param_order = new List<string>{"RelatingPriorities", "RelatedPriorities", "RelatedConnectionType", "RelatingConnectionType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsPathElements_IFC4(string line) : base(line){}
    public IfcRelConnectsPathElements_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsPortToElement_IFC4 : IfcRelConnects_IFC4 {
    public IfcPort_IFC4 RelatingPort;
    public IfcDistributionElement_IFC4 RelatedElement;

    public new List<string> param_order = new List<string>{"RelatingPort", "RelatedElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsPortToElement_IFC4(string line) : base(line){}
    public IfcRelConnectsPortToElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsPorts_IFC4 : IfcRelConnects_IFC4 {
    public IfcPort_IFC4 RelatingPort;
    public IfcPort_IFC4 RelatedPort;
    public IfcElement_IFC4 RealizingElement;

    public new List<string> param_order = new List<string>{"RelatingPort", "RelatedPort", "RealizingElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsPorts_IFC4(string line) : base(line){}
    public IfcRelConnectsPorts_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsStructuralActivity_IFC4 : IfcRelConnects_IFC4 {
    public IfcStructuralActivityAssignmentSelect_IFC4 RelatingElement;
    public IfcStructuralActivity_IFC4 RelatedStructuralActivity;

    public new List<string> param_order = new List<string>{"RelatingElement", "RelatedStructuralActivity"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsStructuralActivity_IFC4(string line) : base(line){}
    public IfcRelConnectsStructuralActivity_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsStructuralMember_IFC4 : IfcRelConnects_IFC4 {
    public IfcStructuralMember_IFC4 RelatingStructuralMember;
    public IfcStructuralConnection_IFC4 RelatedStructuralConnection;
    public IfcBoundaryCondition_IFC4 AppliedCondition;
    public IfcStructuralConnectionCondition_IFC4 AdditionalConditions;
    public string SupportedLength;
    public IfcAxis2Placement3D_IFC4 ConditionCoordinateSystem;

    public new List<string> param_order = new List<string>{"RelatingStructuralMember", "RelatedStructuralConnection", "AppliedCondition", "AdditionalConditions", "SupportedLength", "ConditionCoordinateSystem"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsStructuralMember_IFC4(string line) : base(line){}
    public IfcRelConnectsStructuralMember_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsWithEccentricity_IFC4 : IfcRelConnectsStructuralMember_IFC4 {
    public IfcConnectionGeometry_IFC4 ConnectionConstraint;

    public new List<string> param_order = new List<string>{"ConnectionConstraint"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsWithEccentricity_IFC4(string line) : base(line){}
    public IfcRelConnectsWithEccentricity_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelConnectsWithRealizingElements_IFC4 : IfcRelConnectsElements_IFC4 {
    public List<IfcElement_IFC4> RealizingElements;
    public string ConnectionType;

    public new List<string> param_order = new List<string>{"RealizingElements", "ConnectionType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelConnectsWithRealizingElements_IFC4(string line) : base(line){}
    public IfcRelConnectsWithRealizingElements_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelContainedInSpatialStructure_IFC4 : IfcRelConnects_IFC4 {
    public List<IfcProduct_IFC4> RelatedElements;
    public IfcSpatialElement_IFC4 RelatingStructure;

    public new List<string> param_order = new List<string>{"RelatedElements", "RelatingStructure"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelContainedInSpatialStructure_IFC4(string line) : base(line){}
    public IfcRelContainedInSpatialStructure_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelCoversBldgElements_IFC4 : IfcRelConnects_IFC4 {
    public IfcElement_IFC4 RelatingBuildingElement;
    public List<IfcCovering_IFC4> RelatedCoverings;

    public new List<string> param_order = new List<string>{"RelatingBuildingElement", "RelatedCoverings"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelCoversBldgElements_IFC4(string line) : base(line){}
    public IfcRelCoversBldgElements_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelCoversSpaces_IFC4 : IfcRelConnects_IFC4 {
    public IfcSpace_IFC4 RelatingSpace;
    public List<IfcCovering_IFC4> RelatedCoverings;

    public new List<string> param_order = new List<string>{"RelatingSpace", "RelatedCoverings"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelCoversSpaces_IFC4(string line) : base(line){}
    public IfcRelCoversSpaces_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelDeclares_IFC4 : IfcRelationship_IFC4 {
    public IfcContext_IFC4 RelatingContext;
    public List<IfcDefinitionSelect_IFC4> RelatedDefinitions;

    public new List<string> param_order = new List<string>{"RelatingContext", "RelatedDefinitions"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelDeclares_IFC4(string line) : base(line){}
    public IfcRelDeclares_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelDecomposes_IFC4 : IfcRelationship_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelDecomposes_IFC4(string line) : base(line){}
    public IfcRelDecomposes_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelDefines_IFC4 : IfcRelationship_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelDefines_IFC4(string line) : base(line){}
    public IfcRelDefines_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelDefinesByObject_IFC4 : IfcRelDefines_IFC4 {
    public List<IfcObject_IFC4> RelatedObjects;
    public IfcObject_IFC4 RelatingObject;

    public new List<string> param_order = new List<string>{"RelatedObjects", "RelatingObject"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelDefinesByObject_IFC4(string line) : base(line){}
    public IfcRelDefinesByObject_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelDefinesByProperties_IFC4 : IfcRelDefines_IFC4 {
    public List<IfcObjectDefinition_IFC4> RelatedObjects;
    public IfcPropertySetDefinitionSelect_IFC4 RelatingPropertyDefinition;

    public new List<string> param_order = new List<string>{"RelatedObjects", "RelatingPropertyDefinition"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelDefinesByProperties_IFC4(string line) : base(line){}
    public IfcRelDefinesByProperties_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelDefinesByTemplate_IFC4 : IfcRelDefines_IFC4 {
    public List<IfcPropertySetDefinition_IFC4> RelatedPropertySets;
    public IfcPropertySetTemplate_IFC4 RelatingTemplate;

    public new List<string> param_order = new List<string>{"RelatedPropertySets", "RelatingTemplate"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelDefinesByTemplate_IFC4(string line) : base(line){}
    public IfcRelDefinesByTemplate_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelDefinesByType_IFC4 : IfcRelDefines_IFC4 {
    public List<IfcObject_IFC4> RelatedObjects;
    public IfcTypeObject_IFC4 RelatingType;

    public new List<string> param_order = new List<string>{"RelatedObjects", "RelatingType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelDefinesByType_IFC4(string line) : base(line){}
    public IfcRelDefinesByType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelFillsElement_IFC4 : IfcRelConnects_IFC4 {
    public IfcOpeningElement_IFC4 RelatingOpeningElement;
    public IfcElement_IFC4 RelatedBuildingElement;

    public new List<string> param_order = new List<string>{"RelatingOpeningElement", "RelatedBuildingElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelFillsElement_IFC4(string line) : base(line){}
    public IfcRelFillsElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelFlowControlElements_IFC4 : IfcRelConnects_IFC4 {
    public List<IfcDistributionControlElement_IFC4> RelatedControlElements;
    public IfcDistributionFlowElement_IFC4 RelatingFlowElement;

    public new List<string> param_order = new List<string>{"RelatedControlElements", "RelatingFlowElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelFlowControlElements_IFC4(string line) : base(line){}
    public IfcRelFlowControlElements_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelInterferesElements_IFC4 : IfcRelConnects_IFC4 {
    public IfcElement_IFC4 RelatingElement;
    public IfcElement_IFC4 RelatedElement;
    public IfcConnectionGeometry_IFC4 InterferenceGeometry;
    public string InterferenceType;
    public string ImpliedOrder;

    public new List<string> param_order = new List<string>{"RelatingElement", "RelatedElement", "InterferenceGeometry", "InterferenceType", "ImpliedOrder"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelInterferesElements_IFC4(string line) : base(line){}
    public IfcRelInterferesElements_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelNests_IFC4 : IfcRelDecomposes_IFC4 {
    public IfcObjectDefinition_IFC4 RelatingObject;
    public List<IfcObjectDefinition_IFC4> RelatedObjects;

    public new List<string> param_order = new List<string>{"RelatingObject", "RelatedObjects"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelNests_IFC4(string line) : base(line){}
    public IfcRelNests_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelProjectsElement_IFC4 : IfcRelDecomposes_IFC4 {
    public IfcElement_IFC4 RelatingElement;
    public IfcFeatureElementAddition_IFC4 RelatedFeatureElement;

    public new List<string> param_order = new List<string>{"RelatingElement", "RelatedFeatureElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelProjectsElement_IFC4(string line) : base(line){}
    public IfcRelProjectsElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelReferencedInSpatialStructure_IFC4 : IfcRelConnects_IFC4 {
    public List<IfcProduct_IFC4> RelatedElements;
    public IfcSpatialElement_IFC4 RelatingStructure;

    public new List<string> param_order = new List<string>{"RelatedElements", "RelatingStructure"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelReferencedInSpatialStructure_IFC4(string line) : base(line){}
    public IfcRelReferencedInSpatialStructure_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelSequence_IFC4 : IfcRelConnects_IFC4 {
    public IfcProcess_IFC4 RelatingProcess;
    public IfcProcess_IFC4 RelatedProcess;
    public IfcLagTime_IFC4 TimeLag;
    public string SequenceType;
    public string UserDefinedSequenceType;

    public new List<string> param_order = new List<string>{"RelatingProcess", "RelatedProcess", "TimeLag", "SequenceType", "UserDefinedSequenceType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelSequence_IFC4(string line) : base(line){}
    public IfcRelSequence_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelServicesBuildings_IFC4 : IfcRelConnects_IFC4 {
    public IfcSystem_IFC4 RelatingSystem;
    public List<IfcSpatialElement_IFC4> RelatedBuildings;

    public new List<string> param_order = new List<string>{"RelatingSystem", "RelatedBuildings"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelServicesBuildings_IFC4(string line) : base(line){}
    public IfcRelServicesBuildings_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelSpaceBoundary_IFC4 : IfcRelConnects_IFC4 {
    public IfcSpaceBoundarySelect_IFC4 RelatingSpace;
    public IfcElement_IFC4 RelatedBuildingElement;
    public IfcConnectionGeometry_IFC4 ConnectionGeometry;
    public string PhysicalOrVirtualBoundary;
    public string InternalOrExternalBoundary;

    public new List<string> param_order = new List<string>{"RelatingSpace", "RelatedBuildingElement", "ConnectionGeometry", "PhysicalOrVirtualBoundary", "InternalOrExternalBoundary"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelSpaceBoundary_IFC4(string line) : base(line){}
    public IfcRelSpaceBoundary_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelSpaceBoundary1stLevel_IFC4 : IfcRelSpaceBoundary_IFC4 {
    public IfcRelSpaceBoundary1stLevel_IFC4 ParentBoundary;

    public new List<string> param_order = new List<string>{"ParentBoundary"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelSpaceBoundary1stLevel_IFC4(string line) : base(line){}
    public IfcRelSpaceBoundary1stLevel_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelSpaceBoundary2ndLevel_IFC4 : IfcRelSpaceBoundary1stLevel_IFC4 {
    public IfcRelSpaceBoundary2ndLevel_IFC4 CorrespondingBoundary;

    public new List<string> param_order = new List<string>{"CorrespondingBoundary"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelSpaceBoundary2ndLevel_IFC4(string line) : base(line){}
    public IfcRelSpaceBoundary2ndLevel_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelVoidsElement_IFC4 : IfcRelDecomposes_IFC4 {
    public IfcElement_IFC4 RelatingBuildingElement;
    public IfcFeatureElementSubtraction_IFC4 RelatedOpeningElement;

    public new List<string> param_order = new List<string>{"RelatingBuildingElement", "RelatedOpeningElement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelVoidsElement_IFC4(string line) : base(line){}
    public IfcRelVoidsElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRelationship_IFC4 : IfcRoot_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRelationship_IFC4(string line) : base(line){}
    public IfcRelationship_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcReparametrisedCompositeCurveSegment_IFC4 : IfcCompositeCurveSegment_IFC4 {
    public string ParamLength;

    public new List<string> param_order = new List<string>{"ParamLength"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcReparametrisedCompositeCurveSegment_IFC4(string line) : base(line){}
    public IfcReparametrisedCompositeCurveSegment_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRepresentation_IFC4 : Entity {
    public IfcRepresentationContext_IFC4 ContextOfItems;
    public string RepresentationIdentifier;
    public string RepresentationType;
    public List<IfcRepresentationItem_IFC4> Items;

    public new List<string> param_order = new List<string>{"ContextOfItems", "RepresentationIdentifier", "RepresentationType", "Items"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRepresentation_IFC4(string line) : base(line){}
    public IfcRepresentation_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRepresentationContext_IFC4 : Entity {
    public string ContextIdentifier;
    public string ContextType;

    public new List<string> param_order = new List<string>{"ContextIdentifier", "ContextType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRepresentationContext_IFC4(string line) : base(line){}
    public IfcRepresentationContext_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRepresentationItem_IFC4 : Entity {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRepresentationItem_IFC4(string line) : base(line){}
    public IfcRepresentationItem_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRepresentationMap_IFC4 : Entity {
    public IfcAxis2Placement_IFC4 MappingOrigin;
    public IfcRepresentation_IFC4 MappedRepresentation;

    public new List<string> param_order = new List<string>{"MappingOrigin", "MappedRepresentation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRepresentationMap_IFC4(string line) : base(line){}
    public IfcRepresentationMap_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcResource_IFC4 : IfcObject_IFC4 {
    public string Identification;
    public string LongDescription;

    public new List<string> param_order = new List<string>{"Identification", "LongDescription"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcResource_IFC4(string line) : base(line){}
    public IfcResource_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcResourceApprovalRelationship_IFC4 : IfcResourceLevelRelationship_IFC4 {
    public List<IfcResourceObjectSelect_IFC4> RelatedResourceObjects;
    public IfcApproval_IFC4 RelatingApproval;

    public new List<string> param_order = new List<string>{"RelatedResourceObjects", "RelatingApproval"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcResourceApprovalRelationship_IFC4(string line) : base(line){}
    public IfcResourceApprovalRelationship_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcResourceConstraintRelationship_IFC4 : IfcResourceLevelRelationship_IFC4 {
    public IfcConstraint_IFC4 RelatingConstraint;
    public List<IfcResourceObjectSelect_IFC4> RelatedResourceObjects;

    public new List<string> param_order = new List<string>{"RelatingConstraint", "RelatedResourceObjects"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcResourceConstraintRelationship_IFC4(string line) : base(line){}
    public IfcResourceConstraintRelationship_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcResourceLevelRelationship_IFC4 : Entity {
    public string Name;
    public string Description;

    public new List<string> param_order = new List<string>{"Name", "Description"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcResourceLevelRelationship_IFC4(string line) : base(line){}
    public IfcResourceLevelRelationship_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcResourceTime_IFC4 : IfcSchedulingTime_IFC4 {
    public string ScheduleWork;
    public string ScheduleUsage;
    public string ScheduleStart;
    public string ScheduleFinish;
    public string ScheduleContour;
    public string LevelingDelay;
    public string IsOverAllocated;
    public string StatusTime;
    public string ActualWork;
    public string ActualUsage;
    public string ActualStart;
    public string ActualFinish;
    public string RemainingWork;
    public string RemainingUsage;
    public string Completion;

    public new List<string> param_order = new List<string>{"ScheduleWork", "ScheduleUsage", "ScheduleStart", "ScheduleFinish", "ScheduleContour", "LevelingDelay", "IsOverAllocated", "StatusTime", "ActualWork", "ActualUsage", "ActualStart", "ActualFinish", "RemainingWork", "RemainingUsage", "Completion"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcResourceTime_IFC4(string line) : base(line){}
    public IfcResourceTime_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRevolvedAreaSolid_IFC4 : IfcSweptAreaSolid_IFC4 {
    public IfcAxis1Placement_IFC4 Axis;
    public string Angle;

    public new List<string> param_order = new List<string>{"Axis", "Angle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRevolvedAreaSolid_IFC4(string line) : base(line){}
    public IfcRevolvedAreaSolid_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRevolvedAreaSolidTapered_IFC4 : IfcRevolvedAreaSolid_IFC4 {
    public IfcProfileDef_IFC4 EndSweptArea;

    public new List<string> param_order = new List<string>{"EndSweptArea"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRevolvedAreaSolidTapered_IFC4(string line) : base(line){}
    public IfcRevolvedAreaSolidTapered_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRightCircularCone_IFC4 : IfcCsgPrimitive3D_IFC4 {
    public string Height;
    public string BottomRadius;

    public new List<string> param_order = new List<string>{"Height", "BottomRadius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRightCircularCone_IFC4(string line) : base(line){}
    public IfcRightCircularCone_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRightCircularCylinder_IFC4 : IfcCsgPrimitive3D_IFC4 {
    public string Height;
    public string Radius;

    public new List<string> param_order = new List<string>{"Height", "Radius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRightCircularCylinder_IFC4(string line) : base(line){}
    public IfcRightCircularCylinder_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRoof_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRoof_IFC4(string line) : base(line){}
    public IfcRoof_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRoofType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRoofType_IFC4(string line) : base(line){}
    public IfcRoofType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRoot_IFC4 : Entity {
    public string GlobalId;
    public IfcOwnerHistory_IFC4 OwnerHistory;
    public string Name;
    public string Description;

    public new List<string> param_order = new List<string>{"GlobalId", "OwnerHistory", "Name", "Description"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRoot_IFC4(string line) : base(line){}
    public IfcRoot_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcRoundedRectangleProfileDef_IFC4 : IfcRectangleProfileDef_IFC4 {
    public string RoundingRadius;

    public new List<string> param_order = new List<string>{"RoundingRadius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcRoundedRectangleProfileDef_IFC4(string line) : base(line){}
    public IfcRoundedRectangleProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSIUnit_IFC4 : IfcNamedUnit_IFC4 {
    public string Prefix;
    public string Name;

    public new List<string> param_order = new List<string>{"Prefix", "Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSIUnit_IFC4(string line) : base(line){}
    public IfcSIUnit_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSanitaryTerminal_IFC4 : IfcFlowTerminal_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSanitaryTerminal_IFC4(string line) : base(line){}
    public IfcSanitaryTerminal_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSanitaryTerminalType_IFC4 : IfcFlowTerminalType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSanitaryTerminalType_IFC4(string line) : base(line){}
    public IfcSanitaryTerminalType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSchedulingTime_IFC4 : Entity {
    public string Name;
    public string DataOrigin;
    public string UserDefinedDataOrigin;

    public new List<string> param_order = new List<string>{"Name", "DataOrigin", "UserDefinedDataOrigin"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSchedulingTime_IFC4(string line) : base(line){}
    public IfcSchedulingTime_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSeamCurve_IFC4 : IfcSurfaceCurve_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSeamCurve_IFC4(string line) : base(line){}
    public IfcSeamCurve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSectionProperties_IFC4 : IfcPreDefinedProperties_IFC4 {
    public string SectionType;
    public IfcProfileDef_IFC4 StartProfile;
    public IfcProfileDef_IFC4 EndProfile;

    public new List<string> param_order = new List<string>{"SectionType", "StartProfile", "EndProfile"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSectionProperties_IFC4(string line) : base(line){}
    public IfcSectionProperties_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSectionReinforcementProperties_IFC4 : IfcPreDefinedProperties_IFC4 {
    public string LongitudinalStartPosition;
    public string LongitudinalEndPosition;
    public string TransversePosition;
    public string ReinforcementRole;
    public IfcSectionProperties_IFC4 SectionDefinition;
    public List<IfcReinforcementBarProperties_IFC4> CrossSectionReinforcementDefinitions;

    public new List<string> param_order = new List<string>{"LongitudinalStartPosition", "LongitudinalEndPosition", "TransversePosition", "ReinforcementRole", "SectionDefinition", "CrossSectionReinforcementDefinitions"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSectionReinforcementProperties_IFC4(string line) : base(line){}
    public IfcSectionReinforcementProperties_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSectionedSpine_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public IfcCompositeCurve_IFC4 SpineCurve;
    public List<IfcProfileDef_IFC4> CrossSections;
    public List<IfcAxis2Placement3D_IFC4> CrossSectionPositions;

    public new List<string> param_order = new List<string>{"SpineCurve", "CrossSections", "CrossSectionPositions"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSectionedSpine_IFC4(string line) : base(line){}
    public IfcSectionedSpine_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSensor_IFC4 : IfcDistributionControlElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSensor_IFC4(string line) : base(line){}
    public IfcSensor_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSensorType_IFC4 : IfcDistributionControlElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSensorType_IFC4(string line) : base(line){}
    public IfcSensorType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcShadingDevice_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcShadingDevice_IFC4(string line) : base(line){}
    public IfcShadingDevice_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcShadingDeviceType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcShadingDeviceType_IFC4(string line) : base(line){}
    public IfcShadingDeviceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcShapeAspect_IFC4 : Entity {
    public List<IfcShapeModel_IFC4> ShapeRepresentations;
    public string Name;
    public string Description;
    public string ProductDefinitional;
    public IfcProductRepresentationSelect_IFC4 PartOfProductDefinitionShape;

    public new List<string> param_order = new List<string>{"ShapeRepresentations", "Name", "Description", "ProductDefinitional", "PartOfProductDefinitionShape"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcShapeAspect_IFC4(string line) : base(line){}
    public IfcShapeAspect_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcShapeModel_IFC4 : IfcRepresentation_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcShapeModel_IFC4(string line) : base(line){}
    public IfcShapeModel_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcShapeRepresentation_IFC4 : IfcShapeModel_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcShapeRepresentation_IFC4(string line) : base(line){}
    public IfcShapeRepresentation_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcShellBasedSurfaceModel_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public List<IfcShell_IFC4> SbsmBoundary;

    public new List<string> param_order = new List<string>{"SbsmBoundary"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcShellBasedSurfaceModel_IFC4(string line) : base(line){}
    public IfcShellBasedSurfaceModel_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSimpleProperty_IFC4 : IfcProperty_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSimpleProperty_IFC4(string line) : base(line){}
    public IfcSimpleProperty_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSimplePropertyTemplate_IFC4 : IfcPropertyTemplate_IFC4 {
    public string TemplateType;
    public string PrimaryMeasureType;
    public string SecondaryMeasureType;
    public IfcPropertyEnumeration_IFC4 Enumerators;
    public IfcUnit_IFC4 PrimaryUnit;
    public IfcUnit_IFC4 SecondaryUnit;
    public string Expression;
    public string AccessState;

    public new List<string> param_order = new List<string>{"TemplateType", "PrimaryMeasureType", "SecondaryMeasureType", "Enumerators", "PrimaryUnit", "SecondaryUnit", "Expression", "AccessState"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSimplePropertyTemplate_IFC4(string line) : base(line){}
    public IfcSimplePropertyTemplate_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSite_IFC4 : IfcSpatialStructureElement_IFC4 {
    public string RefLatitude;
    public string RefLongitude;
    public string RefElevation;
    public string LandTitleNumber;
    public IfcPostalAddress_IFC4 SiteAddress;

    public new List<string> param_order = new List<string>{"RefLatitude", "RefLongitude", "RefElevation", "LandTitleNumber", "SiteAddress"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSite_IFC4(string line) : base(line){}
    public IfcSite_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSlab_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSlab_IFC4(string line) : base(line){}
    public IfcSlab_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSlabElementedCase_IFC4 : IfcSlab_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSlabElementedCase_IFC4(string line) : base(line){}
    public IfcSlabElementedCase_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSlabStandardCase_IFC4 : IfcSlab_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSlabStandardCase_IFC4(string line) : base(line){}
    public IfcSlabStandardCase_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSlabType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSlabType_IFC4(string line) : base(line){}
    public IfcSlabType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSlippageConnectionCondition_IFC4 : IfcStructuralConnectionCondition_IFC4 {
    public string SlippageX;
    public string SlippageY;
    public string SlippageZ;

    public new List<string> param_order = new List<string>{"SlippageX", "SlippageY", "SlippageZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSlippageConnectionCondition_IFC4(string line) : base(line){}
    public IfcSlippageConnectionCondition_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSolarDevice_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSolarDevice_IFC4(string line) : base(line){}
    public IfcSolarDevice_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSolarDeviceType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSolarDeviceType_IFC4(string line) : base(line){}
    public IfcSolarDeviceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSolidModel_IFC4 : IfcGeometricRepresentationItem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSolidModel_IFC4(string line) : base(line){}
    public IfcSolidModel_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSpace_IFC4 : IfcSpatialStructureElement_IFC4 {
    public string PredefinedType;
    public string ElevationWithFlooring;

    public new List<string> param_order = new List<string>{"PredefinedType", "ElevationWithFlooring"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpace_IFC4(string line) : base(line){}
    public IfcSpace_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSpaceHeater_IFC4 : IfcFlowTerminal_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpaceHeater_IFC4(string line) : base(line){}
    public IfcSpaceHeater_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSpaceHeaterType_IFC4 : IfcFlowTerminalType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpaceHeaterType_IFC4(string line) : base(line){}
    public IfcSpaceHeaterType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSpaceType_IFC4 : IfcSpatialStructureElementType_IFC4 {
    public string PredefinedType;
    public string LongName;

    public new List<string> param_order = new List<string>{"PredefinedType", "LongName"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpaceType_IFC4(string line) : base(line){}
    public IfcSpaceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSpatialElement_IFC4 : IfcProduct_IFC4 {
    public string LongName;

    public new List<string> param_order = new List<string>{"LongName"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpatialElement_IFC4(string line) : base(line){}
    public IfcSpatialElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSpatialElementType_IFC4 : IfcTypeProduct_IFC4 {
    public string ElementType;

    public new List<string> param_order = new List<string>{"ElementType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpatialElementType_IFC4(string line) : base(line){}
    public IfcSpatialElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSpatialStructureElement_IFC4 : IfcSpatialElement_IFC4 {
    public string CompositionType;

    public new List<string> param_order = new List<string>{"CompositionType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpatialStructureElement_IFC4(string line) : base(line){}
    public IfcSpatialStructureElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSpatialStructureElementType_IFC4 : IfcSpatialElementType_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpatialStructureElementType_IFC4(string line) : base(line){}
    public IfcSpatialStructureElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSpatialZone_IFC4 : IfcSpatialElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpatialZone_IFC4(string line) : base(line){}
    public IfcSpatialZone_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSpatialZoneType_IFC4 : IfcSpatialElementType_IFC4 {
    public string PredefinedType;
    public string LongName;

    public new List<string> param_order = new List<string>{"PredefinedType", "LongName"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSpatialZoneType_IFC4(string line) : base(line){}
    public IfcSpatialZoneType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSphere_IFC4 : IfcCsgPrimitive3D_IFC4 {
    public string Radius;

    public new List<string> param_order = new List<string>{"Radius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSphere_IFC4(string line) : base(line){}
    public IfcSphere_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSphericalSurface_IFC4 : IfcElementarySurface_IFC4 {
    public string Radius;

    public new List<string> param_order = new List<string>{"Radius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSphericalSurface_IFC4(string line) : base(line){}
    public IfcSphericalSurface_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStackTerminal_IFC4 : IfcFlowTerminal_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStackTerminal_IFC4(string line) : base(line){}
    public IfcStackTerminal_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStackTerminalType_IFC4 : IfcFlowTerminalType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStackTerminalType_IFC4(string line) : base(line){}
    public IfcStackTerminalType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStair_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStair_IFC4(string line) : base(line){}
    public IfcStair_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStairFlight_IFC4 : IfcBuildingElement_IFC4 {
    public string NumberOfRisers;
    public string NumberOfTreads;
    public string RiserHeight;
    public string TreadLength;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"NumberOfRisers", "NumberOfTreads", "RiserHeight", "TreadLength", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStairFlight_IFC4(string line) : base(line){}
    public IfcStairFlight_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStairFlightType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStairFlightType_IFC4(string line) : base(line){}
    public IfcStairFlightType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStairType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStairType_IFC4(string line) : base(line){}
    public IfcStairType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralAction_IFC4 : IfcStructuralActivity_IFC4 {
    public string DestabilizingLoad;

    public new List<string> param_order = new List<string>{"DestabilizingLoad"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralAction_IFC4(string line) : base(line){}
    public IfcStructuralAction_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralActivity_IFC4 : IfcProduct_IFC4 {
    public IfcStructuralLoad_IFC4 AppliedLoad;
    public string GlobalOrLocal;

    public new List<string> param_order = new List<string>{"AppliedLoad", "GlobalOrLocal"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralActivity_IFC4(string line) : base(line){}
    public IfcStructuralActivity_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralAnalysisModel_IFC4 : IfcSystem_IFC4 {
    public string PredefinedType;
    public IfcAxis2Placement3D_IFC4 OrientationOf2DPlane;
    public List<IfcStructuralLoadGroup_IFC4> LoadedBy;
    public List<IfcStructuralResultGroup_IFC4> HasResults;
    public IfcObjectPlacement_IFC4 SharedPlacement;

    public new List<string> param_order = new List<string>{"PredefinedType", "OrientationOf2DPlane", "LoadedBy", "HasResults", "SharedPlacement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralAnalysisModel_IFC4(string line) : base(line){}
    public IfcStructuralAnalysisModel_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralConnection_IFC4 : IfcStructuralItem_IFC4 {
    public IfcBoundaryCondition_IFC4 AppliedCondition;

    public new List<string> param_order = new List<string>{"AppliedCondition"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralConnection_IFC4(string line) : base(line){}
    public IfcStructuralConnection_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralConnectionCondition_IFC4 : Entity {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralConnectionCondition_IFC4(string line) : base(line){}
    public IfcStructuralConnectionCondition_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralCurveAction_IFC4 : IfcStructuralAction_IFC4 {
    public string ProjectedOrTrue;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"ProjectedOrTrue", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralCurveAction_IFC4(string line) : base(line){}
    public IfcStructuralCurveAction_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralCurveConnection_IFC4 : IfcStructuralConnection_IFC4 {
    public IfcDirection_IFC4 Axis;

    public new List<string> param_order = new List<string>{"Axis"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralCurveConnection_IFC4(string line) : base(line){}
    public IfcStructuralCurveConnection_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralCurveMember_IFC4 : IfcStructuralMember_IFC4 {
    public string PredefinedType;
    public IfcDirection_IFC4 Axis;

    public new List<string> param_order = new List<string>{"PredefinedType", "Axis"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralCurveMember_IFC4(string line) : base(line){}
    public IfcStructuralCurveMember_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralCurveMemberVarying_IFC4 : IfcStructuralCurveMember_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralCurveMemberVarying_IFC4(string line) : base(line){}
    public IfcStructuralCurveMemberVarying_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralCurveReaction_IFC4 : IfcStructuralReaction_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralCurveReaction_IFC4(string line) : base(line){}
    public IfcStructuralCurveReaction_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralItem_IFC4 : IfcProduct_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralItem_IFC4(string line) : base(line){}
    public IfcStructuralItem_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLinearAction_IFC4 : IfcStructuralCurveAction_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLinearAction_IFC4(string line) : base(line){}
    public IfcStructuralLinearAction_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoad_IFC4 : Entity {
    public string Name;

    public new List<string> param_order = new List<string>{"Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoad_IFC4(string line) : base(line){}
    public IfcStructuralLoad_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadCase_IFC4 : IfcStructuralLoadGroup_IFC4 {
    public List<string> SelfWeightCoefficients;

    public new List<string> param_order = new List<string>{"SelfWeightCoefficients"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadCase_IFC4(string line) : base(line){}
    public IfcStructuralLoadCase_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadConfiguration_IFC4 : IfcStructuralLoad_IFC4 {
    public List<IfcStructuralLoadOrResult_IFC4> Values;
    public List<List<string>> Locations;

    public new List<string> param_order = new List<string>{"Values", "Locations"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadConfiguration_IFC4(string line) : base(line){}
    public IfcStructuralLoadConfiguration_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadGroup_IFC4 : IfcGroup_IFC4 {
    public string PredefinedType;
    public string ActionType;
    public string ActionSource;
    public string Coefficient;
    public string Purpose;

    public new List<string> param_order = new List<string>{"PredefinedType", "ActionType", "ActionSource", "Coefficient", "Purpose"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadGroup_IFC4(string line) : base(line){}
    public IfcStructuralLoadGroup_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadLinearForce_IFC4 : IfcStructuralLoadStatic_IFC4 {
    public string LinearForceX;
    public string LinearForceY;
    public string LinearForceZ;
    public string LinearMomentX;
    public string LinearMomentY;
    public string LinearMomentZ;

    public new List<string> param_order = new List<string>{"LinearForceX", "LinearForceY", "LinearForceZ", "LinearMomentX", "LinearMomentY", "LinearMomentZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadLinearForce_IFC4(string line) : base(line){}
    public IfcStructuralLoadLinearForce_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadOrResult_IFC4 : IfcStructuralLoad_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadOrResult_IFC4(string line) : base(line){}
    public IfcStructuralLoadOrResult_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadPlanarForce_IFC4 : IfcStructuralLoadStatic_IFC4 {
    public string PlanarForceX;
    public string PlanarForceY;
    public string PlanarForceZ;

    public new List<string> param_order = new List<string>{"PlanarForceX", "PlanarForceY", "PlanarForceZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadPlanarForce_IFC4(string line) : base(line){}
    public IfcStructuralLoadPlanarForce_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadSingleDisplacement_IFC4 : IfcStructuralLoadStatic_IFC4 {
    public string DisplacementX;
    public string DisplacementY;
    public string DisplacementZ;
    public string RotationalDisplacementRX;
    public string RotationalDisplacementRY;
    public string RotationalDisplacementRZ;

    public new List<string> param_order = new List<string>{"DisplacementX", "DisplacementY", "DisplacementZ", "RotationalDisplacementRX", "RotationalDisplacementRY", "RotationalDisplacementRZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadSingleDisplacement_IFC4(string line) : base(line){}
    public IfcStructuralLoadSingleDisplacement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadSingleDisplacementDistortion_IFC4 : IfcStructuralLoadSingleDisplacement_IFC4 {
    public string Distortion;

    public new List<string> param_order = new List<string>{"Distortion"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadSingleDisplacementDistortion_IFC4(string line) : base(line){}
    public IfcStructuralLoadSingleDisplacementDistortion_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadSingleForce_IFC4 : IfcStructuralLoadStatic_IFC4 {
    public string ForceX;
    public string ForceY;
    public string ForceZ;
    public string MomentX;
    public string MomentY;
    public string MomentZ;

    public new List<string> param_order = new List<string>{"ForceX", "ForceY", "ForceZ", "MomentX", "MomentY", "MomentZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadSingleForce_IFC4(string line) : base(line){}
    public IfcStructuralLoadSingleForce_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadSingleForceWarping_IFC4 : IfcStructuralLoadSingleForce_IFC4 {
    public string WarpingMoment;

    public new List<string> param_order = new List<string>{"WarpingMoment"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadSingleForceWarping_IFC4(string line) : base(line){}
    public IfcStructuralLoadSingleForceWarping_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadStatic_IFC4 : IfcStructuralLoadOrResult_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadStatic_IFC4(string line) : base(line){}
    public IfcStructuralLoadStatic_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralLoadTemperature_IFC4 : IfcStructuralLoadStatic_IFC4 {
    public string DeltaTConstant;
    public string DeltaTY;
    public string DeltaTZ;

    public new List<string> param_order = new List<string>{"DeltaTConstant", "DeltaTY", "DeltaTZ"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralLoadTemperature_IFC4(string line) : base(line){}
    public IfcStructuralLoadTemperature_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralMember_IFC4 : IfcStructuralItem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralMember_IFC4(string line) : base(line){}
    public IfcStructuralMember_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralPlanarAction_IFC4 : IfcStructuralSurfaceAction_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralPlanarAction_IFC4(string line) : base(line){}
    public IfcStructuralPlanarAction_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralPointAction_IFC4 : IfcStructuralAction_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralPointAction_IFC4(string line) : base(line){}
    public IfcStructuralPointAction_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralPointConnection_IFC4 : IfcStructuralConnection_IFC4 {
    public IfcAxis2Placement3D_IFC4 ConditionCoordinateSystem;

    public new List<string> param_order = new List<string>{"ConditionCoordinateSystem"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralPointConnection_IFC4(string line) : base(line){}
    public IfcStructuralPointConnection_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralPointReaction_IFC4 : IfcStructuralReaction_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralPointReaction_IFC4(string line) : base(line){}
    public IfcStructuralPointReaction_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralReaction_IFC4 : IfcStructuralActivity_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralReaction_IFC4(string line) : base(line){}
    public IfcStructuralReaction_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralResultGroup_IFC4 : IfcGroup_IFC4 {
    public string TheoryType;
    public IfcStructuralLoadGroup_IFC4 ResultForLoadGroup;
    public string IsLinear;

    public new List<string> param_order = new List<string>{"TheoryType", "ResultForLoadGroup", "IsLinear"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralResultGroup_IFC4(string line) : base(line){}
    public IfcStructuralResultGroup_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralSurfaceAction_IFC4 : IfcStructuralAction_IFC4 {
    public string ProjectedOrTrue;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"ProjectedOrTrue", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralSurfaceAction_IFC4(string line) : base(line){}
    public IfcStructuralSurfaceAction_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralSurfaceConnection_IFC4 : IfcStructuralConnection_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralSurfaceConnection_IFC4(string line) : base(line){}
    public IfcStructuralSurfaceConnection_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralSurfaceMember_IFC4 : IfcStructuralMember_IFC4 {
    public string PredefinedType;
    public string Thickness;

    public new List<string> param_order = new List<string>{"PredefinedType", "Thickness"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralSurfaceMember_IFC4(string line) : base(line){}
    public IfcStructuralSurfaceMember_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralSurfaceMemberVarying_IFC4 : IfcStructuralSurfaceMember_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralSurfaceMemberVarying_IFC4(string line) : base(line){}
    public IfcStructuralSurfaceMemberVarying_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStructuralSurfaceReaction_IFC4 : IfcStructuralReaction_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStructuralSurfaceReaction_IFC4(string line) : base(line){}
    public IfcStructuralSurfaceReaction_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStyleModel_IFC4 : IfcRepresentation_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStyleModel_IFC4(string line) : base(line){}
    public IfcStyleModel_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStyledItem_IFC4 : IfcRepresentationItem_IFC4 {
    public IfcRepresentationItem_IFC4 Item;
    public List<IfcStyleAssignmentSelect_IFC4> Styles;
    public string Name;

    public new List<string> param_order = new List<string>{"Item", "Styles", "Name"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStyledItem_IFC4(string line) : base(line){}
    public IfcStyledItem_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcStyledRepresentation_IFC4 : IfcStyleModel_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcStyledRepresentation_IFC4(string line) : base(line){}
    public IfcStyledRepresentation_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSubContractResource_IFC4 : IfcConstructionResource_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSubContractResource_IFC4(string line) : base(line){}
    public IfcSubContractResource_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSubContractResourceType_IFC4 : IfcConstructionResourceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSubContractResourceType_IFC4(string line) : base(line){}
    public IfcSubContractResourceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSubedge_IFC4 : IfcEdge_IFC4 {
    public IfcEdge_IFC4 ParentEdge;

    public new List<string> param_order = new List<string>{"ParentEdge"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSubedge_IFC4(string line) : base(line){}
    public IfcSubedge_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSurface_IFC4 : IfcGeometricRepresentationItem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurface_IFC4(string line) : base(line){}
    public IfcSurface_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceCurve_IFC4 : IfcCurve_IFC4 {
    public IfcCurve_IFC4 Curve3D;
    public List<IfcPcurve_IFC4> AssociatedGeometry;
    public string MasterRepresentation;

    public new List<string> param_order = new List<string>{"Curve3D", "AssociatedGeometry", "MasterRepresentation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceCurve_IFC4(string line) : base(line){}
    public IfcSurfaceCurve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceCurveSweptAreaSolid_IFC4 : IfcSweptAreaSolid_IFC4 {
    public IfcCurve_IFC4 Directrix;
    public string StartParam;
    public string EndParam;
    public IfcSurface_IFC4 ReferenceSurface;

    public new List<string> param_order = new List<string>{"Directrix", "StartParam", "EndParam", "ReferenceSurface"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceCurveSweptAreaSolid_IFC4(string line) : base(line){}
    public IfcSurfaceCurveSweptAreaSolid_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceFeature_IFC4 : IfcFeatureElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceFeature_IFC4(string line) : base(line){}
    public IfcSurfaceFeature_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceOfLinearExtrusion_IFC4 : IfcSweptSurface_IFC4 {
    public IfcDirection_IFC4 ExtrudedDirection;
    public string Depth;

    public new List<string> param_order = new List<string>{"ExtrudedDirection", "Depth"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceOfLinearExtrusion_IFC4(string line) : base(line){}
    public IfcSurfaceOfLinearExtrusion_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceOfRevolution_IFC4 : IfcSweptSurface_IFC4 {
    public IfcAxis1Placement_IFC4 AxisPosition;

    public new List<string> param_order = new List<string>{"AxisPosition"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceOfRevolution_IFC4(string line) : base(line){}
    public IfcSurfaceOfRevolution_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceReinforcementArea_IFC4 : IfcStructuralLoadOrResult_IFC4 {
    public List<string> SurfaceReinforcement1;
    public List<string> SurfaceReinforcement2;
    public string ShearReinforcement;

    public new List<string> param_order = new List<string>{"SurfaceReinforcement1", "SurfaceReinforcement2", "ShearReinforcement"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceReinforcementArea_IFC4(string line) : base(line){}
    public IfcSurfaceReinforcementArea_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceStyle_IFC4 : IfcPresentationStyle_IFC4 {
    public string Side;
    public List<IfcSurfaceStyleElementSelect_IFC4> Styles;

    public new List<string> param_order = new List<string>{"Side", "Styles"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceStyle_IFC4(string line) : base(line){}
    public IfcSurfaceStyle_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceStyleLighting_IFC4 : IfcPresentationItem_IFC4 {
    public IfcColourRgb_IFC4 DiffuseTransmissionColour;
    public IfcColourRgb_IFC4 DiffuseReflectionColour;
    public IfcColourRgb_IFC4 TransmissionColour;
    public IfcColourRgb_IFC4 ReflectanceColour;

    public new List<string> param_order = new List<string>{"DiffuseTransmissionColour", "DiffuseReflectionColour", "TransmissionColour", "ReflectanceColour"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceStyleLighting_IFC4(string line) : base(line){}
    public IfcSurfaceStyleLighting_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceStyleRefraction_IFC4 : IfcPresentationItem_IFC4 {
    public string RefractionIndex;
    public string DispersionFactor;

    public new List<string> param_order = new List<string>{"RefractionIndex", "DispersionFactor"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceStyleRefraction_IFC4(string line) : base(line){}
    public IfcSurfaceStyleRefraction_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceStyleRendering_IFC4 : IfcSurfaceStyleShading_IFC4 {
    public IfcColourOrFactor_IFC4 DiffuseColour;
    public IfcColourOrFactor_IFC4 TransmissionColour;
    public IfcColourOrFactor_IFC4 DiffuseTransmissionColour;
    public IfcColourOrFactor_IFC4 ReflectionColour;
    public IfcColourOrFactor_IFC4 SpecularColour;
    public IfcSpecularHighlightSelect_IFC4 SpecularHighlight;
    public string ReflectanceMethod;

    public new List<string> param_order = new List<string>{"DiffuseColour", "TransmissionColour", "DiffuseTransmissionColour", "ReflectionColour", "SpecularColour", "SpecularHighlight", "ReflectanceMethod"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceStyleRendering_IFC4(string line) : base(line){}
    public IfcSurfaceStyleRendering_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceStyleShading_IFC4 : IfcPresentationItem_IFC4 {
    public IfcColourRgb_IFC4 SurfaceColour;
    public string Transparency;

    public new List<string> param_order = new List<string>{"SurfaceColour", "Transparency"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceStyleShading_IFC4(string line) : base(line){}
    public IfcSurfaceStyleShading_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceStyleWithTextures_IFC4 : IfcPresentationItem_IFC4 {
    public List<IfcSurfaceTexture_IFC4> Textures;

    public new List<string> param_order = new List<string>{"Textures"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceStyleWithTextures_IFC4(string line) : base(line){}
    public IfcSurfaceStyleWithTextures_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSurfaceTexture_IFC4 : IfcPresentationItem_IFC4 {
    public string RepeatS;
    public string RepeatT;
    public string Mode;
    public IfcCartesianTransformationOperator2D_IFC4 TextureTransform;
    public List<string> Parameter;

    public new List<string> param_order = new List<string>{"RepeatS", "RepeatT", "Mode", "TextureTransform", "Parameter"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSurfaceTexture_IFC4(string line) : base(line){}
    public IfcSurfaceTexture_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSweptAreaSolid_IFC4 : IfcSolidModel_IFC4 {
    public IfcProfileDef_IFC4 SweptArea;
    public IfcAxis2Placement3D_IFC4 Position;

    public new List<string> param_order = new List<string>{"SweptArea", "Position"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSweptAreaSolid_IFC4(string line) : base(line){}
    public IfcSweptAreaSolid_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSweptDiskSolid_IFC4 : IfcSolidModel_IFC4 {
    public IfcCurve_IFC4 Directrix;
    public string Radius;
    public string InnerRadius;
    public string StartParam;
    public string EndParam;

    public new List<string> param_order = new List<string>{"Directrix", "Radius", "InnerRadius", "StartParam", "EndParam"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSweptDiskSolid_IFC4(string line) : base(line){}
    public IfcSweptDiskSolid_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSweptDiskSolidPolygonal_IFC4 : IfcSweptDiskSolid_IFC4 {
    public string FilletRadius;

    public new List<string> param_order = new List<string>{"FilletRadius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSweptDiskSolidPolygonal_IFC4(string line) : base(line){}
    public IfcSweptDiskSolidPolygonal_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSweptSurface_IFC4 : IfcSurface_IFC4 {
    public IfcProfileDef_IFC4 SweptCurve;
    public IfcAxis2Placement3D_IFC4 Position;

    public new List<string> param_order = new List<string>{"SweptCurve", "Position"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSweptSurface_IFC4(string line) : base(line){}
    public IfcSweptSurface_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSwitchingDevice_IFC4 : IfcFlowController_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSwitchingDevice_IFC4(string line) : base(line){}
    public IfcSwitchingDevice_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSwitchingDeviceType_IFC4 : IfcFlowControllerType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSwitchingDeviceType_IFC4(string line) : base(line){}
    public IfcSwitchingDeviceType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSystem_IFC4 : IfcGroup_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSystem_IFC4(string line) : base(line){}
    public IfcSystem_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSystemFurnitureElement_IFC4 : IfcFurnishingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSystemFurnitureElement_IFC4(string line) : base(line){}
    public IfcSystemFurnitureElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcSystemFurnitureElementType_IFC4 : IfcFurnishingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcSystemFurnitureElementType_IFC4(string line) : base(line){}
    public IfcSystemFurnitureElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTShapeProfileDef_IFC4 : IfcParameterizedProfileDef_IFC4 {
    public string Depth;
    public string FlangeWidth;
    public string WebThickness;
    public string FlangeThickness;
    public string FilletRadius;
    public string FlangeEdgeRadius;
    public string WebEdgeRadius;
    public string WebSlope;
    public string FlangeSlope;

    public new List<string> param_order = new List<string>{"Depth", "FlangeWidth", "WebThickness", "FlangeThickness", "FilletRadius", "FlangeEdgeRadius", "WebEdgeRadius", "WebSlope", "FlangeSlope"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTShapeProfileDef_IFC4(string line) : base(line){}
    public IfcTShapeProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTable_IFC4 : Entity {
    public string Name;
    public List<IfcTableRow_IFC4> Rows;
    public List<IfcTableColumn_IFC4> Columns;

    public new List<string> param_order = new List<string>{"Name", "Rows", "Columns"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTable_IFC4(string line) : base(line){}
    public IfcTable_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTableColumn_IFC4 : Entity {
    public string Identifier;
    public string Name;
    public string Description;
    public IfcUnit_IFC4 Unit;
    public IfcReference_IFC4 ReferencePath;

    public new List<string> param_order = new List<string>{"Identifier", "Name", "Description", "Unit", "ReferencePath"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTableColumn_IFC4(string line) : base(line){}
    public IfcTableColumn_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTableRow_IFC4 : Entity {
    public List<IfcValue_IFC4> RowCells;
    public string IsHeading;

    public new List<string> param_order = new List<string>{"RowCells", "IsHeading"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTableRow_IFC4(string line) : base(line){}
    public IfcTableRow_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTank_IFC4 : IfcFlowStorageDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTank_IFC4(string line) : base(line){}
    public IfcTank_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTankType_IFC4 : IfcFlowStorageDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTankType_IFC4(string line) : base(line){}
    public IfcTankType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTask_IFC4 : IfcProcess_IFC4 {
    public string Status;
    public string WorkMethod;
    public string IsMilestone;
    public string Priority;
    public IfcTaskTime_IFC4 TaskTime;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"Status", "WorkMethod", "IsMilestone", "Priority", "TaskTime", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTask_IFC4(string line) : base(line){}
    public IfcTask_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTaskTime_IFC4 : IfcSchedulingTime_IFC4 {
    public string DurationType;
    public string ScheduleDuration;
    public string ScheduleStart;
    public string ScheduleFinish;
    public string EarlyStart;
    public string EarlyFinish;
    public string LateStart;
    public string LateFinish;
    public string FreeFloat;
    public string TotalFloat;
    public string IsCritical;
    public string StatusTime;
    public string ActualDuration;
    public string ActualStart;
    public string ActualFinish;
    public string RemainingTime;
    public string Completion;

    public new List<string> param_order = new List<string>{"DurationType", "ScheduleDuration", "ScheduleStart", "ScheduleFinish", "EarlyStart", "EarlyFinish", "LateStart", "LateFinish", "FreeFloat", "TotalFloat", "IsCritical", "StatusTime", "ActualDuration", "ActualStart", "ActualFinish", "RemainingTime", "Completion"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTaskTime_IFC4(string line) : base(line){}
    public IfcTaskTime_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTaskTimeRecurring_IFC4 : IfcTaskTime_IFC4 {
    public IfcRecurrencePattern_IFC4 Recurrence;

    public new List<string> param_order = new List<string>{"Recurrence"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTaskTimeRecurring_IFC4(string line) : base(line){}
    public IfcTaskTimeRecurring_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTaskType_IFC4 : IfcTypeProcess_IFC4 {
    public string PredefinedType;
    public string WorkMethod;

    public new List<string> param_order = new List<string>{"PredefinedType", "WorkMethod"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTaskType_IFC4(string line) : base(line){}
    public IfcTaskType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTelecomAddress_IFC4 : IfcAddress_IFC4 {
    public List<string> TelephoneNumbers;
    public List<string> FacsimileNumbers;
    public string PagerNumber;
    public List<string> ElectronicMailAddresses;
    public string WWWHomePageURL;
    public List<string> MessagingIDs;

    public new List<string> param_order = new List<string>{"TelephoneNumbers", "FacsimileNumbers", "PagerNumber", "ElectronicMailAddresses", "WWWHomePageURL", "MessagingIDs"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTelecomAddress_IFC4(string line) : base(line){}
    public IfcTelecomAddress_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTendon_IFC4 : IfcReinforcingElement_IFC4 {
    public string PredefinedType;
    public string NominalDiameter;
    public string CrossSectionArea;
    public string TensionForce;
    public string PreStress;
    public string FrictionCoefficient;
    public string AnchorageSlip;
    public string MinCurvatureRadius;

    public new List<string> param_order = new List<string>{"PredefinedType", "NominalDiameter", "CrossSectionArea", "TensionForce", "PreStress", "FrictionCoefficient", "AnchorageSlip", "MinCurvatureRadius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTendon_IFC4(string line) : base(line){}
    public IfcTendon_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTendonAnchor_IFC4 : IfcReinforcingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTendonAnchor_IFC4(string line) : base(line){}
    public IfcTendonAnchor_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTendonAnchorType_IFC4 : IfcReinforcingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTendonAnchorType_IFC4(string line) : base(line){}
    public IfcTendonAnchorType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTendonType_IFC4 : IfcReinforcingElementType_IFC4 {
    public string PredefinedType;
    public string NominalDiameter;
    public string CrossSectionArea;
    public string SheathDiameter;

    public new List<string> param_order = new List<string>{"PredefinedType", "NominalDiameter", "CrossSectionArea", "SheathDiameter"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTendonType_IFC4(string line) : base(line){}
    public IfcTendonType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTessellatedFaceSet_IFC4 : IfcTessellatedItem_IFC4 {
    public IfcCartesianPointList3D_IFC4 Coordinates;

    public new List<string> param_order = new List<string>{"Coordinates"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTessellatedFaceSet_IFC4(string line) : base(line){}
    public IfcTessellatedFaceSet_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTessellatedItem_IFC4 : IfcGeometricRepresentationItem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTessellatedItem_IFC4(string line) : base(line){}
    public IfcTessellatedItem_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTextLiteral_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public string Literal;
    public IfcAxis2Placement_IFC4 Placement;
    public string Path;

    public new List<string> param_order = new List<string>{"Literal", "Placement", "Path"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextLiteral_IFC4(string line) : base(line){}
    public IfcTextLiteral_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTextLiteralWithExtent_IFC4 : IfcTextLiteral_IFC4 {
    public IfcPlanarExtent_IFC4 Extent;
    public string BoxAlignment;

    public new List<string> param_order = new List<string>{"Extent", "BoxAlignment"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextLiteralWithExtent_IFC4(string line) : base(line){}
    public IfcTextLiteralWithExtent_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTextStyle_IFC4 : IfcPresentationStyle_IFC4 {
    public IfcTextStyleForDefinedFont_IFC4 TextCharacterAppearance;
    public IfcTextStyleTextModel_IFC4 TextStyle;
    public IfcTextFontSelect_IFC4 TextFontStyle;
    public string ModelOrDraughting;

    public new List<string> param_order = new List<string>{"TextCharacterAppearance", "TextStyle", "TextFontStyle", "ModelOrDraughting"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextStyle_IFC4(string line) : base(line){}
    public IfcTextStyle_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTextStyleFontModel_IFC4 : IfcPreDefinedTextFont_IFC4 {
    public List<string> FontFamily;
    public string FontStyle;
    public string FontVariant;
    public string FontWeight;
    public IfcSizeSelect_IFC4 FontSize;

    public new List<string> param_order = new List<string>{"FontFamily", "FontStyle", "FontVariant", "FontWeight", "FontSize"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextStyleFontModel_IFC4(string line) : base(line){}
    public IfcTextStyleFontModel_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTextStyleForDefinedFont_IFC4 : IfcPresentationItem_IFC4 {
    public IfcColour_IFC4 Colour;
    public IfcColour_IFC4 BackgroundColour;

    public new List<string> param_order = new List<string>{"Colour", "BackgroundColour"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextStyleForDefinedFont_IFC4(string line) : base(line){}
    public IfcTextStyleForDefinedFont_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTextStyleTextModel_IFC4 : IfcPresentationItem_IFC4 {
    public IfcSizeSelect_IFC4 TextIndent;
    public string TextAlign;
    public string TextDecoration;
    public IfcSizeSelect_IFC4 LetterSpacing;
    public IfcSizeSelect_IFC4 WordSpacing;
    public string TextTransform;
    public IfcSizeSelect_IFC4 LineHeight;

    public new List<string> param_order = new List<string>{"TextIndent", "TextAlign", "TextDecoration", "LetterSpacing", "WordSpacing", "TextTransform", "LineHeight"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextStyleTextModel_IFC4(string line) : base(line){}
    public IfcTextStyleTextModel_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTextureCoordinate_IFC4 : IfcPresentationItem_IFC4 {
    public List<IfcSurfaceTexture_IFC4> Maps;

    public new List<string> param_order = new List<string>{"Maps"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextureCoordinate_IFC4(string line) : base(line){}
    public IfcTextureCoordinate_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTextureCoordinateGenerator_IFC4 : IfcTextureCoordinate_IFC4 {
    public string Mode;
    public List<string> Parameter;

    public new List<string> param_order = new List<string>{"Mode", "Parameter"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextureCoordinateGenerator_IFC4(string line) : base(line){}
    public IfcTextureCoordinateGenerator_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTextureMap_IFC4 : IfcTextureCoordinate_IFC4 {
    public List<IfcTextureVertex_IFC4> Vertices;
    public IfcFace_IFC4 MappedTo;

    public new List<string> param_order = new List<string>{"Vertices", "MappedTo"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextureMap_IFC4(string line) : base(line){}
    public IfcTextureMap_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTextureVertex_IFC4 : IfcPresentationItem_IFC4 {
    public List<string> Coordinates;

    public new List<string> param_order = new List<string>{"Coordinates"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextureVertex_IFC4(string line) : base(line){}
    public IfcTextureVertex_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTextureVertexList_IFC4 : IfcPresentationItem_IFC4 {
    public List<List<string>> TexCoordsList;

    public new List<string> param_order = new List<string>{"TexCoordsList"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTextureVertexList_IFC4(string line) : base(line){}
    public IfcTextureVertexList_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTimePeriod_IFC4 : Entity {
    public string StartTime;
    public string EndTime;

    public new List<string> param_order = new List<string>{"StartTime", "EndTime"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTimePeriod_IFC4(string line) : base(line){}
    public IfcTimePeriod_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTimeSeries_IFC4 : Entity {
    public string Name;
    public string Description;
    public string StartTime;
    public string EndTime;
    public string TimeSeriesDataType;
    public string DataOrigin;
    public string UserDefinedDataOrigin;
    public IfcUnit_IFC4 Unit;

    public new List<string> param_order = new List<string>{"Name", "Description", "StartTime", "EndTime", "TimeSeriesDataType", "DataOrigin", "UserDefinedDataOrigin", "Unit"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTimeSeries_IFC4(string line) : base(line){}
    public IfcTimeSeries_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTimeSeriesValue_IFC4 : Entity {
    public List<IfcValue_IFC4> ListValues;

    public new List<string> param_order = new List<string>{"ListValues"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTimeSeriesValue_IFC4(string line) : base(line){}
    public IfcTimeSeriesValue_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTopologicalRepresentationItem_IFC4 : IfcRepresentationItem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTopologicalRepresentationItem_IFC4(string line) : base(line){}
    public IfcTopologicalRepresentationItem_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTopologyRepresentation_IFC4 : IfcShapeModel_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTopologyRepresentation_IFC4(string line) : base(line){}
    public IfcTopologyRepresentation_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcToroidalSurface_IFC4 : IfcElementarySurface_IFC4 {
    public string MajorRadius;
    public string MinorRadius;

    public new List<string> param_order = new List<string>{"MajorRadius", "MinorRadius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcToroidalSurface_IFC4(string line) : base(line){}
    public IfcToroidalSurface_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTransformer_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTransformer_IFC4(string line) : base(line){}
    public IfcTransformer_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTransformerType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTransformerType_IFC4(string line) : base(line){}
    public IfcTransformerType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTransportElement_IFC4 : IfcElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTransportElement_IFC4(string line) : base(line){}
    public IfcTransportElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTransportElementType_IFC4 : IfcElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTransportElementType_IFC4(string line) : base(line){}
    public IfcTransportElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTrapeziumProfileDef_IFC4 : IfcParameterizedProfileDef_IFC4 {
    public string BottomXDim;
    public string TopXDim;
    public string YDim;
    public string TopXOffset;

    public new List<string> param_order = new List<string>{"BottomXDim", "TopXDim", "YDim", "TopXOffset"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTrapeziumProfileDef_IFC4(string line) : base(line){}
    public IfcTrapeziumProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTriangulatedFaceSet_IFC4 : IfcTessellatedFaceSet_IFC4 {
    public List<List<string>> Normals;
    public string Closed;
    public List<List<string>> CoordIndex;
    public List<string> PnIndex;

    public new List<string> param_order = new List<string>{"Normals", "Closed", "CoordIndex", "PnIndex"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTriangulatedFaceSet_IFC4(string line) : base(line){}
    public IfcTriangulatedFaceSet_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTrimmedCurve_IFC4 : IfcBoundedCurve_IFC4 {
    public IfcCurve_IFC4 BasisCurve;
    public List<IfcTrimmingSelect_IFC4> Trim1;
    public List<IfcTrimmingSelect_IFC4> Trim2;
    public string SenseAgreement;
    public string MasterRepresentation;

    public new List<string> param_order = new List<string>{"BasisCurve", "Trim1", "Trim2", "SenseAgreement", "MasterRepresentation"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTrimmedCurve_IFC4(string line) : base(line){}
    public IfcTrimmedCurve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTubeBundle_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTubeBundle_IFC4(string line) : base(line){}
    public IfcTubeBundle_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTubeBundleType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTubeBundleType_IFC4(string line) : base(line){}
    public IfcTubeBundleType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTypeObject_IFC4 : IfcObjectDefinition_IFC4 {
    public string ApplicableOccurrence;
    public List<IfcPropertySetDefinition_IFC4> HasPropertySets;

    public new List<string> param_order = new List<string>{"ApplicableOccurrence", "HasPropertySets"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTypeObject_IFC4(string line) : base(line){}
    public IfcTypeObject_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTypeProcess_IFC4 : IfcTypeObject_IFC4 {
    public string Identification;
    public string LongDescription;
    public string ProcessType;

    public new List<string> param_order = new List<string>{"Identification", "LongDescription", "ProcessType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTypeProcess_IFC4(string line) : base(line){}
    public IfcTypeProcess_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTypeProduct_IFC4 : IfcTypeObject_IFC4 {
    public List<IfcRepresentationMap_IFC4> RepresentationMaps;
    public string Tag;

    public new List<string> param_order = new List<string>{"RepresentationMaps", "Tag"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTypeProduct_IFC4(string line) : base(line){}
    public IfcTypeProduct_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcTypeResource_IFC4 : IfcTypeObject_IFC4 {
    public string Identification;
    public string LongDescription;
    public string ResourceType;

    public new List<string> param_order = new List<string>{"Identification", "LongDescription", "ResourceType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcTypeResource_IFC4(string line) : base(line){}
    public IfcTypeResource_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcUShapeProfileDef_IFC4 : IfcParameterizedProfileDef_IFC4 {
    public string Depth;
    public string FlangeWidth;
    public string WebThickness;
    public string FlangeThickness;
    public string FilletRadius;
    public string EdgeRadius;
    public string FlangeSlope;

    public new List<string> param_order = new List<string>{"Depth", "FlangeWidth", "WebThickness", "FlangeThickness", "FilletRadius", "EdgeRadius", "FlangeSlope"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcUShapeProfileDef_IFC4(string line) : base(line){}
    public IfcUShapeProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcUnitAssignment_IFC4 : Entity {
    public List<IfcUnit_IFC4> Units;

    public new List<string> param_order = new List<string>{"Units"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcUnitAssignment_IFC4(string line) : base(line){}
    public IfcUnitAssignment_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcUnitaryControlElement_IFC4 : IfcDistributionControlElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcUnitaryControlElement_IFC4(string line) : base(line){}
    public IfcUnitaryControlElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcUnitaryControlElementType_IFC4 : IfcDistributionControlElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcUnitaryControlElementType_IFC4(string line) : base(line){}
    public IfcUnitaryControlElementType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcUnitaryEquipment_IFC4 : IfcEnergyConversionDevice_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcUnitaryEquipment_IFC4(string line) : base(line){}
    public IfcUnitaryEquipment_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcUnitaryEquipmentType_IFC4 : IfcEnergyConversionDeviceType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcUnitaryEquipmentType_IFC4(string line) : base(line){}
    public IfcUnitaryEquipmentType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcValve_IFC4 : IfcFlowController_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcValve_IFC4(string line) : base(line){}
    public IfcValve_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcValveType_IFC4 : IfcFlowControllerType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcValveType_IFC4(string line) : base(line){}
    public IfcValveType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcVector_IFC4 : IfcGeometricRepresentationItem_IFC4 {
    public IfcDirection_IFC4 Orientation;
    public string Magnitude;

    public new List<string> param_order = new List<string>{"Orientation", "Magnitude"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVector_IFC4(string line) : base(line){}
    public IfcVector_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcVertex_IFC4 : IfcTopologicalRepresentationItem_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVertex_IFC4(string line) : base(line){}
    public IfcVertex_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcVertexLoop_IFC4 : IfcLoop_IFC4 {
    public IfcVertex_IFC4 LoopVertex;

    public new List<string> param_order = new List<string>{"LoopVertex"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVertexLoop_IFC4(string line) : base(line){}
    public IfcVertexLoop_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcVertexPoint_IFC4 : IfcVertex_IFC4 {
    public IfcPoint_IFC4 VertexGeometry;

    public new List<string> param_order = new List<string>{"VertexGeometry"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVertexPoint_IFC4(string line) : base(line){}
    public IfcVertexPoint_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcVibrationIsolator_IFC4 : IfcElementComponent_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVibrationIsolator_IFC4(string line) : base(line){}
    public IfcVibrationIsolator_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcVibrationIsolatorType_IFC4 : IfcElementComponentType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVibrationIsolatorType_IFC4(string line) : base(line){}
    public IfcVibrationIsolatorType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcVirtualElement_IFC4 : IfcElement_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVirtualElement_IFC4(string line) : base(line){}
    public IfcVirtualElement_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcVirtualGridIntersection_IFC4 : Entity {
    public List<IfcGridAxis_IFC4> IntersectingAxes;
    public List<string> OffsetDistances;

    public new List<string> param_order = new List<string>{"IntersectingAxes", "OffsetDistances"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVirtualGridIntersection_IFC4(string line) : base(line){}
    public IfcVirtualGridIntersection_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcVoidingFeature_IFC4 : IfcFeatureElementSubtraction_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcVoidingFeature_IFC4(string line) : base(line){}
    public IfcVoidingFeature_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWall_IFC4 : IfcBuildingElement_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWall_IFC4(string line) : base(line){}
    public IfcWall_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWallElementedCase_IFC4 : IfcWall_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWallElementedCase_IFC4(string line) : base(line){}
    public IfcWallElementedCase_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWallStandardCase_IFC4 : IfcWall_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWallStandardCase_IFC4(string line) : base(line){}
    public IfcWallStandardCase_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWallType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWallType_IFC4(string line) : base(line){}
    public IfcWallType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWasteTerminal_IFC4 : IfcFlowTerminal_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWasteTerminal_IFC4(string line) : base(line){}
    public IfcWasteTerminal_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWasteTerminalType_IFC4 : IfcFlowTerminalType_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWasteTerminalType_IFC4(string line) : base(line){}
    public IfcWasteTerminalType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWindow_IFC4 : IfcBuildingElement_IFC4 {
    public string OverallHeight;
    public string OverallWidth;
    public string PredefinedType;
    public string PartitioningType;
    public string UserDefinedPartitioningType;

    public new List<string> param_order = new List<string>{"OverallHeight", "OverallWidth", "PredefinedType", "PartitioningType", "UserDefinedPartitioningType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWindow_IFC4(string line) : base(line){}
    public IfcWindow_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWindowLiningProperties_IFC4 : IfcPreDefinedPropertySet_IFC4 {
    public string LiningDepth;
    public string LiningThickness;
    public string TransomThickness;
    public string MullionThickness;
    public string FirstTransomOffset;
    public string SecondTransomOffset;
    public string FirstMullionOffset;
    public string SecondMullionOffset;
    public IfcShapeAspect_IFC4 ShapeAspectStyle;
    public string LiningOffset;
    public string LiningToPanelOffsetX;
    public string LiningToPanelOffsetY;

    public new List<string> param_order = new List<string>{"LiningDepth", "LiningThickness", "TransomThickness", "MullionThickness", "FirstTransomOffset", "SecondTransomOffset", "FirstMullionOffset", "SecondMullionOffset", "ShapeAspectStyle", "LiningOffset", "LiningToPanelOffsetX", "LiningToPanelOffsetY"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWindowLiningProperties_IFC4(string line) : base(line){}
    public IfcWindowLiningProperties_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWindowPanelProperties_IFC4 : IfcPreDefinedPropertySet_IFC4 {
    public string OperationType;
    public string PanelPosition;
    public string FrameDepth;
    public string FrameThickness;
    public IfcShapeAspect_IFC4 ShapeAspectStyle;

    public new List<string> param_order = new List<string>{"OperationType", "PanelPosition", "FrameDepth", "FrameThickness", "ShapeAspectStyle"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWindowPanelProperties_IFC4(string line) : base(line){}
    public IfcWindowPanelProperties_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWindowStandardCase_IFC4 : IfcWindow_IFC4 {

    public new List<string> param_order = new List<string>{};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWindowStandardCase_IFC4(string line) : base(line){}
    public IfcWindowStandardCase_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWindowStyle_IFC4 : IfcTypeProduct_IFC4 {
    public string ConstructionType;
    public string OperationType;
    public string ParameterTakesPrecedence;
    public string Sizeable;

    public new List<string> param_order = new List<string>{"ConstructionType", "OperationType", "ParameterTakesPrecedence", "Sizeable"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWindowStyle_IFC4(string line) : base(line){}
    public IfcWindowStyle_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWindowType_IFC4 : IfcBuildingElementType_IFC4 {
    public string PredefinedType;
    public string PartitioningType;
    public string ParameterTakesPrecedence;
    public string UserDefinedPartitioningType;

    public new List<string> param_order = new List<string>{"PredefinedType", "PartitioningType", "ParameterTakesPrecedence", "UserDefinedPartitioningType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWindowType_IFC4(string line) : base(line){}
    public IfcWindowType_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWorkCalendar_IFC4 : IfcControl_IFC4 {
    public List<IfcWorkTime_IFC4> WorkingTimes;
    public List<IfcWorkTime_IFC4> ExceptionTimes;
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"WorkingTimes", "ExceptionTimes", "PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWorkCalendar_IFC4(string line) : base(line){}
    public IfcWorkCalendar_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWorkControl_IFC4 : IfcControl_IFC4 {
    public string CreationDate;
    public List<IfcPerson_IFC4> Creators;
    public string Purpose;
    public string Duration;
    public string TotalFloat;
    public string StartTime;
    public string FinishTime;

    public new List<string> param_order = new List<string>{"CreationDate", "Creators", "Purpose", "Duration", "TotalFloat", "StartTime", "FinishTime"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWorkControl_IFC4(string line) : base(line){}
    public IfcWorkControl_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWorkPlan_IFC4 : IfcWorkControl_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWorkPlan_IFC4(string line) : base(line){}
    public IfcWorkPlan_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWorkSchedule_IFC4 : IfcWorkControl_IFC4 {
    public string PredefinedType;

    public new List<string> param_order = new List<string>{"PredefinedType"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWorkSchedule_IFC4(string line) : base(line){}
    public IfcWorkSchedule_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcWorkTime_IFC4 : IfcSchedulingTime_IFC4 {
    public IfcRecurrencePattern_IFC4 RecurrencePattern;
    public string Start;
    public string Finish;

    public new List<string> param_order = new List<string>{"RecurrencePattern", "Start", "Finish"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcWorkTime_IFC4(string line) : base(line){}
    public IfcWorkTime_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcZShapeProfileDef_IFC4 : IfcParameterizedProfileDef_IFC4 {
    public string Depth;
    public string FlangeWidth;
    public string WebThickness;
    public string FlangeThickness;
    public string FilletRadius;
    public string EdgeRadius;

    public new List<string> param_order = new List<string>{"Depth", "FlangeWidth", "WebThickness", "FlangeThickness", "FilletRadius", "EdgeRadius"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcZShapeProfileDef_IFC4(string line) : base(line){}
    public IfcZShapeProfileDef_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcZone_IFC4 : IfcSystem_IFC4 {
    public string LongName;

    public new List<string> param_order = new List<string>{"LongName"};

    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public IfcZone_IFC4(string line) : base(line){}
    public IfcZone_IFC4(Dictionary<string, object> p) : base(p){}
}

public class IfcActorSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcOrganization_IFC4), typeof(IfcPersonAndOrganization_IFC4), typeof(IfcPerson_IFC4)};
    public IfcActorSelect_IFC4 (object value) : base(value) {}
}

public class IfcAppliedValueSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcMeasureWithUnit_IFC4), typeof(IfcReference_IFC4), typeof(string)};
    public IfcAppliedValueSelect_IFC4 (object value) : base(value) {}
}

public class IfcAxis2Placement_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcAxis2Placement2D_IFC4), typeof(IfcAxis2Placement3D_IFC4)};
    public IfcAxis2Placement_IFC4 (object value) : base(value) {}
}

public class IfcBendingParameterSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcBendingParameterSelect_IFC4 (object value) : base(value) {}
}

public class IfcBooleanOperand_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcBooleanResult_IFC4), typeof(IfcCsgPrimitive3D_IFC4), typeof(IfcHalfSpaceSolid_IFC4), typeof(IfcSolidModel_IFC4), typeof(IfcTessellatedFaceSet_IFC4)};
    public IfcBooleanOperand_IFC4 (object value) : base(value) {}
}

public class IfcClassificationReferenceSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcClassificationReference_IFC4), typeof(IfcClassification_IFC4)};
    public IfcClassificationReferenceSelect_IFC4 (object value) : base(value) {}
}

public class IfcClassificationSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcClassificationReference_IFC4), typeof(IfcClassification_IFC4)};
    public IfcClassificationSelect_IFC4 (object value) : base(value) {}
}

public class IfcColour_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcColourSpecification_IFC4), typeof(IfcPreDefinedColour_IFC4)};
    public IfcColour_IFC4 (object value) : base(value) {}
}

public class IfcColourOrFactor_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcColourRgb_IFC4), typeof(string)};
    public IfcColourOrFactor_IFC4 (object value) : base(value) {}
}

public class IfcCoordinateReferenceSystemSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcCoordinateReferenceSystem_IFC4), typeof(IfcGeometricRepresentationContext_IFC4)};
    public IfcCoordinateReferenceSystemSelect_IFC4 (object value) : base(value) {}
}

public class IfcCsgSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcBooleanResult_IFC4), typeof(IfcCsgPrimitive3D_IFC4)};
    public IfcCsgSelect_IFC4 (object value) : base(value) {}
}

public class IfcCurveFontOrScaledCurveFontSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcCurveStyleFontAndScaling_IFC4), typeof(IfcCurveStyleFont_IFC4), typeof(IfcPreDefinedCurveFont_IFC4)};
    public IfcCurveFontOrScaledCurveFontSelect_IFC4 (object value) : base(value) {}
}

public class IfcCurveOnSurface_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcCompositeCurveOnSurface_IFC4), typeof(IfcPcurve_IFC4), typeof(IfcSurfaceCurve_IFC4)};
    public IfcCurveOnSurface_IFC4 (object value) : base(value) {}
}

public class IfcCurveOrEdgeCurve_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcBoundedCurve_IFC4), typeof(IfcEdgeCurve_IFC4)};
    public IfcCurveOrEdgeCurve_IFC4 (object value) : base(value) {}
}

public class IfcCurveStyleFontSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcCurveStyleFont_IFC4), typeof(IfcPreDefinedCurveFont_IFC4)};
    public IfcCurveStyleFontSelect_IFC4 (object value) : base(value) {}
}

public class IfcDefinitionSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcObjectDefinition_IFC4), typeof(IfcPropertyDefinition_IFC4)};
    public IfcDefinitionSelect_IFC4 (object value) : base(value) {}
}

public class IfcDerivedMeasureValue_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcDerivedMeasureValue_IFC4 (object value) : base(value) {}
}

public class IfcDocumentSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcDocumentInformation_IFC4), typeof(IfcDocumentReference_IFC4)};
    public IfcDocumentSelect_IFC4 (object value) : base(value) {}
}

public class IfcFillStyleSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcColourSpecification_IFC4), typeof(IfcExternallyDefinedHatchStyle_IFC4), typeof(IfcFillAreaStyleHatching_IFC4), typeof(IfcFillAreaStyleTiles_IFC4), typeof(IfcPreDefinedColour_IFC4)};
    public IfcFillStyleSelect_IFC4 (object value) : base(value) {}
}

public class IfcGeometricSetSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcCurve_IFC4), typeof(IfcPoint_IFC4), typeof(IfcSurface_IFC4)};
    public IfcGeometricSetSelect_IFC4 (object value) : base(value) {}
}

public class IfcGridPlacementDirectionSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcDirection_IFC4), typeof(IfcVirtualGridIntersection_IFC4)};
    public IfcGridPlacementDirectionSelect_IFC4 (object value) : base(value) {}
}

public class IfcHatchLineDistanceSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcVector_IFC4), typeof(string)};
    public IfcHatchLineDistanceSelect_IFC4 (object value) : base(value) {}
}

public class IfcLayeredItem_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcRepresentationItem_IFC4), typeof(IfcRepresentation_IFC4)};
    public IfcLayeredItem_IFC4 (object value) : base(value) {}
}

public class IfcLibrarySelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcLibraryInformation_IFC4), typeof(IfcLibraryReference_IFC4)};
    public IfcLibrarySelect_IFC4 (object value) : base(value) {}
}

public class IfcLightDistributionDataSourceSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcExternalReference_IFC4), typeof(IfcLightIntensityDistribution_IFC4)};
    public IfcLightDistributionDataSourceSelect_IFC4 (object value) : base(value) {}
}

public class IfcMaterialSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcMaterialDefinition_IFC4), typeof(IfcMaterialList_IFC4), typeof(IfcMaterialUsageDefinition_IFC4)};
    public IfcMaterialSelect_IFC4 (object value) : base(value) {}
}

public class IfcMeasureValue_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcMeasureValue_IFC4 (object value) : base(value) {}
}

public class IfcMetricValueSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcAppliedValue_IFC4), typeof(IfcMeasureWithUnit_IFC4), typeof(IfcReference_IFC4), typeof(IfcTable_IFC4), typeof(IfcTimeSeries_IFC4), typeof(string)};
    public IfcMetricValueSelect_IFC4 (object value) : base(value) {}
}

public class IfcModulusOfRotationalSubgradeReactionSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcModulusOfRotationalSubgradeReactionSelect_IFC4 (object value) : base(value) {}
}

public class IfcModulusOfSubgradeReactionSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcModulusOfSubgradeReactionSelect_IFC4 (object value) : base(value) {}
}

public class IfcModulusOfTranslationalSubgradeReactionSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcModulusOfTranslationalSubgradeReactionSelect_IFC4 (object value) : base(value) {}
}

public class IfcObjectReferenceSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcAddress_IFC4), typeof(IfcAppliedValue_IFC4), typeof(IfcExternalReference_IFC4), typeof(IfcMaterialDefinition_IFC4), typeof(IfcOrganization_IFC4), typeof(IfcPersonAndOrganization_IFC4), typeof(IfcPerson_IFC4), typeof(IfcTable_IFC4), typeof(IfcTimeSeries_IFC4)};
    public IfcObjectReferenceSelect_IFC4 (object value) : base(value) {}
}

public class IfcPointOrVertexPoint_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcPoint_IFC4), typeof(IfcVertexPoint_IFC4)};
    public IfcPointOrVertexPoint_IFC4 (object value) : base(value) {}
}

public class IfcPresentationStyleSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcCurveStyle_IFC4), typeof(IfcFillAreaStyle_IFC4), typeof(IfcSurfaceStyle_IFC4), typeof(IfcTextStyle_IFC4), typeof(string)};
    public IfcPresentationStyleSelect_IFC4 (object value) : base(value) {}
}

public class IfcProcessSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcProcess_IFC4), typeof(IfcTypeProcess_IFC4)};
    public IfcProcessSelect_IFC4 (object value) : base(value) {}
}

public class IfcProductRepresentationSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcProductDefinitionShape_IFC4), typeof(IfcRepresentationMap_IFC4)};
    public IfcProductRepresentationSelect_IFC4 (object value) : base(value) {}
}

public class IfcProductSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcProduct_IFC4), typeof(IfcTypeProduct_IFC4)};
    public IfcProductSelect_IFC4 (object value) : base(value) {}
}

public class IfcPropertySetDefinitionSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcPropertySetDefinition_IFC4), typeof(string)};
    public IfcPropertySetDefinitionSelect_IFC4 (object value) : base(value) {}
}

public class IfcResourceObjectSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcActorRole_IFC4), typeof(IfcAppliedValue_IFC4), typeof(IfcApproval_IFC4), typeof(IfcConstraint_IFC4), typeof(IfcContextDependentUnit_IFC4), typeof(IfcConversionBasedUnit_IFC4), typeof(IfcExternalInformation_IFC4), typeof(IfcExternalReference_IFC4), typeof(IfcMaterialDefinition_IFC4), typeof(IfcOrganization_IFC4), typeof(IfcPersonAndOrganization_IFC4), typeof(IfcPerson_IFC4), typeof(IfcPhysicalQuantity_IFC4), typeof(IfcProfileDef_IFC4), typeof(IfcPropertyAbstraction_IFC4), typeof(IfcTimeSeries_IFC4)};
    public IfcResourceObjectSelect_IFC4 (object value) : base(value) {}
}

public class IfcResourceSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcResource_IFC4), typeof(IfcTypeResource_IFC4)};
    public IfcResourceSelect_IFC4 (object value) : base(value) {}
}

public class IfcRotationalStiffnessSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcRotationalStiffnessSelect_IFC4 (object value) : base(value) {}
}

public class IfcSegmentIndexSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcSegmentIndexSelect_IFC4 (object value) : base(value) {}
}

public class IfcShell_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcClosedShell_IFC4), typeof(IfcOpenShell_IFC4)};
    public IfcShell_IFC4 (object value) : base(value) {}
}

public class IfcSimpleValue_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcSimpleValue_IFC4 (object value) : base(value) {}
}

public class IfcSizeSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcSizeSelect_IFC4 (object value) : base(value) {}
}

public class IfcSolidOrShell_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcClosedShell_IFC4), typeof(IfcSolidModel_IFC4)};
    public IfcSolidOrShell_IFC4 (object value) : base(value) {}
}

public class IfcSpaceBoundarySelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcExternalSpatialElement_IFC4), typeof(IfcSpace_IFC4)};
    public IfcSpaceBoundarySelect_IFC4 (object value) : base(value) {}
}

public class IfcSpecularHighlightSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcSpecularHighlightSelect_IFC4 (object value) : base(value) {}
}

public class IfcStructuralActivityAssignmentSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcElement_IFC4), typeof(IfcStructuralItem_IFC4)};
    public IfcStructuralActivityAssignmentSelect_IFC4 (object value) : base(value) {}
}

public class IfcStyleAssignmentSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcPresentationStyleAssignment_IFC4), typeof(IfcPresentationStyle_IFC4)};
    public IfcStyleAssignmentSelect_IFC4 (object value) : base(value) {}
}

public class IfcSurfaceOrFaceSurface_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcFaceBasedSurfaceModel_IFC4), typeof(IfcFaceSurface_IFC4), typeof(IfcSurface_IFC4)};
    public IfcSurfaceOrFaceSurface_IFC4 (object value) : base(value) {}
}

public class IfcSurfaceStyleElementSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcExternallyDefinedSurfaceStyle_IFC4), typeof(IfcSurfaceStyleLighting_IFC4), typeof(IfcSurfaceStyleRefraction_IFC4), typeof(IfcSurfaceStyleShading_IFC4), typeof(IfcSurfaceStyleWithTextures_IFC4)};
    public IfcSurfaceStyleElementSelect_IFC4 (object value) : base(value) {}
}

public class IfcTextFontSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcExternallyDefinedTextFont_IFC4), typeof(IfcPreDefinedTextFont_IFC4)};
    public IfcTextFontSelect_IFC4 (object value) : base(value) {}
}

public class IfcTimeOrRatioSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcTimeOrRatioSelect_IFC4 (object value) : base(value) {}
}

public class IfcTranslationalStiffnessSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcTranslationalStiffnessSelect_IFC4 (object value) : base(value) {}
}

public class IfcTrimmingSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcCartesianPoint_IFC4), typeof(string)};
    public IfcTrimmingSelect_IFC4 (object value) : base(value) {}
}

public class IfcUnit_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcDerivedUnit_IFC4), typeof(IfcMonetaryUnit_IFC4), typeof(IfcNamedUnit_IFC4)};
    public IfcUnit_IFC4 (object value) : base(value) {}
}

public class IfcValue_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcValue_IFC4 (object value) : base(value) {}
}

public class IfcVectorOrDirection_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(IfcDirection_IFC4), typeof(IfcVector_IFC4)};
    public IfcVectorOrDirection_IFC4 (object value) : base(value) {}
}

public class IfcWarpingStiffnessSelect_IFC4 : IfcGroup {
    public new static List<Type> allowed_types = new List<Type>{typeof(string)};
    public IfcWarpingStiffnessSelect_IFC4 (object value) : base(value) {}
}

}
}
