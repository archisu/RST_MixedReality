using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Linq;
using UnityEngine;
using IfcToolkit.IfcSpec;

namespace IfcToolkit {

    /// <summary>Class containing functions for reading and parsing IFC files. </summary>
    public class IfcParser : MonoBehaviour
    {
        private static Dictionary<string, Type> str_to_row_type;

        public GameObject ifcGameObject;


        /// <summary>Populate the dictionaries in an IFC GameObject's IfcFile component by reading a list of lines. </summary>
        /// <param name="lines">The lines of an IFC file. </param>
        /// <param name="ifcFile">The IfcFile object used to store the IfcRows. </param>
        public static void ParseIfc(IfcFile ifcFile, string[] lines) {
            InitializeIfcFile(ifcFile);
            string prev_line = "";
            foreach(string l in lines)
            {
                prev_line = ParseLine(l, ifcFile, prev_line);
            }
            ConnectReferences(ifcFile);
            HandleSpecialCases(ifcFile);
        }

        ///<summary>Initializes various dictionaries and other variables used by IfcFile.</summary>
        ///<param name="ifcFile">The IfcFile to be initialized.</param>
        public static void InitializeIfcFile(IfcFile ifcFile){
            //Check if the file is already initialized
            if (ifcFile.structure_id_to_ifcrelcontainedinspatialstructure_IFC2X3 != null) {
                return;
            }
            //By ID
            ifcFile.structure_id_to_ifcrelcontainedinspatialstructure_IFC2X3 = new Dictionary<string, IfcRelContainedInSpatialStructure_IFC2X3>();
            ifcFile.structure_id_to_ifcrelcontainedinspatialstructure_IFC4 = new Dictionary<string, IfcRelContainedInSpatialStructure_IFC4>();
            ifcFile.id_to_row = new Dictionary<string, IfcRow>();
            
            //By reference
            ifcFile.ref_to_row = new Dictionary<string, IfcRow>();
            ifcFile.space_reference_to_id = new Dictionary<string, string>();
            ifcFile.header_rows = new List<IfcRow>();

            ifcFile.ifcrelcontainedinspatialstructures_IFC2X3 = new List<IfcRelContainedInSpatialStructure_IFC2X3>();
            ifcFile.ifcrelcontainedinspatialstructures_IFC4 = new List<IfcRelContainedInSpatialStructure_IFC4>();

            ifcFile.propertySetReferenceToIfcRelDefinesByProperties_IFC2X3 = new Dictionary<string, IfcRelDefinesByProperties_IFC2X3>();
            ifcFile.propertySetReferenceToIfcRelDefinesByProperties_IFC4 = new Dictionary<string, IfcRelDefinesByProperties_IFC4>();

            ifcFile.highest_ifc_reference = 1;
        }


