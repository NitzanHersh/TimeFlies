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

        if(Collect.CollectedTimeFlies == 0)
        {
            Debug.Log("You Suck");
        }

        else if (Collect.CollectedTimeFlies > 0 && Collect.CollectedTimeFlies <= 2)
        {
            Debug.Log("Animation 1");
        }

        else if (Collect.CollectedTimeFlies > 2 && Collect.CollectedTimeFlies < 4)
        {
            Debug.Log("Animation 2");
        }

        else if (Collect.CollectedTimeFlies == 4)
        {
            Debug.Log("Animation 3");
        }

       
    }


}
