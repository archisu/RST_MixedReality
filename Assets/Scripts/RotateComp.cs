using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateComp : MonoBehaviour
{
    public float rotationSpeed = 30f;

    private void Update()
    {
        // rotate the object around z axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

    }
}