        ///<summary>Parses a single line of the IFC file, and stores the resulting IfcRow in IfcFile's dictionaries.</summary>
        ///<param name="l">The line to parsed.</param>
        ///<param name="ifcFile">The IfcFile used to store the results.</param>
        ///<param name="prev_line">A string used to handle cases where a single IfcRow is divided between multiple lines.</param>
        ///<returns>prev_line</returns>
        public static string ParseLine(string line, IfcFile ifcFile, string prev_line) {
            //Handling for multi-line IfcRows
            line = prev_line + line;
            //Not the end of the DATA row (';'), but either the start of a data row or continuation of of one
            if (!line.EndsWith(";")) {
                //Return the current line and add it to the next one
                return line;
            }

            //Handling to strip any comments or unnecessary whitespace
            line = StripWhitespace(StripComments(line));

            //Handling for rows containing multiple lines and semicolons in strings
            //E.g. HEADER;FILE_DESCRIPTION((... OR #1=IFCOWNERHISTORY(...);#2=IFCDIRECTION((...));
            List<string> lineSegments = new List<string>();
            if(line.IndexOf(";") != line.LastIndexOf(";") && line.IndexOf(";") != -1){
                bool quotated = false;
                List<char> segmentCharacters = new List<char>();
                // Split line by looping through the characters
                foreach(char character in line){
                    segmentCharacters.Add(character);
                    //ignore ;'s inside quotes
                    if(character == '\''){
                        quotated = !quotated;
                    }
                    if(!quotated && character == ';'){
                        //Store segment and begin next segment
                        lineSegments.Add(new string(segmentCharacters.ToArray()));
                        segmentCharacters = new List<char>();
                    }
                }
            } else {
                lineSegments.Add(line);
            }

            
            //lineSegments only has one line in nearly all cases
            foreach(string lineSegment in lineSegments){
                //Header rows
                if(lineSegment.StartsWith("FILE_DESCRIPTION(") || lineSegment.StartsWith("FILE_NAME(") ||  lineSegment.StartsWith("FILE_SCHEMA(")){
                    Type t = GetIfcRowType(lineSegment);
                    IfcRow row = IfcRow.NewRow(t, lineSegment);
                    ifcFile.header_rows.Add(row);
                    //Debug.Log(row);
                    //Which version of IFC is this?
                    if (lineSegment.StartsWith("FILE_SCHEMA")) {
                        ifcFile.ifc_version = SplitParams(SplitParams(lineSegment)[0])[0];
                        //Debug.Log(string.Format("IFC version {0} detected.", ifcFile.ifc_version));
                        if (ifcFile.ifc_version == "'IFC2X3'") {
                            ifcFile.ifcVersionPostfix = "_IFC2X3";
                        }
                        else if (ifcFile.ifc_version == "'IFC4'") {
                            ifcFile.ifcVersionPostfix = "_IFC4";
                        }
                    }
                }


                //Handling data rows
                if (lineSegment.StartsWith("#")) {
                    //Get the row's type and create a new IfcRow
                    //We should know the ifc version by now
                    Type t = null;
                    if (ifcFile.ifc_version == "'IFC2X3'") {
                        t = GetIfcRowType(lineSegment, "_IFC2X3");
                    }
                    else if (ifcFile.ifc_version == "'IFC4'") {
                        t = GetIfcRowType(lineSegment, "_IFC4");
                    }
                    else {
                        throw new NotSupportedException("Please ensure that the file uses either IFC2X3 or IFC4.");
                    }
                    IfcRow row = IfcRow.NewRow(t, lineSegment);
                    //Add it to ref_to_row
                    ifcFile.ref_to_row[row.ifc_reference] = row;
                    //If it has an id, add it to id_to_row
                    List<string> ids = new List<string> {"Identifier", "Identification", "ID", "Id", "id", "GlobalId", "ResourceIdentifier", "RepresentationIdentifier", "ContextIdentifier", "SpaceProgramIdentifier", "ApplicationIdentifier", "ApplicationIdentifier", "ControlElementId", "DocumentId", "ActionID", "PermitID", "ProcedureID", "TaskId", "RequestID", "AssetID", "ControlElementId"};
                    foreach (string id in ids) {
                        if (t.GetField(id) != null) {
                            string key = (string)t.GetField(id).GetValue(row);
                            ifcFile.id_to_row[key] = row;
                            break;
                        }
                    }

                    //Special handling for IfcRelContainedInSpatialStructures because we want to find them based on space id
                    if (lineSegment.Contains("IFCRELCONTAINEDINSPATIALSTRUCTURE")) {
                        if (ifcFile.ifc_version == "'IFC2X3'") {
                            ifcFile.ifcrelcontainedinspatialstructures_IFC2X3.Add((IfcRelContainedInSpatialStructure_IFC2X3)row);
                        }
                        else if (ifcFile.ifc_version == "'IFC4'") {
                            ifcFile.ifcrelcontainedinspatialstructures_IFC4.Add((IfcRelContainedInSpatialStructure_IFC4)row);
                        }
                    }

                    //Special handling for IfcRelDefinesByProperties because we want to find them based on property set reference
                    if(lineSegment.Contains("IFCRELDEFINESBYPROPERTIES")){
                        if (ifcFile.ifc_version == "'IFC2X3'") {
                            // Get IfcPropertySet reference from row
                            IfcRelDefinesByProperties_IFC2X3 definesByProperties = row as IfcRelDefinesByProperties_IFC2X3;
                            string propertySetReference = definesByProperties.RelatingPropertyDefinition.ifc_reference;
                            // Assign to dictionary with property set reference as Key and type cast row as Value
                            ifcFile.propertySetReferenceToIfcRelDefinesByProperties_IFC2X3[propertySetReference] = definesByProperties;
                        }
                        if (ifcFile.ifc_version == "'IFC4'") {
                            // Get IfcPropertySet reference from row
                            IfcRelDefinesByProperties_IFC4 definesByProperties = row as IfcRelDefinesByProperties_IFC4;
                            string propertySetReference = ((IfcRow)definesByProperties.RelatingPropertyDefinition.Value).ifc_reference;
                            // Assign to dictionary with property set reference as Key and type cast row as Value
                            ifcFile.propertySetReferenceToIfcRelDefinesByProperties_IFC4[propertySetReference] = definesByProperties;
                        }
                    }

                    //Get the highest ifc_reference
                    int referenceNum = int.Parse(row.ifc_reference.Substring(1));
                    if(referenceNum > ifcFile.highest_ifc_reference){
                        ifcFile.highest_ifc_reference = referenceNum;
                    }
                    
                    //Grab ids of spaces so that we can connect them to IfcRelContainedInSpatialStructures later
                    if (lineSegment.Contains("IFCPROJECT") || lineSegment.Contains("IFCSITE") || lineSegment.Contains("IFCBUILDING") || lineSegment.Contains("IFCBUILDINGSTOREY") || lineSegment.Contains("IFCSPACE")) {
                        //First parameter is ID - grab that to connect to IfcRelContainedInSpatialStructure.
                        ifcFile.space_reference_to_id[lineSegment.Split('=')[0]] = SplitParams(lineSegment)[0];
                    }

                    if (lineSegment.Contains("IFCGEOMETRICREPRESENTATIONCONTEXT") && lineSegment.Contains(",'Model'")){
                        ifcFile.geometricRepresentationContextReference = lineSegment.Split('=')[0];
                    }

                    if (lineSegment.Contains("IFCGEOMETRICREPRESENTATIONSUBCONTEXT") && lineSegment.Contains("'Body','Model'")){
                        ifcFile.geometricRepresentationSubContextReference = lineSegment.Split('=')[0];
                    }
                }
            }
            
            

            //Row has been fully handled, so remove any stored values
            prev_line = "";
            return prev_line;

        }

