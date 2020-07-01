﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleUI : MonoBehaviour
{
    public GameObject UICanvas;
    public GameObject UIToggle;

    public void ShowUI(bool newBool)
    {
        if(newBool == true)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().isKinematic = true;
            Debug.Log("FoundPlayer" + GameObject.FindGameObjectWithTag("Player").transform.position);
            UICanvas.SetActive(true);
            UIToggle.SetActive(false);
        }
    }

    public void HideUI(bool newBool)
    {
        if (newBool == true)
        {
            Invoke("PlayerGo", 0.5f);
            UICanvas.SetActive(false);
            UIToggle.SetActive(true);
        }
    }

    public void PlayerGo()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().isKinematic = false;
    }
}
