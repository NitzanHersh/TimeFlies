using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;


    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score " + score.ToString();

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Collectable"))
        {
            score++;
            collider.gameObject.SetActive(false);

        }
    }

}
