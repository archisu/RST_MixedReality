using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

public class AnchorManagementModifiable : MonoBehaviour
{
    public static AnchorManagementModifiable Instance;

    [SerializeField]
    private GameObject _saveableAnchorPrefab;

    [SerializeField]
    private GameObject _saveablePreview;

    [SerializeField]
    private Transform _saveableTransform;

    [SerializeField]
    private GameObject _prefabToPlace; // Prefab to place 

    private List<OVRSpatialAnchor> _savedAnchors = new(); //saved anchors
    private List<OVRSpatialAnchor> _anchorInstances = new(); //active instances

    private HashSet<Guid> _anchorUuids = new(); //simulated external location, like PlayerPrefs
    private Action<bool, OVRSpatialAnchor.UnboundAnchor> _onLocalized;

    private List<Vector3> _anchorPositions = new(); // Store anchor positions

    private OVRSpatialAnchor _currentAnchor; // Current anchor to be saved/unsaved

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
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger)) // save or unsave anchor
        {
            ToggleAnchor(_currentAnchor);
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

        // Check if we have 4 anchors
        if (_anchorPositions.Count == 4)
        {
            PlacePrefabBasedOnAnchors();
        }
    }

    private void PlacePrefabBasedOnAnchors()
    {
        if (_anchorPositions.Count < 4)
        {
            Debug.LogWarning("Not enough anchors to place the prefab. You need 4 anchors.");
            return;
        }

        // Calculate the center of prefab
        Vector3 anchorCenter = (_anchorPositions[0] + _anchorPositions[1] + _anchorPositions[2] + _anchorPositions[3]) / 4;

        // Calculate the vectors representing the edges of the prefab
        Vector3 edge1 = _anchorPositions[1] - _anchorPositions[0];
        Vector3 edge2 = _anchorPositions[3] - _anchorPositions[0];

        // Calculate the normal of the prefab base plane
        Vector3 normal = Vector3.Cross(edge1, edge2).normalized;

        // Calculate the forward direction of the plane
        Vector3 forward = (edge1 + edge2).normalized;

        // Calculate the rotation
        Quaternion rotation = Quaternion.LookRotation(forward, normal);

        // Instantiate the prefab at the calculated position with the calculated rotation
        GameObject placedInstance = Instantiate(_prefabToPlace, anchorCenter, rotation);

        // Clear anchor positions for the next placement
        _anchorPositions.Clear();
    }

    // save unsave anchor toggle
    private void ToggleAnchor(OVRSpatialAnchor anchor)
    {
        if (_currentAnchor != null)

        {
            Renderer anchorRenderer = anchor.GetComponent<Renderer>();

            if (_anchorUuids.Contains(_currentAnchor.Uuid))
            {
                // Forget UUID so you won't load the anchor later
                _anchorUuids.Remove(anchor.Uuid);

                // Remove from tabs on anchors in storage
                _savedAnchors.Remove(anchor);

                if (anchorRenderer != null)
                {
                    anchorRenderer.material.color = Color.red;
                }
            }
            else
            {
                // Remember UUID so you can load the anchor later
                _anchorUuids.Add(anchor.Uuid);

                // Keep tabs on anchors in storage
                _savedAnchors.Add(anchor);

                if (anchorRenderer != null)
                {
                    anchorRenderer.material.color = Color.green;
                }
            }
        }
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

        // Check if we have 2 anchors
        if (_anchorPositions.Count == 2)
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
