using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToggleClickCounter : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    int counter;

    public void ButtonPressed()
    {
        counter++;
        numberText.text = counter + "";
    }

}
