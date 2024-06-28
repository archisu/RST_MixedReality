using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnchorsToggle : MonoBehaviour
{
    public AnchorUIManager anchorUIManager; // Reference to the AnchorUIManager script
    public Toggle toggle; // Reference to the Toggle component

    private void Start()
    {
        // Ensure the Toggle component is assigned
        if (toggle != null)
        {
            // Add a listener to the toggle to call ToggleAnchorUIManagerScript when its value changes
            toggle.onValueChanged.AddListener(ToggleAnchorUIManagerScript);
        }
        else
        {
            Debug.LogWarning("Toggle reference is not assigned.");
        }
    }

    public void ToggleAnchorUIManagerScript(bool isOn)
    {
        // Check if the anchorUIManager is not null
        if (anchorUIManager != null)
        {
            // Set the enabled state of the AnchorUIManager script based on the toggle's value
            anchorUIManager.enabled = isOn;
        }
        else
        {
            Debug.LogWarning("AnchorUIManager reference is not assigned.");
        }
    }
}
