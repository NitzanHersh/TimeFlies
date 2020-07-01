using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRewind : MonoBehaviour {

	bool isRewinding = false;

	public float recordTime;
    public float HowHardToShake;
    public int NumberFliesNeededForRewind = 2;
    public Collect collect;
    //public Collider col;

    private Collider[] _colliders;

    List<PointInTime> pointsInTime;

	Rigidbody rb;

    SlideController slide;

    Vector3 accelerationDir;

	// Use this for initialization
	void Start () {
		pointsInTime = new List<PointInTime>();
		rb = GetComponent<Rigidbody>();
        slide = GetComponent<SlideController>();
        _colliders = GetComponentsInChildren<Collider>();
  
	}
	
	// Update is called once per frame
	void Update ()
    {
        accelerationDir = Input.acceleration;
        // ------ PC USE ------                  ------ PHONE USE ------   
        if ((Input.GetKeyDown(KeyCode.Return) || (accelerationDir.sqrMagnitude >= HowHardToShake)) && collect.IsItEnoughFlies == true) // Add Here - && NumberOfFlies >=2 
			StartRewind();
        if (Input.GetKeyUp(KeyCode.Return))
			StopRewind();

          accelerationDir = Input.acceleration;


        /*
        if (accelerationDir.sqrMagnitude >= HowHardToShake)
        {
            StartRewind();
        }
        else
        { 
            StopRewind();
        }
        */
    }

	void FixedUpdate ()
	{
		if (isRewinding)
			Rewind();

		else
			Record();
	}

	void Rewind ()
	{
		if (pointsInTime.Count > 0)
		{
			PointInTime pointInTime = pointsInTime[0];
            transform.position = pointInTime.position;
			transform.rotation = pointInTime.rotation;
            rb.velocity = pointInTime.velocity;

			pointsInTime.RemoveAt(0);
		} else
		{
			StopRewind();
		}
		
	}

	void Record ()
	{
		if (pointsInTime.Count > Mathf.Round(recordTime / Time.fixedDeltaTime))
		{
			pointsInTime.RemoveAt(pointsInTime.Count - 1);
		}

        pointsInTime.Insert(0, new PointInTime(transform.position, transform.rotation, rb.velocity));
	}

	public void StartRewind ()
	{
		isRewinding = true;
        //col.enabled = false;
        foreach (var collider in _colliders)
        {
            collider.enabled = false;
        }

        slide.enabled = false;
        collect.CurrentFliesAmout = collect.CurrentFliesAmout - NumberFliesNeededForRewind;
        if (collect.CurrentFliesAmout <NumberFliesNeededForRewind)
        {
            collect.IsItEnoughFlies = false;
        }

    }

	public void StopRewind ()
	{
        isRewinding = false;
        //col.enabled = true;
        foreach (var collider in _colliders)
        {
            collider.enabled = true;
        }
        slide.enabled = true;
    }
}
