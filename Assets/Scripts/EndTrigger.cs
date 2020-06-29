using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Collider Player;
    public static bool finished;

    private void OnTriggerEnter(Collider Player)
    {
        finished = true;
        Debug.Log("Finished");

        if(Collect.score == 0)
        {
            Debug.Log("You Suck");
        }

        else if (Collect.score > 0 && Collect.score <= 2)
        {
            Debug.Log("Animation 1");
        }

        else if (Collect.score > 2 && Collect.score < 4)
        {
            Debug.Log("Animation 2");
        }

        else if (Collect.score == 4)
        {
            Debug.Log("Animation 3");
        }

       
    }


}
