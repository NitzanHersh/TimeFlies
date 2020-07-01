using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Open_Scene_Manager : MonoBehaviour
{

    void Update()
    {
     if(transform.position.y > 5.5f)
        {
            SceneManager.LoadScene("Level_1_Graphics");
        }
    }
}
