using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleUI : MonoBehaviour
{
    public GameObject ShowMenu;
    public GameObject HideMenu;
    public GameObject CamPosMenu;

    public void ShowUI(bool newBool)
    {
        if(newBool == true)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().isKinematic = true;
            Debug.Log("FoundPlayer" + GameObject.FindGameObjectWithTag("Player").transform.position);
            CamPosMenu.SetActive(true);
            HideMenu.SetActive(true);
            ShowMenu.SetActive(false);
        }
    }

    public void HideUI(bool newBool)
    {
        if (newBool == true)
        {
            Invoke("PlayerGo", 0.5f);
            ShowMenu.SetActive(true);
            CamPosMenu.SetActive(false);
            HideMenu.SetActive(false);

        }
    }

    public void PlayerGo()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().isKinematic = false;
    }
}
