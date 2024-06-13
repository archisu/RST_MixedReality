using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace IfcToolkit {

    /// <summary>A class used to handle cases where a value on an IfcRow can be one of several possible types.</summary>
    /// <remarks>IfcGroup handles the shared functionality between all IfcGroups.
    /// Subclasses define the allowed types.
    /// Group here is used as in group of possible Types the value could be.</remarks>
public abstract class IfcGroup
{
    public static List<Type> allowed_types = new List<Type>{};
    private object _value;
    //Attribute used to handle type checking for Values.
    public object Value {
        //Called when myGroup.Value is used
        get {
            return _value;
        }
        //Called when values are assigned to myGroup.Value. As with all attribute setter functions, value is the value being assigned.
        set {
            List<Type> allowed_types = (List<Type>)this.GetType().GetField("allowed_types").GetValue(null);
            //Null values
            if (value == null || (value.GetType() == typeof(string) && (string)value == "$")) {
                _value = "$";
                return;
            }
            //Omitted values - means it can be derived from other fields
            if (value.GetType() == typeof(string) && (string)value == "*") {
                _value = value;
                return;
            }
            //Normal cases
            Type value_type = value.GetType();
            foreach (Type allowed_type in allowed_types) {
                if (value_type == allowed_type || value_type.IsSubclassOf(allowed_type)) {
                    _value = value;
                    return;
                }
            }
            //Failed to assign value - throw an exception!
            string allowed_type_names = string.Join(", ", from t in allowed_types select t.FullName);
            string e = string.Format("Invalid value: {0}:{1}. Values for {2} must be of types {3}.", value_type.FullName, value, this.GetType().FullName, allowed_type_names);
            throw new ArgumentException(e);
        }
    }

    /// <summary>Create a new IfcGroup.</summary>
    /// <param name="value">Value assigned to the group.</param>
    public IfcGroup(object value) {
        this.Value = value;
    }

    /// <summary>Returns the type of the group's current value.</summary>
    public Type ValueType() {return Value.GetType();}

    /// <summary>Returns either the string value, ifc_reference, or full IfcRow line as appropriate.</summary>
    /// <param name="postfix">Postfix removed from the IfcRow's name when generating full IfcRow lines.</param>
    public string ToString(string postfix) {
        if (this.ValueType().IsSubclassOf(typeof(IfcRow))) {
            IfcRow value_row = (IfcRow)Value;
            if (value_row.ifc_reference != null) {
                return value_row.ifc_reference;
            }
            else {
                return value_row.ToString(postfix);
            }
        }
        else {
            return (string)Value;
        }
    }
    
    ///<summary>Creates a new Group of type t by giving value to its constructor.</summary>
    ///<remarks>Used instead of the constructor when the type of the group isn't known until runtime.</remarks>
    ///<param name="t">Type of the group to be created.</param>
    ///<param name="value">Value to be assigned to the group.</param>
    public static IfcGroup NewGroup(Type t, object value) {
        return (IfcGroup)Activator.CreateInstance(t, new object[]{value});
    }
    
    ///<summary>Creates a new Group of type t by first parsing the value type from a string.</summary>
    ///<param name="t">Type of the group to be created.</param>
    ///<param name="value">The value to be assigned to the group, given in string format.</param>
    ///<param name="postfix">Postfix needed by IfcParser.GetIfcRowType() for determining embedded IfcRow type.</param>
    public static IfcGroup NewGroupFromString(Type t, string value, string postfix) {
        //Null values
        if (value == "$" || value == "*" || value == null) {
            return NewGroup(t, value);
        }
        //IfcRow reference
        if (value.StartsWith("#")) {
            //Impossible to tell type
            //Create a placeholder, connect real row later
            List<Type> allowed_types = (List<Type>)t.GetField("allowed_types").GetValue(null);
            foreach(Type allowed_type in allowed_types) {
                if (allowed_type.IsSubclassOf(typeof(IfcRow))) {
                    return NewGroup(t, IfcRow.NewRow(allowed_type, value));
                }
            }
        }
        //Embedded IfcRows
        Type row_type = IfcParser.GetIfcRowType(value, postfix);
        if (TypeIsAllowed(t, row_type)) {
            return NewGroup(t, IfcRow.NewRow(row_type, value));
        }
        //String values
        if (TypeIsAllowed(t, typeof(string))) {
            return NewGroup(t, value);
        }
        string allowed_type_names = string.Join(", ", from at in allowed_types select at.FullName);
        string e = string.Format("Value {0} does not appear to be of any of the allowed types for {1}. It should be of one of the following types: ({2}).", value, t.FullName, allowed_type_names);
        throw new ArgumentException(e);
    }

    ///<summary>A function used to check if the given type is among the allowed types for the group type.</summary>
    ///<remarks>Used to check if an IfcGroup instance with the value of a given type can be created.</remarks>
    ///<param name="group_type">The type of the IfcGroup we are trying to add the value to.</param>
    ///<param name="value_type">The type of the value we are trying to add to the group.</param>
    ///<returns>true if the value can be added, false if it cannot.</returns>
    private static bool TypeIsAllowed(Type group_type, Type value_type) {
        List<Type> allowed_types = (List<Type>)group_type.GetField("allowed_types").GetValue(null);
        if (allowed_types.Contains(value_type)) {
            return true;
        }
        foreach(Type allowed_type in allowed_types) {
            if (value_type.IsSubclassOf(allowed_type)) {
                return true;
            }
        }
        return false;
    }

}
}
