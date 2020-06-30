using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class SlideAnimController : MonoBehaviour
{
    private Animator _animator;
    private float _previousX;


    void Start()
    {
        _animator = GetComponent<Animator>();
        _previousX = transform.position.x;
    }

    void Update()
    {
        var currentX = transform.position.x;
        if(currentX > _previousX)
        {
            _animator.SetBool("isRunningRight", true);
            _animator.SetBool("isRunningLeft", false);
        }

        else if (currentX < _previousX)
        {
            _animator.SetBool("isRunningLeft", true);
            _animator.SetBool("isRunningRight", false);
        }

        else
        {
            _animator.SetBool("isRunningRight", false);
            _animator.SetBool("isRunningLeft", false);
        }

        _previousX = currentX;
    }
}
