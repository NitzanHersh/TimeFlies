using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneManagment : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            QuitGame();
        }
    }

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

    //Load Level Without Graphics

    public void LoadLevel_1()
    {

        SceneManager.LoadScene("Level_1");

    }

    public void LoadLevel_2()
    {

        SceneManager.LoadScene("Level_2");

    }

    public void LoadLevel_3()
    {

        SceneManager.LoadScene("Level_3");

    }

    void QuitGame()
    {
        Application.Quit();
    }
}
