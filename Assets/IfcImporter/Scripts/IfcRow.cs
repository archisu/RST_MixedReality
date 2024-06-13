using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using UnityEngine;
using IfcToolkit.IfcSpec;

namespace IfcToolkit {

/// <summary>A class used to store data contained in a single IFC file data row. </summary>
/// <remarks> IfcRow also handles the functionality shared between all IfcRows.
/// Subclasses define the type and order of parameters.</remarks>
public abstract class IfcRow {
    public string ifc_reference;
    public List<string> param_order = new List<string>{};
    //Subclasses extend this by appending their parameter orders.
    public virtual List<string> ParameterOrder() {return new List<string>{};}

    ///<summary>Constructs a new IfcRow from a line</summary>
    ///<remarks>Assigns the parameters found in line based on the ParameterOrder implemented in subclasses.</remarks>
    ///<param name="line">The .ifc file string the IfcRow is generated from.</<param>
    ///<returns>The new IfcRow.</returns>
    public IfcRow(string line) {
        line = line.Trim();
        string postfix = this.GetPostfix();
        //Handle omitted attributes - * means null, except it can be derived from other fields
        if (line == "*") {
            ifc_reference = line;
            return;
        }
        //Handle reference only lines that are meant to be replaced with the real thing later
        if (line.StartsWith("#") && !line.Contains("=")) {
            ifc_reference = line;
            return;
        }
        //Grab ifc_reference if we have one.
        //Embedded IfcRows like Type_B in example below wouldn't have one.
        //#ifc_ref=TYPE_A(TYPE_B(...), ...);
        if (line.StartsWith("#")) {
            ifc_reference = line.Split('=')[0];
        }
        //Split the input line into a list of parameters
        List<string> p = IfcParser.SplitParams(line);
        Type t = this.GetType();
        //Use current IfcRow's Type to iterate through the fields one by one and assign values
        foreach (FieldInfo field in t.GetFields()) {
            //Fields are always in the same order in the IFC-file.
            //Determine the index of the current field based on its name.
            int param_index = ParameterOrder().IndexOf(field.Name);
            /*if (param_index == -1 && field.Name != "ifc_reference")
            {
                Debug.Log(string.Format("Type {0} field {1} param_index {2}", t.Name, field.Name, "-1"));
            }*/
            //Index is -1 for fields that aren't in the IFC file, so ignore those
            if (param_index != -1) {
                //Direct values
                if (field.FieldType == typeof(string)) {
                    //Assign value for Type->Field->(object, value)
                    field.SetValue(this, p[param_index]);
                }
                //IfcRow fields
                else if (field.FieldType.IsSubclassOf(typeof(IfcRow))) {
                    //NewRow is used to construct a new IfcRow of arbitrary type
                    //For now it's just a place holder containing only the ifc_reference
                    //We connect those to the actual rows later
                    field.SetValue(this, NewRow(field.FieldType, p[param_index]));
                }
                //IfcGroup fields
                else if (field.FieldType.IsSubclassOf(typeof(IfcGroup))) {
                    //NewGroupFromString creates a new group of arbitrary type
                    field.SetValue(this, IfcGroup.NewGroupFromString(field.FieldType, p[param_index], postfix));
                }
                //Lists
                else if (field.FieldType.IsGenericType && (field.FieldType.GetGenericTypeDefinition() == typeof(List<>))) {
                    //NewList, surprisingly enough, creates the lists we need.
                    field.SetValue(this, NewList(field.FieldType, p[param_index], postfix));
                }
            }
        }
    }

