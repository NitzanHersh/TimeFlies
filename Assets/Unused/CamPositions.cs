using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPositions : MonoBehaviour
{
    public Camera main;
    public Camera front;
    public Camera side;
    public Camera top;

    public GameObject[] obstacles;


    void Start()
    {
        for(int i = 0; i < obstacles.Length; i++)
        {
            if (obstacles[i].CompareTag("obstacle")) { }
        }
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void HandleDropdownInput(int value)
    {
        if (value == 0)
        {
            main.enabled = true;
            front.enabled = false;
            side.enabled = false;
            top.enabled = false;
            Debug.Log("campos1");
        }
        if (value == 1)
        {
            main.enabled = false;
            front.enabled = true;
            side.enabled = false;
            top.enabled = false;
            Debug.Log("campos2");
        }
        if (value == 2)
        {
            main.enabled = false;
            front.enabled = false;
            side.enabled = true;
            top.enabled = false;
            Debug.Log("campos3");
        }
        if (value == 3)
        {
            main.enabled = false;
            front.enabled = false;
            side.enabled = false;
            top.enabled = true;
            Debug.Log("campos4");
        }
    }

  public void Toggle_Changed(bool newValue)
    {
       
    }
}

