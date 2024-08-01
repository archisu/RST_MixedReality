using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFC_Mover : MonoBehaviour
{
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // Get the joystick axes input from the left and right controllers
        float moveHorizontal = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x;
        float moveVertical = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y;
        float moveDepth = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).y;

        // Create a Vector3 based on the input
        Vector3 movement = new Vector3(moveHorizontal, moveDepth, moveVertical);

        // Apply the movement to the object's position
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