        ///<summary>Connects IfcRow reference fields to the proper IfcRows.</summary>
        ///<param name="ifcFile">The IfcFile used to store the IfcRows.</param>
        public static void ConnectReferences(IfcFile ifcFile) {
            foreach (IfcRow r in ifcFile.ref_to_row.Values) {
                r.ConnectRefs(ifcFile.ref_to_row);
            }
        }
        ///<summary>Handles any special cases such as connecting space ids to spatial structures.</summary>
        ///<param name="ifcFile">The IfcFile used to store the IfcRows.</param>
        public static void HandleSpecialCases(IfcFile ifcFile){
            
            //Connect space ids to IfcRelContainedInSpatialStructures
            if (ifcFile.ifc_version == "'IFC2X3'") {
                foreach (IfcRelContainedInSpatialStructure_IFC2X3 cont in ifcFile.ifcrelcontainedinspatialstructures_IFC2X3) {
                    string id = ifcFile.space_reference_to_id[cont.RelatingStructure.ifc_reference];
                    ifcFile.structure_id_to_ifcrelcontainedinspatialstructure_IFC2X3[id] = cont;
                }
            }
            else if (ifcFile.ifc_version == "'IFC4'") {
                foreach (IfcRelContainedInSpatialStructure_IFC4 cont in ifcFile.ifcrelcontainedinspatialstructures_IFC4) {
                    string id = ifcFile.space_reference_to_id[cont.RelatingStructure.ifc_reference];
                    ifcFile.structure_id_to_ifcrelcontainedinspatialstructure_IFC4[id] = cont;
                }
            }
        }

        
        /// <summary>Populate the dictionaries in an IFC GameObject's IfcFile component by reading an IFC file. </summary>
        /// <param name="lines">The lines of an IFC file. </param>
        /// <param name="ifcFile">The IfcFile object used to store the IfcRows. </param>
        public static IEnumerator ParseIfcCoroutine(IfcFile ifcFile, string[] lines) {
            InitializeIfcFile(ifcFile);
            string prev_line = "";
            int i = 0;
            foreach(string l in lines)
            {
                //We'll do 1000 loops per frame
                //Less than that will slow the export down by a lot
                if (i>=1000){
                    yield return null;
                    i = 0;
                }
                i = i+1;
                ParseLine(l, ifcFile, prev_line);
            }
            HandleSpecialCases(ifcFile);
        }
        
