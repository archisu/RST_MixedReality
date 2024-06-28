using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using static TMPro.TMP_Compatibility;

public class ComponentPlacer : MonoBehaviour
{
    public static ComponentPlacer Instance;

    //component to be placed
    [SerializeField]
    private GameObject _prefabToPlace;

    //anchor prefab and transform
    [SerializeField]
    private GameObject _RealPointsPrefab;
    [SerializeField]
    private Transform _refTransform;

    

    private bool isPlacingComp = false;
    public List<Vector3> _realPositions = new(); //store real life positions
    private List<Vector3> refPositions; //import referenced positions
    private List<GameObject> _instantiatedirlPrefabs = new List<GameObject>(); //irl prefabs list
    private GameObject _refPrefab;



    // Start is called before the first frame update
    private void Start()
    {
        isPlacingComp = false;
        Instance = this;
        PointSelector pointSelector = PointSelector.Instance;
        List<Vector3> refPositions = pointSelector._plaPositions;
        List<GameObject> refPrefabs = pointSelector._instantiatedRefPrefabs;
        GameObject _refPrefab = refPrefabs[0];
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlacingComp && _realPositions.Count > 2)
        {
            PlaceirlPrefab();
            isPlacingComp = false; // Deactivate placement after one prefab is placed
        }

        if (isPlacingComp && OVRInput.GetDown(OVRInput.Button.Two))
        {
            var go = Instantiate(_RealPointsPrefab, _refTransform.position, _refTransform.rotation); // placement anchor
            SetupRealsAsync(go.AddComponent<OVRSpatialAnchor>(), saveAnchor: true);
        }

    }

    //Method to place anchors for real life placement.
    private async void SetupRealsAsync(OVRSpatialAnchor anchor, bool saveAnchor)
    {
        while (!anchor.Created && !anchor.Localized)
        {
            await Task.Yield();
        }

        _realPositions.Add(anchor.transform.position);

    }

    private void PlaceirlPrefab()
    {

        Vector3 anchor1 = _realPositions[0];
        Vector3 anchor2 = _realPositions[1];
        Vector3 anchor3 = _realPositions[2];

        Vector3 objectPoint1 = refPositions[0];
        Vector3 objectPoint2 = refPositions[1];
        Vector3 objectPoint3 = refPositions[2];

        // Calculate the centroid of the anchors and the object points
        Vector3 anchorCentroid = (anchor1 + anchor2 + anchor3) / 3f;
        Vector3 objectCentroid = (objectPoint1 + objectPoint2 + objectPoint3) / 3f;

        // Calculate the rotation needed to align the object points with the anchor points
        Quaternion rotation = Quaternion.FromToRotation(
            (objectPoint2 - objectPoint1).normalized,
            (anchor2 - anchor1).normalized);


        // Instantiate the prefab at the new position with the calculated rotation
        GameObject prefabInstance = Instantiate(_prefabToPlace, _prefabToPlace.transform.position, _prefabToPlace.transform.rotation);
        prefabInstance.transform.position = anchorCentroid;
        prefabInstance.transform.rotation = rotation;

        // Add the instantiated prefab to the list
        _instantiatedirlPrefabs.Add(prefabInstance);

        // Clear anchor positions for the next set of anchors
        _realPositions.Clear();

    }

    public void OnClick()
    {
        isPlacingComp = true;
    }
}
