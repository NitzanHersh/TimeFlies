using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerName : MonoBehaviour
{
    public GameObject welcomeText;
    public Text welcomeTextText;
    public GameObject nameObject;

   public void text_Change(string name)
    {
        nameObject.SetActive(false);
        welcomeText.SetActive(true);
        welcomeTextText.text = "Hello " + name + ", Let's Play!";
        Invoke("hideText", 1.5f);
    }

    public void hideText()
    {
        welcomeText.SetActive(false);
    }
}

