using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class DynamicAnchorManagement : MonoBehaviour
{
    public static DynamicAnchorManagement Instance;

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
    private GameObject _prefabToPlace; // Prefab to place based on 4 anchors

    [SerializeField]
    private Transform _definedCenter; // Center point defined for the prefab to place

    private List<OVRSpatialAnchor> _savedAnchors = new(); // Saved anchors
    private List<OVRSpatialAnchor> _anchorInstances = new(); // Active instances

    private HashSet<Guid> _anchorUuids = new(); // Simulated external location, like PlayerPrefs
    private Action<bool, OVRSpatialAnchor.UnboundAnchor> _onLocalized;

    private List<Vector3> _anchorPositions = new(); // Store anchor positions
    private GameObject _previewInstance; // Preview instance for the prefab

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
            var go = Instantiate(_saveableAnchorPrefab, _saveableTransform.position, _saveableTransform.rotation);
            SetupAnchorAsync(go.AddComponent<OVRSpatialAnchor>(), saveAnchor: true);
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger)) // Create a red capsule
        {
            // Create a red (non-savable) spatial anchor.
            var go = Instantiate(_nonSaveableAnchorPrefab, _nonSaveableTransform.position, _nonSaveableTransform.rotation);
            SetupAnchorAsync(go.AddComponent<OVRSpatialAnchor>(), saveAnchor: false);
        }
        else if (OVRInput.GetDown(OVRInput.Button.One))
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

            // Clear the list of running anchors
            _anchorInstances.Clear();
        }
        else if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            EraseAllAnchors();
        }
        else if (OVRInput.GetDown(OVRInput.Button.Two)) // y button to place prefab
        {
            PlacePrefabBasedOnAnchors();
        }

        // Real-time rotation preview
        if (_anchorPositions.Count == 1 && _previewInstance != null)
        {
            UpdatePrefabRotationPreview();
        }
    }

    private async void SetupAnchorAsync(OVRSpatialAnchor anchor, bool saveAnchor)
    {
        // Keep checking for a valid and localized anchor state
        while (!anchor.Created && !anchor.Localized)
        {
            await Task.Yield();
        }

        // Add the anchor to the list of all instances
        _anchorInstances.Add(anchor);

        // Store anchor position
        _anchorPositions.Add(anchor.transform.position);

        // You save the savable (green) anchors only
        if (saveAnchor && (await anchor.SaveAnchorAsync()).Success)
        {
            // Remember UUID so you can load the anchor later
            _anchorUuids.Add(anchor.Uuid);

            // Keep tabs on anchors in storage
            _savedAnchors.Add(anchor);
        }

        // Check if we have enough anchors to place the object
        if (_anchorPositions.Count == 1)
        {
            PlacePrefabBasedOnFirstAnchor();
        }
        else if (_anchorPositions.Count == 2)
        {
            PlacePrefabBasedOnAnchors();
        }
    }

    private void PlacePrefabBasedOnFirstAnchor()
    {
        if (_anchorPositions.Count < 1)
        {
            Debug.LogWarning("Not enough anchors to place the prefab. You need at least 1 anchor.");
            return;
        }

        // Use the first anchor to position the object
        Vector3 firstAnchorPosition = _anchorPositions[0];

        // Set the position of the prefab so that its defined center is at the first anchor
        Vector3 positionOffset = _definedCenter.position - _prefabToPlace.transform.position;
        _previewInstance = Instantiate(_prefabToPlace, firstAnchorPosition - positionOffset, Quaternion.identity);

        // Allow the instance to be rotated in real-time
        _previewInstance.transform.rotation = Quaternion.identity;
    }

    private void UpdatePrefabRotationPreview()
    {
        // Get the second controller position
        Vector3 secondControllerPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);

        // Calculate the direction from the first anchor to the second controller
        Vector3 anchorDirection = (secondControllerPosition - _anchorPositions[0]).normalized;

        // Update the rotation of the preview instance
        Quaternion rotation = Quaternion.LookRotation(anchorDirection, Vector3.up);
        _previewInstance.transform.rotation = rotation;
    }

    private void PlacePrefabBasedOnAnchors()
    {
        if (_anchorPositions.Count < 2)
        {
            Debug.LogWarning("Not enough anchors to place the prefab. You need 2 anchors.");
            return;
        }

        // Get the anchor positions
        Vector3 anchor1 = _anchorPositions[0];
        Vector3 anchor2 = _anchorPositions[1];

        // Calculate the direction vector
        Vector3 anchorDirection = (anchor2 - anchor1).normalized;

        // Calculate the new position and rotation for the prefab
        Vector3 positionOffset = _definedCenter.position - _prefabToPlace.transform.position;
        Vector3 newPosition = anchor1 - positionOffset;
        Quaternion rotation = Quaternion.LookRotation(anchorDirection, Vector3.up);

        // Place the final prefab at the new position with the calculated rotation
        if (_previewInstance != null)
        {
            _previewInstance.transform.position = newPosition;
            _previewInstance.transform.rotation = rotation;
        }
        else
        {
            _previewInstance = Instantiate(_prefabToPlace, newPosition, rotation);
        }

        // Fix the instance to the second anchor as well
        _previewInstance.transform.position = anchor2 - positionOffset;
        _previewInstance.transform.rotation = rotation;

        // Clear anchor positions for the next set of anchors
        _anchorPositions.Clear();
        _previewInstance = null;
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

        // Check if we have enough anchors to place the object
        if (_anchorPositions.Count == 1)
        {
            PlacePrefabBasedOnFirstAnchor();
        }
        else if (_anchorPositions.Count == 2)
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
            _anchorPositions.Clear(); // Clear anchor positions as well

            Debug.Log($"Anchors erased.");
        }
        else
        {
            Debug.LogError($"Anchors NOT erased {result.Status}");
        }
    }
}

