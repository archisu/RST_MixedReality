using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;

namespace IfcToolkit {

///<summary>Class containing functions for reconstructing an IFC hierarchy for an imported OBJ file. </summary>
/// <remarks>This is used to recreate the element hierarchy that was lost when converting ifc to obj during runtime import.
/// We do this by recursively looping through the xml-file's decomposition hierarchy.
/// Usage: TreeBuilder.ReconstructTree(rootObject, (optional) xml_path).
/// Usually called from ObjectLoader.Load().</remarks>
public class TreeBuilder
{
    ///<summary>Recreates the IFC hierarchy for an imported OBJ. </summary>
    ///<param name="root">The root GameObject.</param>
    ///<param name="xml_path">Path to the XML-file describing the IFC hierarchy.</param>
    public static void ReconstructTree(GameObject root, string xml_path = "") {
        if (xml_path == "") {
            xml_path = "Assets/IfcImporter/Resources/" + root.name.Remove(root.name.Length - 3) + "xml.xml";
        }
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(xml_path);
        string xmlPathPattern = "//ifc/decomposition/IfcProject";
        XmlNodeList myNodeList = xmlDoc.SelectNodes(xmlPathPattern);
        ParseIfcHierarchy(myNodeList, root);
    }

    ///<summary>Goes through the XML nodes to parse the IFC hierarchy.</summary>
    ///<param name="nlist">A list of XML nodes.</param>
    ///<param name="root">The root GameObject.</param>
    private static void ParseIfcHierarchy(XmlNodeList nlist, GameObject root) {
        // recursive loop for xml decomposition hierarchy
        foreach(XmlNode node in nlist){
            //Skip elements without id attribute and the IfcProject
            if(node.Attributes["id"] != null && node.Name != "IfcProject"){
                GameObject nodeObject = null;
                //If the matching game object exists, find it. If it doesn't create a new one.
                if (GameObject.Find(node.Attributes["id"].InnerText)) {
                    nodeObject = GameObject.Find(node.Attributes["id"].InnerText);
                }
                else {
                    nodeObject = new GameObject(node.Attributes["id"].InnerText);
                }
                
                //Set the nodeObject's parent. Special handling for root object, since that one is named after the file, not the id.
                if (node.ParentNode.Name == "IfcProject") {
                    nodeObject.transform.parent = root.transform;
                }
                else {
                    nodeObject.transform.parent = GameObject.Find(node.ParentNode.Attributes["id"].InnerText).transform;
                }
                
            }
            //Repeat for children
            ParseIfcHierarchy(node.ChildNodes, root);
        }
    }
}
}
