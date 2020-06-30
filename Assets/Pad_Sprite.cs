using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pad_Sprite : MonoBehaviour
{
    public Image jumpArrow;

    // Start is called before the first frame update
    void Start()
    {
        jumpArrow.transform.position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
