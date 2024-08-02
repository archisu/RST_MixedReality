//using IfcToolkit;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using TMPro;
//using System;
//using Trimble.Connect.PSet.Client;
//using UnityEditor.PackageManager.Requests; //do we need to download it???
//using System.Net.Http;
//using System.Linq;
//using UnityEngine.Networking;
//using Newtonsoft.Json.Linq;


//public class ParentIFCAttr : MonoBehaviour
//{
//    // Reference to the UI Text component

//    public Text ifcIDText;

//    void Start()
//    {
//        string kjjh = "";
//    }



//    public void OnClick()
//    {

//        var statusCurrent = new StatusData();
//        statusCurrent.Status = "true";
//        statusCurrent.ProjectID = "asdfasdf";
//        statusCurrent.IFCGuid = "a;ooigfhlas";
//        Debug.LogError("you are at line 36");
//        var JData = JObject.FromObject(statusCurrent);
//        var jString = Newtonsoft.Json.JsonConvert.SerializeObject(JData);

//        //var client = new RestClient("http://10.0.155.107:5000");
//        //var request = new RestRequest("api/test/" + index);

//        //var response = client.ExecuteGet(request);
//        // Find the parent object
//        Transform parentTransform = transform.parent;

//        if (parentTransform != null)
//        {
//            // Find the grandparent object (parent of the parent)
//            Transform grandparentTransform = parentTransform.parent;

//            if (grandparentTransform != null)
//            {
//                // Get the IFC ID from the grandparent object's script/component
//                // Assuming the grandparent object has a script/component with a public property/field "IfcID"
//                var grandparentComponent = grandparentTransform.GetComponent<IfcAttributes>();

//                if (grandparentComponent != null)
//                {
//                    var ifcID = grandparentComponent.attributes; //tobias????????

//                    // Display the IFC ID in the UI Text element
//                    if (ifcIDText != null)
//                    {
//                        ifcIDText.text = "IFC ID: " + ifcID;
//                    }
//                    else
//                    {
//                        Debug.LogError("IFC ID Text component is not assigned.");
//                    }
//                }
//                else
//                {
//                    Debug.LogError("Grandparent object does not have the required component.");
//                }
//            }
//            else
//            {
//                Debug.LogError("No grandparent object found.");
//            }
//        }
//        else
//        {
//            Debug.LogError("No parent object found.");
//        }

//    }

//    public void WebReqExample()
//    {

//    }

//    public class StatusData
//    {
//        public string IFCGuid { get; set; }
//        public string ProjectID { get; set; }
//        public string Status { get; set; }
//    }
//}
