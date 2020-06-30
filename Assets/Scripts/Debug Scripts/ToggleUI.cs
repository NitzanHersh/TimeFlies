using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleUI : MonoBehaviour
{
    public GameObject UICanvas;
    public GameObject UIToggle;
    public void ShowUI(bool newBool)
    {
        if(newBool == true)
        {
            
            UICanvas.SetActive(true);
            UIToggle.SetActive(false);
        }
    }

    public void HideUI(bool newBool)
    {
        if (newBool == true)
        {
            UICanvas.SetActive(false);
            UIToggle.SetActive(true);
        }
    }
}
