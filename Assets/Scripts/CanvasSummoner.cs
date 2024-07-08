using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSummoner : MonoBehaviour
{
    public Canvas flatCanvas;

    void Start()
    {
        flatCanvas.gameObject.SetActive(false);
    }

    public void OnClick()
    {
        flatCanvas.gameObject.SetActive(true);
    }
}