    ///<summary>Constructs an IfcRow from a dictionary of parameters.</summary>
    ///<remarks>Note: Do not forget to add single quotes around some of the string values!
    ///Example: #4229=IFCSLAB('3ThA22djr8AQQ9eQMA5s7I',#1,'Basic Roof:Live Roof over Wood Joist Flat Roof:184483',$,'Basic Roof:Live Roof over Wood Joist Flat Roof',#17869,#17009,'184483',.ROOF.);
    ///The first value (id) has single quotes, while the last (predefined_type) doesn't.
    ///We treat both as strings, so to property add id it should be "'3ThA22djr8AQQ9eQMA5s7I'", not just "3ThA22djr8AQQ9eQMA5s7I".
    ///Predefined_type, on the other hand, would be simply ".ROOF.".</remarks>
    ///<param name="p">The parameter dictionary used to construct to IfcRow.</param>
    ///<returns>The new IfcRow.</returns>
    public IfcRow(Dictionary<string, object> p) {
        /*
        //Example usage (Out of date - UnsupportedTypes should be something else now)
        Dictionary<string, object> parameters = new Dictionary<string, object>{
            {"id", "sfhladasd"},
            {"owner_history", "#1"},
            {"name", "Bob"},
            {"related_objects", new List<UnsupportedType> {new UnsupportedType("#123"), new UnsupportedType("#124"), new UnsupportedType("#125")}},
            {"relating_material" , new UnsupportedType("#8888888")},
            {"ifc_reference", "#99999999#"}
            };
        IfcRow r = new IfcRelAssociatesMaterial(parameters);
        Debug.Log(r.GenerateLine());
        */
    
        Type t = this.GetType();
        string postfix = this.GetPostfix();
        /* Loops through the dictionary of parameters, check what type that field is supposed to be, and handles it accordingly.
         */
        foreach (string param_name in p.Keys) {
            FieldInfo field = t.GetField(param_name);
            if (p[param_name] == null) {
                continue;
            }
            Type pt = p[param_name].GetType();
            //Direct values
            if (field.FieldType == typeof(string) && pt == typeof(string)) {
                field.SetValue(this, p[param_name]);
            }
            //IfcRow fields
            else if (field.FieldType.IsSubclassOf(typeof(IfcRow))) {
                //Reference given as ifc_reference string e.g. #123
                if (pt == typeof(string)) {
                    field.SetValue(this, NewRow(field.FieldType, (string)p[param_name]));
                }
                //Reference given as an IfcRow
                else if (pt.IsSubclassOf(typeof(IfcRow))) {
                    field.SetValue(this, p[param_name]);
                }
            }
            //IfcGroup fields
            else if (field.FieldType.IsSubclassOf(typeof(IfcGroup))) {
                //Member given as a string
                if (pt == typeof(string)) {
                    string pstring = (string)p[param_name];
                    field.SetValue(this, IfcGroup.NewGroupFromString(field.FieldType, pstring, postfix));
                }
                //Member given as an IfcRow
                else if(pt.IsSubclassOf(typeof(IfcRow))) {
                    field.SetValue(this, IfcGroup.NewGroup(field.FieldType, p[param_name]));
                }
            }
            //Lists
            else if (field.FieldType.IsGenericType && (field.FieldType.GetGenericTypeDefinition() == typeof(List<>))) {
                //Null list
                if (p[param_name] == null) {
                    field.SetValue(this, null);
                }
                //List given as string
                else if (pt == typeof(string)) {
                    field.SetValue(this, NewList(field.FieldType, (string)p[param_name], postfix));
                }
                //List given as list
                else if (pt.IsGenericType && (pt.GetGenericTypeDefinition() == typeof(List<>))) {
                    //Empty lists
                    if (((IList)p[param_name]).Count == 0) {
                        field.SetValue(this, (IList)Activator.CreateInstance(field.FieldType));
                    }
                    //List given as a list of strings
                    else if (pt.GetGenericArguments()[0] == typeof(string)) {
                        //List of values
                        if (field.FieldType == typeof(List<string>)) {
                            field.SetValue(this, p[param_name]);
                        }
                        //List of IfcRows
                        else if (field.FieldType.GetGenericArguments()[0].IsSubclassOf(typeof(IfcRow))) {
                            IList row_list = (IList)Activator.CreateInstance(field.FieldType);
                            foreach (string ifc_ref in (List<string>)p[param_name]) {
                                if (ifc_ref == null) {
                                    row_list.Add(null);
                                }
                                else {
                                    IfcRow r = NewRow(field.FieldType.GetGenericArguments()[0], ifc_ref);
                                    row_list.Add(r);
                                }
                            }
                            field.SetValue(this, row_list);
                        }
                        //List of IfcGroups
                        else if (field.FieldType.GetGenericArguments()[0].IsSubclassOf(typeof(IfcGroup))) {
                            IList group_list = (IList)Activator.CreateInstance(field.FieldType);
                            foreach (string member in (List<string>)p[param_name]) {
                                group_list.Add(IfcGroup.NewGroupFromString(field.FieldType.GetGenericArguments()[0], member, postfix));
                            } 
                            field.SetValue(this, group_list);
                        }
                        //List of Lists
                        else if (field.FieldType.GetGenericArguments()[0].IsGenericType && (field.FieldType.GetGenericTypeDefinition() == typeof(List<>))) {
                            IList list_list = (IList)Activator.CreateInstance(field.FieldType);
                            foreach (string listString in (List<string>)p[param_name]) {
                                list_list.Add(NewList(field.FieldType.GetGenericArguments()[0], listString, postfix));
                            }
                            field.SetValue(this, list_list);
                        }
                    }
                    //Lists given in the same format as the field
                    else if (pt.GetGenericArguments()[0] == field.FieldType.GetGenericArguments()[0]) {
                        field.SetValue(this, p[param_name]);
                    }
                }
            }
        }
    }