        /// <summary>Strip any comments from an IFC file line. </summary>
        /// <param name="line">A line from an IFC file. </param>
        public static string StripComments(string line) {
            string blockComments = @"/\*(.*?)\*/";
            string lineComments = @"//(.*?)\r?\n";
            string strings = @"'((\\[^\n]|[^'\n])*)'";
            string verbatimStrings = @"@('[^']*')+";
            return Regex.Replace(line,
                blockComments + "|" + lineComments + "|" + strings + "|" + verbatimStrings,
                me => {
                    if (me.Value.StartsWith("/*") || me.Value.StartsWith("//"))
                        return me.Value.StartsWith("//") ? Environment.NewLine : "";
                    // Keep the literal strings
                    return me.Value;
                },
                RegexOptions.Singleline);
        }

        /// <summary>Strip any unnecessary whitespace from an IFC file line. </summary>
        /// <param name="line">A line from an IFC file. </param>
        public static string StripWhitespace(string line) {
            //Regex explanation:
            //('[^'\\]*(?:\\.[^'\\]*)*') finds all text in single quotes
            //\s+ finds all whitespace
            //Replacement pattern $1 keeps the single quote text, but gets rid of all other whitespace
            return Regex.Replace(line, @"('[^'\\]*(?:\\.[^'\\]*)*')|\s+", "$1");
        }

        /// <summary>Split the parameters of an IFC file line. </summary>
        /// <remarks>Split comma separated parameters within parentheses from an IFC file line, but keep lists inside nested parentheses as one parameter. <br />
        /// #ifc_reference=TYPE(param1, param2, param3); -> param1, param2, param3 <br />
        /// #ifc_reference=TYPE(param1, param2, (param3.1, param3.2, param3.3)); -> param1, param2, (param3.1, param3.2, param3.3) <br />
        /// Note: input must have at least one left and right parenthesis. </remarks>
        /// <param name="line">A line from an IFC file. </param>
        /// <returns>List of strings containing the IFC line's parameters. </returns>

