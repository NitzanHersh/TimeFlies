using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BordersToggle : MonoBehaviour
{

    public GameObject[] Borders;

  
    void Start()
    {
        Borders = GameObject.FindGameObjectsWithTag("Border");
    }

    public void ShowBorders(bool value)
    {
        if (value == true)
        {
            foreach(GameObject border in Borders)
            {
                border.SetActive(true);
            }
        }

        if (value == false)
        {
            foreach (GameObject border in Borders)
            {
                border.SetActive(false);
            }
        }
    }
}
