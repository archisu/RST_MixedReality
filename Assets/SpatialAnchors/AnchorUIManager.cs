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

    private List<OVRSpatialAnchor> _savedAnchors = new(); //saved anchors
    private List<OVRSpatialAnchor> _anchorInstances = new(); //active instances

    private HashSet<Guid> _anchorUuids = new(); //simulated external location, like PlayerPrefs
    private Action<bool, OVRSpatialAnchor.UnboundAnchor> _onLocalized;

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

        // You save the savable (green) anchors only
        if (saveAnchor && (await anchor.SaveAnchorAsync()).Success)
        {
            // Remember UUID so you can load the anchor later
            _anchorUuids.Add(anchor.Uuid);

            // Keep tabs on anchors in storage
            _savedAnchors.Add(anchor);
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
    }

    public async void EraseAllAnchors()
    {
        var result = await OVRSpatialAnchor.EraseAnchorsAsync(_savedAnchors, uuids: null);
        if (result.Success)
        {
            // Erase our reference lists
            _savedAnchors.Clear();
            _anchorUuids.Clear();

            Debug.Log($"Anchors erased.");
        }
        else
        {
            Debug.LogError($"Anchors NOT erased {result.Status}");
        }
    }

}

