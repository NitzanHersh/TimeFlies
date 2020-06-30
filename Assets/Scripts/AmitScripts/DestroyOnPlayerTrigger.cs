﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnPlayerTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("BackwardsPusher Destroyed");
        }
    }

}