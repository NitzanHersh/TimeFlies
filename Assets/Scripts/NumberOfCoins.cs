using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberOfCoins : MonoBehaviour
{
    public GameObject[] Coins;
    public GameObject coinPrefab;

    void Start()
    {
        Coins = GameObject.FindGameObjectsWithTag("Collectable");
    }

    public void NumOfCoins(string newNumber)
    {
     
            
    }
}
