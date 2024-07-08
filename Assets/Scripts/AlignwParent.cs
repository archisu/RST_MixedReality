using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignwParent : MonoBehaviour
{
    private Transform parentTransform;

    public Vector3 offset = new Vector3(0, 0.1f, 0);

    public float scaleFactor = 1.0f;

    void Start()
    {
        if (transform.parent != null)
        {
            parentTransform = transform.parent;
        }

        else 
        {
            Debug.LogError("object does not have a parent");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (parentTransform != null)
        {

            transform.localScale = transform.localScale * scaleFactor;

            Vector3 parentPosition = parentTransform.position;
            transform.position = parentPosition + offset;

            
        }
    }
}
