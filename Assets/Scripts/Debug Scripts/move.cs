using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject Player;
    public BoxCollider PlayerCollider;
    public float forwardForce = 700f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(EndTrigger.finished == true)
        {
            rb.isKinematic = true;
        }

    }

    public void AdjustSpeed(float newForwardForce)
    {
        forwardForce = newForwardForce;
    }

  }