    /* Creates a new row of type t by giving line to its constructor.
     * In case of references, this creates a placeholder to be replaced later.
     */
    ///<summary>Creates a new row of Type t.<summary>
    ///<remarks>Meant to be used when the type of the row isn't known until runtime. If the type is known, use a regular constructor instead.
    ///In case of references, this creates a placeholder to be replaced later.</remarks>
    ///<param name="t">The type of the row being created. Note that IfcRow itself is an abstract class and therefore not a valid option.</param>
    ///<param name="line">The .ifc file string used to construct the row.</param>
    ///<returns>The newly created IfcRow.</returns>
    public static IfcRow NewRow(Type t, string line) {
        if (line == "$") {
            return null;
        }
        else {
            return (IfcRow)Activator.CreateInstance(t, new object[]{line});
        }
    }

    ///<summary>Creates a new list of the given type from the given string.</summary>
    ///<param name="fieldType">Type of the list, for example List<IfcCartesianPointPoint_IFC2X3>.</param>
    ///<param name="fieldString">A string representation of the list, as seen in IFC-files.</param>
    ///<param name="postfix">A postfix required to properly type IfcGroups.</param>
    ///<returns>A new List of type fieldType, with values determined by fieldString.</returns>
    public IList NewList(Type fieldType, string fieldString, string postfix) {
        //Null lists
        if (fieldString == "$") {
            return null;
        } 
        //Empty lists
        else if (fieldString == "()") {
            return (IList)Activator.CreateInstance(fieldType);
        }
        //Lists of values
        else if (fieldType == typeof(List<string>)) {
            return (IList)IfcParser.SplitParams(fieldString);
        }
        //Lists of IfcRows
        else if (fieldType.GetGenericArguments()[0].IsSubclassOf(typeof(IfcRow))) {
            IList rows = (IList)Activator.CreateInstance(fieldType);
            foreach (string l in IfcParser.SplitParams(fieldString)) {
                rows.Add(NewRow(fieldType.GetGenericArguments()[0], l));
            }
            return rows;
        }
        //Lists of IfcGroups
        else if (fieldType.GetGenericArguments()[0].IsSubclassOf(typeof(IfcGroup))) {
            IList groups = (IList)Activator.CreateInstance(fieldType);
            foreach (string l in IfcParser.SplitParams(fieldString)) {
                groups.Add(IfcGroup.NewGroupFromString(fieldType.GetGenericArguments()[0], l, postfix));
            }
            return groups;
        }
        //Lists of lists
        else if (fieldType.GetGenericArguments()[0].IsGenericType && (fieldType.GetGenericArguments()[0].GetGenericTypeDefinition() == typeof(List<>))) {
            IList lists = (IList)Activator.CreateInstance(fieldType);
            //var list_type = typeof(List<>).MakeGenericType(field.FieldType.GetGenericArguments()[0]);
            Type subListType = fieldType.GetGenericArguments()[0]; 
            foreach (string l in IfcParser.SplitParams(fieldString)) {
                lists.Add(NewList(subListType, l, postfix));
            }
            return lists;
        }
        //This should never happen. Should the final else-if be an else instead?
        //On the other hand, it's nice if the code explicitly fails when something weird happens.
        string e = string.Format("Unable to parse a {0} from string {1}.", fieldType.FullName, fieldString);
        throw new ArgumentException(e);
    }


