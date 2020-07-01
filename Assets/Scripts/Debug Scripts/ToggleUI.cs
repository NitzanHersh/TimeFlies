using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleUI : MonoBehaviour
{
    public GameObject ShowMenu;
    public GameObject HideMenu;
    public GameObject CamPosMenu;
    public GameObject Player;

    public void ShowUI()
    {
        //GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().isKinematic = true;
        Player.GetComponent<Rigidbody>().isKinematic = true;
        Debug.Log("FoundPlayer" + Player.transform.position);
        CamPosMenu.SetActive(true);
        HideMenu.SetActive(true);
        ShowMenu.SetActive(false);
    }


    public void HideUI()
    {

        Invoke("PlayerGo", 0.5f);
        ShowMenu.SetActive(true);
        CamPosMenu.SetActive(false);
        HideMenu.SetActive(false);
    }

    public void PlayerGo()
    {
        //GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().isKinematic = false;
        Player.GetComponent<Rigidbody>().isKinematic = false;
    }
}
