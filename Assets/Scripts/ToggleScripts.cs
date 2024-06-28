using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScripts : MonoBehaviour
{
    // Reference to the GameObject to be toggled
    public GameObject target;

    // Reference to the script to be toggled
    public MonoBehaviour targetScript;

    // Method to toggle the GameObject's active state
    public void ToggleActiveState()
    {
        if (target != null && targetScript != null)
        {
            bool isActive = target.activeInHierarchy;

            // Toggle the GameObject's active state
            target.SetActive(!isActive);

            // Toggle the script's enabled state
            targetScript.enabled = !isActive;
        }
        else
        {
            Debug.LogWarning("Target GameObject or target script is not assigned.");
        }
    }
}