    ///<summary>Checks if the IfcRow ends with a postfix corresponding to a known Ifc version and returns it.</summary>
    ///<returns>"_IFC2X3" or "_IFC4" as appropriate, "" if no postfix is recognized.</returns>
    public string GetPostfix() {
        if (this.GetType().Name.EndsWith("_IFC2X3")) {
            return "_IFC2X3";
        }
        else if (this.GetType().Name.EndsWith("_IFC4")) {
            return "_IFC4";
        }
        else {
            return "";
        }
    }


    ///<summary>Replaces any reference only IfcRows with the corresponding real rows.</summary>
    ///<remarks>Ifc references are the part at the part of the .ifc file string. For example:
    ///#4229=IFCSLAB('3ThA22djr8AQQ9eQMA5s7I',#1,'Basic Roof:Live Roof over Wood Joist Flat Roof:184483',$,'Basic Roof:Live Roof over Wood Joist Flat Roof',#17869,#17009,'184483',.ROOF.);
    ///The ifc_reference for the slab above would be #4229.</remarks>
    ///<param name="ref_to_row">An ifc_reference to row dictionary. We replace any fields with a placeholder IfcRow with the matching row from the dictionary.</param>
    public void ConnectRefs(Dictionary<string, IfcRow> ref_to_row) {
        Type t = this.GetType();
        foreach (FieldInfo field in t.GetFields()) {
            if (field.FieldType.IsSubclassOf(typeof(IfcRow))) {
                IfcRow ref_row = (IfcRow)field.GetValue(this);
                if (ref_row != null && ref_row.ifc_reference != "*") {
                    if (ref_to_row.ContainsKey(ref_row.ifc_reference)) {
                        //Debug.Log(string.Format("Row type: {0}, Row ref: {1}, Field: {2}, Field type: {3}", t.Name, this.ifc_reference, field.Name, field.FieldType));
                        field.SetValue(this, ref_to_row[ref_row.ifc_reference]);
                    }
                }
            }
            else if (field.FieldType.IsSubclassOf(typeof(IfcGroup))) {
                IfcGroup group = (IfcGroup)field.GetValue(this);
                if (group.ValueType().IsSubclassOf(typeof(IfcRow))) {
                    IfcRow ref_row = (IfcRow)group.Value;
                    if (ref_row != null && ref_row.ifc_reference != "*") {
                        if(ref_to_row.ContainsKey(ref_row.ifc_reference)) {
                            group.Value = ref_to_row[ref_row.ifc_reference];
                        }
                    }
                }
            }
        }
    }

