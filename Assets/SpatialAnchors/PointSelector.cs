using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using static TMPro.TMP_Compatibility;

public class PointSelector : MonoBehaviour
{
    public static PointSelector Instance;

    private GameObject _selectedComp;

    // take the output from the comp menu controller here
    // 

    [SerializeField]
    private GameObject _refAnchorPrefab;

    [SerializeField]
    private GameObject _refPreview;

    [SerializeField]
    private Transform _refTransform;

    [SerializeField]
    private GameObject _PlPointPrefab;

    [SerializeField]
    private GameObject _prefabToPlace;

    [SerializeField]
    private Transform _prefabBasePoint;

    private List<OVRSpatialAnchor> _refAnchors = new();
    private List<OVRSpatialAnchor> _refAnchorInstances = new(); //active instances
    private HashSet<Guid> _anchorUuids = new(); //simulated external location, like PlayerPrefs
    private List<Vector3> _anchorPositions = new(); // Store anchor positions

    public GameObject _referencedPfab;  //reference prefabs
    
    public List<Vector3> _plaPositions = new List<Vector3>(); //store placement positions

    private bool isPlacingPrefab = false;
    private bool isPlacingPt = false;

    // Start is called before the first frame update
    void Start()
    {
        isPlacingPrefab = false;
        Instance = this; 
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlacingPrefab && OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && _anchorPositions.Count < 1) // Create a green capsule
        {
            // Create a reference anchor
            var go = Instantiate(_refAnchorPrefab, _refTransform.position, _refTransform.rotation); // Anchor A
            SetupAnchorAsync(go.AddComponent<OVRSpatialAnchor>(), saveAnchor: true);
        }

        else if (OVRInput.GetDown(OVRInput.Button.Three)) // x button
        {
            // Destroy all anchors from the scene, but don't erase them from storage
            foreach (var anchor in _refAnchors)
            {
                Destroy(anchor.gameObject);
            }

            // Destroy all instantiated anchor prefabs
            Destroy(_referencedPfab);

            // Clear the list of running anchors
            _refAnchors.Clear();
        }

        if (isPlacingPrefab && _anchorPositions.Count == 1)
        {
            PlaceRefPrefab();
            isPlacingPrefab = false; // Deactivate placement after one prefab is placed
            isPlacingPt = true;
        }

        if (isPlacingPt && _plaPositions.Count > 2)
        {
            isPlacingPt = false;
        }

        if (isPlacingPt && OVRInput.GetDown(OVRInput.Button.One)) // A button
        {
            var go = Instantiate(_PlPointPrefab, _refTransform.position, _refTransform.rotation); // placement anchor
            SetupPlaAsync(go.AddComponent<OVRSpatialAnchor>(), saveAnchor: true);

        }
    }

    private async void SetupAnchorAsync(OVRSpatialAnchor anchor, bool saveAnchor)
    {
        while (!anchor.Created && !anchor.Localized)
        {
            await Task.Yield();
        }

        _refAnchorInstances.Add(anchor);
        _anchorPositions.Add(anchor.transform.position);

        if (saveAnchor && (await anchor.SaveAnchorAsync()).Success)
        {
            _anchorUuids.Add(anchor.Uuid);
            _refAnchors.Add(anchor);
        }

    }

    private async void SetupPlaAsync(OVRSpatialAnchor anchor, bool saveAnchor)
    {
        while (!anchor.Created && !anchor.Localized)
        {
            await Task.Yield();
        }

        _plaPositions.Add(anchor.transform.position);

    }
    private void PlaceRefPrefab()
    {
        if (_anchorPositions.Count < 1)
        {
            Debug.LogWarning("Not enough anchors to place the prefab. You need 1 anchor.");
            return;
        }

        Vector3 anchor1 = _anchorPositions[0];

        Vector3 objectPoint1 = _prefabBasePoint.position;

        Vector3 offset = anchor1 - objectPoint1;

        // add an if causal in here
        // if selectedComp is sel1, spawn this prefab.. if 2 so on
        // store this in a variable and send it to the comp placer
        // points will be placed on the comp, and then on the real world so the comp will be spawned


        // Instantiate the prefab at the new position with the calculated rotation
        GameObject prefabInstance = Instantiate(_prefabToPlace, _prefabToPlace.transform.position + offset, _prefabToPlace.transform.rotation);

        // Add the instantiated prefab to the list
        _referencedPfab = prefabInstance.GetComponent<GameObject>();

        // Clear anchor positions for the next set of anchors
        _anchorPositions.Clear();

    }

    public void OnClick()
    {
        isPlacingPrefab = true;
    }
  }

