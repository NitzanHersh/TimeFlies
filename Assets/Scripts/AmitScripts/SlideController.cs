using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideController : MonoBehaviour
{

    public float Speed;
    public float Limit = 4.5f;

    private Vector2? _previousMousePosition = null; 

    private void Update()

    {
        if (Input.GetMouseButton(0))  

        {
            Vector2 currentMousePosition = Input.mousePosition; 

            if (_previousMousePosition.HasValue)
            {
                var delta = (_previousMousePosition.Value - currentMousePosition).x;
                transform.Translate(Vector3.left * delta * Speed * Time.deltaTime, Space.Self);

            }

            _previousMousePosition = currentMousePosition;
        }

        else _previousMousePosition = null;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -Limit, Limit), transform.position.y, transform.position.z);
    }
}


