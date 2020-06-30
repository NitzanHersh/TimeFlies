﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject _player;
    private GameObject _playerDeathCanvas;


    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _playerDeathCanvas = GameObject.FindGameObjectWithTag("PlayerDeathCanvas");
        _playerDeathCanvas.SetActive(false);
        _player.GetComponent<Rigidbody>().isKinematic = false;
    }

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
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Level Complete");

            LevelComplete();    
        }
    }

    public void LevelComplete()
    {
        SceneManager.LoadScene("LevelComplete");
    }



    void PlayerDeath()
    {
        //SceneManager.LoadScene("PlayerDeath");
        _playerDeathCanvas.SetActive(true);
        _player.GetComponent<Rigidbody>().isKinematic = true;
    }



 


    void QuitGame ()
    {
        Application.Quit();
    }




    
}