        public static List<string> SplitParams(string line) {
            List<string> results = new List<string>();
            //Everything right of first '('
            line = line.Split(new[] {'('}, 2)[1];
            //Everything left of last ')'
            int idx = line.LastIndexOf(')');
            line = line.Substring(0,idx);
            //Replace commas inside parenthesis to avoid splitting on them
            //line = Regex.Replace(line, "/,(?=[^()]*\))/g", "_")
            string pattern = @",(?=(?>[^()]+|\((?<depth>)|\)(?<-depth>))*?(?(depth)(?!))\))";
            line = Regex.Replace(line, pattern, "IFC_EXPORTER_DO_NOT_SPLIT_ME");
            pattern = @",(?=[^']*'([^']*'[^']*')*[^']*$)";
            line = Regex.Replace(line, pattern, "IFC_EXPORTER_DO_NOT_SPLIT_ME");
            foreach (string l in line.Split(',')) {
                results.Add(l.Replace("IFC_EXPORTER_DO_NOT_SPLIT_ME",","));
            }
            //Alternate approach to pick parameters directly with regex
            /*var parameters = Regex.Matches(line, @"(?:[^,()]+((?:\((?>[^()]+|\((?<open>)|\)(?<-open>))*(?(open)(?!))\)))*)+" );
            foreach(string param in parameters) {
                results.Add(param);
            }*/
            return results;
        }

        /// <summary>Get the IfcRow type of an IFC file line. </summary>
        /// <remarks>Accepted input formats: <br /> 
        /// #ifc_row=TYPE(params) <br /> 
        /// TYPE(params) </remarks>
        /// <param name="line">A line from an IFC file. </param>
        /// <returns>The line's Type. Returns UnsupportedType if the Type isn't supported. </returns>

        public static Type GetIfcRowType(string line, string postfix = "") {
            /*Dictionary<string, Type> str_to_row_type = new Dictionary<string, Type>() {
                {"FILE_DESCRIPTION", typeof(File_Description)},
                {"FILE_NAME", typeof(File_Name)},
                {"FILE_SCHEMA", typeof(File_Schema)},
                {"IFCPROPERTYSET", typeof(IfcPropertySet)},
                {"IFCPROPERTYSINGLEVALUE", typeof(IfcPropertySingleValue)},
                {"IFCRELCONTAINEDINSPATIALSTRUCTURE", typeof(IfcRelContainedInSpatialStructure)},
                {"IFCSLAB", typeof(IfcSlab)},
                {"IFCLOCALPLACEMENT", typeof(IfcLocalPlacement)},
                {"IFCAXIS2PLACEMENT3D", typeof(IfcAxis2Placement3D)},
                {"IFCCARTESIANPOINT", typeof(IfcCartesianPoint)},
                {"IFCRELASSOCIATESMATERIAL", typeof(IfcRelAssociatesMaterial)},
                {"IFCRELDEFINESBYPROPERTIES", typeof(IfcRelDefinesByProperties)},
                {"IFCELEMENTQUANTITY", typeof(IfcElementQuantity)},
                {"IFCPRODUCTDEFINITIONSHAPE", typeof(IfcProductDefinitionShape)},
                {"IFCSHAPEREPRESENTATION", typeof(IfcShapeRepresentation)},
                {"IFCGEOMETRICREPRESENTATIONCONTEXT", typeof(IfcGeometricRepresentationContext)},
                {"IFCGEOMETRICREPRESENTATIONSUBCONTEXT", typeof(IfcGeometricRepresentationSubContext)},
                {"IFCEXTRUDEAREASOLID", typeof(IfcExtrudeAreaSolid)},
                {"IFCRECTANGLEPROFILEDEF", typeof(IfcRectangleProfileDef)},
                {"IFCAXIS2PLACEMENT2D", typeof(IfcAxis2Placement2D)},
                {"IFCDIRECTION", typeof(IfcDirection)}
            };*/
            
            if (line[0] == '#') {
                line = line.Split('=')[1];
            }
            line = line.Split('(')[0];
            Dictionary<string, Type> str_to_row_type = GetStrToRowType();
            if (str_to_row_type.ContainsKey(line)) {
                return str_to_row_type[line];
            }
            else if (str_to_row_type.ContainsKey(line+postfix)) {
                return str_to_row_type[line+postfix];
            }
            else {
                return typeof(UnsupportedType);
            }
        }

