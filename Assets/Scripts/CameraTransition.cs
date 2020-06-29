using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    public Transform[] Positions;
    public float Duration;
    public Transform player;

    private int _index = 0;
    private bool _transitioning = false;



    

    private IEnumerator ChangeCamera(int newIndex)
    {
        var startTime = Time.time;
        var factor = (Time.time - startTime) / Duration;
        var startPosition = transform.position;
  

        _transitioning = true;

        while(factor < 1)
        {
            transform.position = Vector3.Lerp(startPosition, Positions[newIndex].position, factor);
            yield return null;
            factor = (Time.time - startTime) / Duration;
        }

        _transitioning = false;

        transform.position = Positions[newIndex].position;

    }


    [ContextMenu("ToggleCamera")]
    public void ToggleCamera()
    {

        _index = (_index + 1) % Positions.Length;

        StartCoroutine(ChangeCamera(_index));

    }

    public void ToggleCamera(int index)
    {

        if (index == 0)
        {
            StartCoroutine(ChangeCamera(index));

        }
        if (index == 1)
        {
            StartCoroutine(ChangeCamera(index));
        }
        if (index == 2)
        {
            StartCoroutine(ChangeCamera(index));
        }
        if (index == 3)
        {
            StartCoroutine(ChangeCamera(index));
        }

        _index = index;
    }

    private void Update()
    {
        transform.position = Positions[_index].position;
    }
}
