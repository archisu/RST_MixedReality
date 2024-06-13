using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IfcToolkit;

namespace IfcToolkitDemo {

/// <summary>An example Class that imports an IFC model on Start(). </summary>
/// <remarks>To run the demo, you need to
/// 1) Ensure you've completed the installation guide in the README.
/// 2) Ensure RuntimeImportDemo.cs is attached to a GameObject in the opened scene.
/// 3) Place an ifc file you wish to test inside the project folder.
/// 4) Edit the assetPath and filename below to point to your ifc-file.
/// 5) Press play. Your building should appear after a few seconds.
/// You can also build and run the scene. For this you should make sure both your ifc-file and IfcConvert executable are in the resulting build folder and the assetPath and the filename below are still correct.
///
/// In other words you need to:
/// 1. Create a folder named "Assets" in your build folder.
/// 2. Copy IfcConvert.exe into the Assets folder
/// 3. Create a folder named "IfcImporter" in the Assets folder
/// 4. Create a folder named "Demo" in the IfcImporter folder
/// 5. Copy demo_duplex.ifc to the Demo folder.
/// </remarks>
public class RuntimeImportDemo : MonoBehaviour
{
    public string assetPath = "Assets/IfcImporter/Demo/";
    public string filename = "demo_duplex.ifc";

    void Start()
    {
        DateTime starttime = System.DateTime.Now;     // for measuring optimization
        //An optional parameter to toggle various importing option. All are true by default.
        IfcSettingsOptionHolder options = new IfcSettingsOptionHolder();
        //Various parts of the building are rootObject's children.
        GameObject rootObject = IfcImporter.RuntimeImport(assetPath+filename, options);
        DateTime endtime = System.DateTime.Now;       // for measuring optimization
        Debug.Log(endtime - starttime);
    }
}
}