        ///<summary>Generates the dictionary used in GetIfcRowType() if it doesn't already exist.</summary>
        ///<returns>A dictionary connecting the string representations seen in IFC files to the corresponding types.</returns>
        private static Dictionary<string, Type> GetStrToRowType() {
            if (str_to_row_type == null) {
                Assembly asm = Assembly.GetExecutingAssembly();
                IEnumerable types = asm.GetTypes().Where(type => type.Namespace == "IfcToolkit.IfcSpec");
                str_to_row_type = new Dictionary<string, Type>() {};
                foreach (Type t in types) {
                    str_to_row_type[t.Name.ToUpper()] = t;
                }
            }
            return str_to_row_type;
        }

        ///<summary>Print the IfcRows with additional debugging information.</summary>
        ///<remarks>Needs to be updated to work with IfcGroups.</remarks>
        ///<param name="parsedFile">The IfcFile containing the IfcRows we want to print</param>
        private void DebugPrints(IfcFile parsedFile) {
            foreach (IfcRow row in parsedFile.ref_to_row.Values) {
                //Print ifc-file ready lines
                //Debug.Log(row.GenerateLine());

                //A more verbose debug print that also includes field names
                Type t = row.GetType();
                string l = t.Name + ": ";
                foreach (FieldInfo field in t.GetFields()) {
                    if (field.Name.Contains("param_order")) {continue;}
                    l += field.Name + " = ";
                    //Strings
                    if (field.FieldType == typeof(string)) {
                        l += (string)field.GetValue(row);
                    }
                    //References
                    else if (field.FieldType.IsSubclassOf(typeof(IfcRow))) {
                        IfcRow ref_row = (IfcRow)field.GetValue(row);
                        if (ref_row != null) {
                            l += "(IfcRow)"+ref_row.ifc_reference;
                        }
                        else {
                            l += "(IfcRow)$";
                        }
                    }
                    //Lists of strings
                    else if (field.FieldType == typeof(List<string>)) {
                        if (field.GetValue(row) != null) {
                            l += "(";
                            string.Join(",", (List<string>)field.GetValue(row));
                            /*foreach (string s in (List<string>)field.GetValue(row)) {
                                l += s + ", ";
                            }*/
                            l += ")";
                        }
                        else {
                            l += "$";
                        }
                    }
                    //Lists of IfcRows
                    else if (field.FieldType.IsGenericType && (field.FieldType.GetGenericTypeDefinition() == typeof(List<>)) && field.FieldType.GetGenericArguments()[0].IsSubclassOf(typeof(IfcRow))) {
                        l += "(";
                        if(field.GetValue(row) != null) {
                            foreach (IfcRow r in (IList)field.GetValue(row)) {
                                if (r != null) {
                                    l += "(IfcRow)" + r.ifc_reference + ", ";
                                }
                                else {
                                    l += "(IfcRow)$, ";
                                }
                            }
                        }
                        l += ")";

                    }
                    l += ", ";
                }
                Debug.Log(l);
            }
        }
        
        // Start is called before the first frame update
        void Start()
        {
            ifcGameObject = new GameObject();
            ifcGameObject.AddComponent(typeof(IfcFile));
            IfcFile f = (IfcFile)ifcGameObject.GetComponent(typeof(IfcFile));
            DateTime starttime = System.DateTime.Now;     // for measuring optimization
            string filename = "editor_test";
            string[] lines = System.IO.File.ReadAllLines(filename);
            ParseIfc(f, lines);
            // //print field names and values
            // DebugPrints((IfcFile)ifcGameObject.GetComponent(typeof(IfcFile)));
            

            /* 
            //print ifc datarow lines
            foreach (IfcRow r in f.ref_to_row.Values) {
                Debug.Log(r.GenerateLine());
            }
            */
            
            DateTime endtime = System.DateTime.Now;       // for measuring optimization
            Debug.Log(endtime - starttime);   
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
    


