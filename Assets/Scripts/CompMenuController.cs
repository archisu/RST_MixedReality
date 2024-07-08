using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompMenuController : MonoBehaviour
{
    public Canvas flatCanvas;
    public string selectedComp;

    public void OnCompSelected(Button button)
    {
        selectedComp = button.GetComponentInChildren<Text>().text;

        Debug.Log("Selected Component:" + selectedComp);

        //close the canvas 
        flatCanvas.gameObject.SetActive(false);
    }
}

