using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public static int CollectedTimeFlies = 0;
    public int CurrentFliesAmout;
    public Text NumberOfTImeFliesCollected;
    public bool IsItEnoughFlies = false;


    // Update is called once per frame
    void Update()
    {
        NumberOfTImeFliesCollected.text = "You Collected " + CollectedTimeFlies.ToString() + " Time Flies!";

   
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "TimeFly")
        {
            CollectedTimeFlies++;
            CurrentFliesAmout++;
            collider.gameObject.SetActive(false);
            Debug.Log("Collected Fly");

            if (CurrentFliesAmout >= 2)
            {
                IsItEnoughFlies = true;
            }
         
        }

    }


    //This line is for debug menu

    public void AdjustNumOfFlies(int newNum)
    {
        CurrentFliesAmout = newNum;
        IsItEnoughFlies = true;
    }
}
