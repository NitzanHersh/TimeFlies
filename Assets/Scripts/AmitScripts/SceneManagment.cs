using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneManagment : MonoBehaviour
{

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("LOADING Main Menu");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");

    }

    // Load Levels With Graphics
    public void LoadLevel_1_Graphics()
    {
        SceneManager.LoadScene("Level_1_Graphics");

    }

    public void LoadLevel_2_Graphics()
    {
        SceneManager.LoadScene("Level_2_Graphics");

    }

    public void LoadLevel_3_Graphics()
    {
        SceneManager.LoadScene("Level_3_Graphics");

    }
}
