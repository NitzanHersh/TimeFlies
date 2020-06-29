using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform Player;
    private Vector3 _offset;

    void Start()
    {
        _offset = Player.transform.position - transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.position = Player.transform.position - _offset;


    }
}
