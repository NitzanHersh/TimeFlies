using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleToggle : MonoBehaviour
{

    public GameObject[] Obstacles;

  
    void Start()
    {
        Obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
    }

    public void ShowObstacles(bool value)
    {
        if (value == true)
        {
            foreach(GameObject obs in Obstacles)
            {
                obs.SetActive(true);
            }
        }

        if (value == false)
        {
            foreach (GameObject obs in Obstacles)
            {
                obs.SetActive(false);
            }
        }
    }
}