    ///<summary>Generates the .ifc file line for the IfcRow.</summary>
    ///<param name="postfix">Postfix to be removed from the name of the IfcRow. We could use GetPostfix() instead of a parameter.</param>
    ///<returns>The line for the IfcRow as it would appear in the IFC-file.</returns>
    public string ToString(string postfix) {
        string line = "";
        //Start with ifc_reference, unless we're dealing with an IfcRow embedded in another IfcRow
        if (this.ifc_reference != null) {
            line += this.ifc_reference + "=";
        }
        if (this.ifc_reference == "*") {
            //Sometimes IfcRows have * as one of the parameters
            //This means the attribute is a regular explicit attribute in the supertype,
            //but it has been redefined as a derivated attribute in the subtype.
            //In other words null, except you are supposed to calculate it
            return "*";
        }
        Type t = this.GetType();
        //UnsupportedTypes store the original line, so we'll simply use it
        if (t == typeof(UnsupportedType)) {
            UnsupportedType urow = (UnsupportedType)this;
            return urow.line;
        }
        //IfcRow's type in all caps and with postfix removed
        line += t.Name.ToUpper().Replace(postfix, "") + "(";
        //Fields separated by commas
        foreach (string param in ParameterOrder()) {
            FieldInfo field = t.GetField(param);
            //Find missing parameters for debugging - do we have a typo somewhere?
            // if (field == null) {
            //     Debug.Log(string.Format("Missing parameter in ref {0}, type {1}, param {2}", this.ifc_reference, t.Name, param));
            // }
            line += FieldToString(field.FieldType, field.GetValue(this), postfix);
        }
        //Remove the final comma and close the parenthesis
        if (line.EndsWith(",")) {
            line = line.Remove(line.Length - 1);
        }
        line += ")";
        //Add a semicolon, unless the IfcRow is embedded in another IfcRow
        if (this.ifc_reference != null) {
            line += ";";
        }
        return line;
    }


    ///<summary>Used to generate string representations for various fields.</summary>
    ///<remarks>Called recursively to handle lists.</remarks>
    ///<param name="fieldType">Type of the value, as determined by the field or parent list.</param>
    ///<param name="value">The value we are generating the string representation for.</param>
    ///<param name="postfix">The postfix to be removed from class names as necessary.</param>
    ///<returns>The field as it would appear in the IFC-file.</returns>
    private string FieldToString(Type fieldType, object value, string postfix) {
        //Null values
        if (value == null) {
            return "$,";
        }
        else {
            //Values
            if (fieldType == typeof(string)) {
                return (string)value + ",";
            }
            //IfcRows
            else if (fieldType.IsSubclassOf(typeof(IfcRow))) {
                IfcRow row = (IfcRow)value;
                //Reference to IfcRow
                if (row.ifc_reference != null) {
                    return row.ifc_reference + ",";
                }
                //Embedded IfcRow
                else {
                    return row.ToString(postfix);
                }
            }
            //IfcGroups
            else if (fieldType.IsSubclassOf(typeof(IfcGroup))) {
                return ((IfcGroup)value).ToString(postfix) + ",";
            }
            //Lists
            else if (fieldType.IsGenericType && (fieldType.GetGenericTypeDefinition() == typeof(List<>))) {
                string line = "(";
                //Loop through values and recursively call this function to generate strings for each
                foreach(object o in (IList)value) {
                    line += FieldToString(fieldType.GetGenericArguments()[0], o, postfix);
                }
                //Remove the last ","
                if (line.EndsWith(",")) {
                    line = line.Remove(line.Length - 1);
                }
                return line + "),";
            }
            string e = string.Format("Unable to determine string representation for type {0} value {1}.", fieldType, value);
            throw new ArgumentException(e);
        }
    }
}

/// <summary>Class for IFC file rows unsupported by IfcSpec such as custom non-standard IFC objects added by hacky BIM designers.</summary>
public class UnsupportedType : IfcRow {
    public string line;
    public new List<string> param_order = new List<string>{};
    public override List<string> ParameterOrder() {return new List<string>(base.ParameterOrder().Concat(param_order));}
    public UnsupportedType(string line) : base(line){this.line = line;}
    public UnsupportedType(Dictionary<string, object> p) :base(p){}
}
}
