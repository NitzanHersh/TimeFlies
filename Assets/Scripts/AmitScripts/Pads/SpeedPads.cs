using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody),typeof(ConstantMove))] // if the unit who has this script doesn't have RB - unity will show an "error" message
public class SpeedPads : MonoBehaviour
{
    [Header("Speed Boost")]
    public float SpeedBoostValue = 20f;
    public float MediumSpeedMultiplier = 1.5f;
    public float HighSpeedMultiplier = 3f;
    public float SpeedDecayValue = 5f;
    public Text Text;

    private Rigidbody _rb;
    private ConstantMove move;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        move = GetComponent<ConstantMove>();
    }

    private void Update()
    {

        if (_rb.velocity.z > move.Speed.z) // player start speed
        {
            _rb.velocity -= Vector3.forward * SpeedDecayValue* Time.deltaTime;
        }


    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "SpeedPadLow")
        {
            Debug.Log("We Hit A Speed Pad Low");
            _rb.velocity += Vector3.forward * SpeedBoostValue;
        }

        if (collider.gameObject.tag == "SpeedPadMedium")
        {
            Debug.Log("We Hit A Speed Pad Medium");
            _rb.velocity += Vector3.forward * SpeedBoostValue * MediumSpeedMultiplier;
        }

        if (collider.gameObject.tag == "SpeedPadHigh")
        {
            Debug.Log("We Hit A Speed Pad High");
            _rb.velocity += Vector3.forward * SpeedBoostValue * HighSpeedMultiplier;
        }


    }
}
