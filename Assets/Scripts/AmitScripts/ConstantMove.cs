using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMove : MonoBehaviour
{
    public Vector3 Speed;
    public Rigidbody rb;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Speed;
        

    }


    public void AdjustSpeed(float newSpeed)
    {
        Speed = new Vector3(0, 0, newSpeed);
    }
}
