using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMove : MonoBehaviour
{
    public Vector3 Speed; // C Sharp convention to use a capital 'S' since this variable is public
    public Rigidbody rb;
    //public float Limit = 4.5f;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(Speed);
        rb.velocity = Speed;
        

    }

    private void Update()
    {
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, -Limit, Limit), transform.position.y, transform.position.z);
    }

    //Line For Debug Menu
    public void AdjustSpeed(float newSpeed)
    {
        Speed = new Vector3(0, 0, newSpeed);
    }
}
