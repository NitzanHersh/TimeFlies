using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Scene_Manager : MonoBehaviour
{

    void Update()
    {
     if(transform.position.y > 5.5f)
        {
            Debug.Log("change scene");
        }
    }
}
