using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");   
    }

    // Update is called once per frame
    void Update()
    {
        if (_player.transform.position.y < -35)
        {
            PlayerDeath();
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            RestartLevel();
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void PlayerDeath()
    {
        //Load a Scene with 2 buttons: 1) Play again! 2) Back to Main Menu
    }

    void PlayerWin()
    {
        //Load Credits
        //Add 2 buttons: 1. Quit 2. Main Menu
    }

    void FinishLevel()
    {
        // Load a Scene with 3 buttons: 1) Play again! 2) Next Level 3)Back to Main Menu
    }
}
