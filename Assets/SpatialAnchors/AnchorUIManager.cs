using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

public class AnchorUIManager : MonoBehaviour
{
    public static AnchorUIManager Instance;

    [SerializeField]
    private GameObject _saveableAnchorPrefab;

    [SerializeField]
    private GameObject _saveablePreview;

    [SerializeField]
    private Transform _saveableTransform;

    [SerializeField]
    private GameObject _nonSaveableAnchorPrefab;

    [SerializeField]
    private GameObject _nonSaveablePreview;

    [SerializeField]
    private Transform _nonSaveableTransform;

    [SerializeField]
    private GameObject _prefabToPlace; // Prefab to place based on 3 anchors

    [SerializeField]
    private Transform _objectPoint1; // First point on the object
    [SerializeField]
    private Transform _objectPoint2; // Second point on the object
    [SerializeField]
    private Transform _objectPoint3; // Third point on the object

    private List<OVRSpatialAnchor> _savedAnchors = new(); //saved anchors
    private List<OVRSpatialAnchor> _anchorInstances = new(); //active instances
    private List<GameObject> _instantiatedAnchorPrefabs = new List<GameObject>(); //anchor prefabs

    private HashSet<Guid> _anchorUuids = new(); //simulated external location, like PlayerPrefs
    private Action<bool, OVRSpatialAnchor.UnboundAnchor> _onLocalized;

    private List<Vector3> _anchorPositions = new(); // Store anchor positions

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            _onLocalized = OnLocalized;
        }
        else
        {
            Destroy(this);
        }
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)) // Create a green capsule
        {
            // Create a green (savable) spatial anchor
            var go = Instantiate(_saveableAnchorPrefab, _saveableTransform.position, _saveableTransform.rotation); // Anchor A
            SetupAnchorAsync(go.AddComponent<OVRSpatialAnchor>(), saveAnchor: true);
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger)) // Create a red capsule
        {
            // Create a red (non-savable) spatial anchor.
            var go = Instantiate(_nonSaveableAnchorPrefab, _nonSaveableTransform.position, _nonSaveableTransform.rotation); // Anchor b
            SetupAnchorAsync(go.AddComponent<OVRSpatialAnchor>(), saveAnchor: false);
        }
        else if (OVRInput.GetDown(OVRInput.Button.One)) // a button
        {
            LoadAllAnchors();
        }
        else if (OVRInput.GetDown(OVRInput.Button.Three)) // x button
        {
            // Destroy all anchors from the scene, but don't erase them from storage
            foreach (var anchor in _anchorInstances)
            {
                Destroy(anchor.gameObject);
            }

            // Destroy all instantiated anchor prefabs
            foreach (GameObject prefabInstance in _instantiatedAnchorPrefabs)
            {
                Destroy(prefabInstance);
            }
            _instantiatedAnchorPrefabs.Clear();

            // Clear the list of running anchors
            _anchorInstances.Clear();
        }
        else if (OVRInput.GetDown(OVRInput.Button.Four)) // y button
        {
            EraseAllAnchors();
        }
    }

    private async void SetupAnchorAsync(OVRSpatialAnchor anchor, bool saveAnchor)
    {
        while (!anchor.Created && !anchor.Localized)
        {
            await Task.Yield();
        }

        _anchorInstances.Add(anchor);
        _anchorPositions.Add(anchor.transform.position);

        if (saveAnchor && (await anchor.SaveAnchorAsync()).Success)
        {
            _anchorUuids.Add(anchor.Uuid);
            _savedAnchors.Add(anchor);
        }

        // Check if we have 3 anchors
        if (_anchorPositions.Count == 3)
        {
            PlacePrefabBasedOnAnchors();
        }
    }

    private void PlacePrefabBasedOnAnchors()
    {
        if (_anchorPositions.Count < 3)
        {
            Debug.LogWarning("Not enough anchors to place the prefab. You need 3 anchors.");
            return;
        }

        Vector3 anchor1 = _anchorPositions[0];
        Vector3 anchor2 = _anchorPositions[1];
        Vector3 anchor3 = _anchorPositions[2];

        Vector3 objectPoint1 = _objectPoint1.position;
        Vector3 objectPoint2 = _objectPoint2.position;
        Vector3 objectPoint3 = _objectPoint3.position;

        // Calculate the centroid of the anchors and the object points
        Vector3 anchorCentroid = (anchor1 + anchor2 + anchor3) / 3f;
        Vector3 objectCentroid = (objectPoint1 + objectPoint2 + objectPoint3) / 3f;

        // Calculate the rotation needed to align the object points with the anchor points
        Quaternion rotation = Quaternion.FromToRotation(
            (objectPoint2 - objectPoint1).normalized,
            (anchor2 - anchor1).normalized
        );

        // Instantiate the prefab at the new position with the calculated rotation
        GameObject prefabInstance = Instantiate(_prefabToPlace, _prefabToPlace.transform.position, _prefabToPlace.transform.rotation);
        prefabInstance.transform.position = anchorCentroid;
        prefabInstance.transform.rotation = rotation;

        // Add the instantiated prefab to the list
        _instantiatedAnchorPrefabs.Add(prefabInstance);

        // Clear anchor positions for the next set of anchors
        _anchorPositions.Clear();
    }

    public async void LoadAllAnchors()
    {
        // Load and localize
        var unboundAnchors = new List<OVRSpatialAnchor.UnboundAnchor>();
        var result = await OVRSpatialAnchor.LoadUnboundAnchorsAsync(_anchorUuids, unboundAnchors);

        if (result.Success)
        {
            foreach (var anchor in unboundAnchors)
            {
                anchor.LocalizeAsync().ContinueWith(_onLocalized, anchor);
            }
        }
        else
        {
            Debug.LogError($"Load anchors failed with {result.Status}.");
        }
    }

    private void OnLocalized(bool success, OVRSpatialAnchor.UnboundAnchor unboundAnchor)
    {
        var pose = unboundAnchor.Pose;
        var go = Instantiate(_saveableAnchorPrefab, pose.position, pose.rotation);
        var anchor = go.AddComponent<OVRSpatialAnchor>();

        unboundAnchor.BindTo(anchor);

        // Add the anchor to the running total
        _anchorInstances.Add(anchor);

        // Store anchor position
        _anchorPositions.Add(anchor.transform.position);

        // Check if we have 3 anchors
        if (_anchorPositions.Count == 3)
        {
            PlacePrefabBasedOnAnchors();
        }
    }

    public async void EraseAllAnchors()
    {
        var result = await OVRSpatialAnchor.EraseAnchorsAsync(_savedAnchors, uuids: null);
        if (result.Success)
        {
            // Erase our reference lists
            _savedAnchors.Clear();
            _anchorUuids.Clear();
            _anchorPositions.Clear();

            Debug.Log($"Anchors erased.");
        }
        else
        {
            Debug.LogError($"Anchors NOT erased {result.Status}");
        }
    }

    // Enable and disable fucntions for the button.

    public void EnableDisable()
    {
        if (this.enabled == true) 
        {
            this.enabled = false;
        }
        else
        {
            this.enabled = true;
        }
        
    }
}
