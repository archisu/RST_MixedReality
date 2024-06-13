using UnityEditor;
using UnityEngine;

using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace IfcToolkit {

/// <summary>Class that adds IFC GameObject an optional import settings window to the Unity editor top menu bar. </summary>
public class IfcSettingsWindow : EditorWindow
{
    public static IfcSettingsOptionHolder options = new IfcSettingsOptionHolder();

    [MenuItem("Edit/IFC Importer Settings...")]
    public static void ShowWindow()
    {
        EditorWindow settingsWindow = EditorWindow.GetWindow(typeof(IfcSettingsWindow));
        settingsWindow.titleContent = new GUIContent("IFC importer settings");
        settingsWindow.minSize = new Vector2(440,250);
        settingsWindow.Show();
    }
    
    void OnGUI()
    {
        float originalValue = EditorGUIUtility.labelWidth;
        EditorGUIUtility.labelWidth = 400;
        options.meshCollidersEnabled = EditorGUILayout.Toggle ("Add mesh colliders", options.meshCollidersEnabled);
        options.materialsEnabled = EditorGUILayout.Toggle ("Import IFC material layer sets", options.materialsEnabled);
        options.propertiesEnabled = EditorGUILayout.Toggle ("Import IFC property sets", options.propertiesEnabled);
        options.attributesEnabled = EditorGUILayout.Toggle ("Import IFC attributes", options.attributesEnabled);

        options.typesEnabled = EditorGUILayout.Toggle ("Import IFC types", options.typesEnabled);
        options.headerEnabled = EditorGUILayout.Toggle ("Import IFC header", options.headerEnabled);
        options.unitsEnabled = EditorGUILayout.Toggle ("Import IFC units", options.unitsEnabled);
        options.quantitiesEnabled = EditorGUILayout.Toggle ("Import IFC quantities", options.quantitiesEnabled);

        options.parallelProcessingEnabled = EditorGUILayout.Toggle ("Extract model and metadata in parallel (memory intensive)", options.parallelProcessingEnabled);
        options.keepOriginalPositionEnabled = EditorGUILayout.Toggle ("Keep the original position of the model. Otherwise moved to origin.", options.keepOriginalPositionEnabled);
        options.keepOriginalPositionForPartsEnabled = EditorGUILayout.Toggle ("Keep original position of individual parts. Otherwise moved near origin.", options.keepOriginalPositionForPartsEnabled);

        options.exclude_option = EditorGUILayout.TextField("Exclude element types from model on import", options.exclude_option);
        EditorGUIUtility.labelWidth = originalValue;
    }

    //Updates the values on the window to correspond to the stored preferences.
    void OnFocus()
    {
        foreach(FieldInfo field in options.GetType().GetFields()) {
            if (EditorPrefs.HasKey(field.Name)) {
                if (Object.ReferenceEquals(field.FieldType, typeof(bool))) {
                    field.SetValue(options, EditorPrefs.GetBool(field.Name));
                } else if (Object.ReferenceEquals(field.FieldType, typeof(string))) {
                    field.SetValue(options, EditorPrefs.GetString(field.Name));
                }
            }
        }
    }

    //Stores the values on the window to the stored preferences when the window loses focus.
    void StoreValues()
    {
        foreach(FieldInfo field in options.GetType().GetFields()) {
            if (Object.ReferenceEquals(field.FieldType, typeof(bool))) {
                EditorPrefs.SetBool(field.Name, (bool)field.GetValue(options));
            } else if (Object.ReferenceEquals(field.FieldType, typeof(string))) {
                EditorPrefs.SetString(field.Name, (string)field.GetValue(options));
            }
        }
    }

    void OnLostFocus()
    {
        StoreValues();
    }

    //Stores the values on the window to the stored preferences when the window is closed.
    void OnDestroy()
    {
        StoreValues();
    }
}
}
