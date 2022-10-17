using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 20;
    [SerializeField] private Rigidbody2D _rigidbody;

    private bool _isJumping = false;
    [Range(-1, 1)]
    private float _horizontalInputValue;
    
    private void Update()
    {
        _horizontalInputValue = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        if (_horizontalInputValue > 0.1f || _horizontalInputValue < 0.1f)
        {
            _rigidbody.AddForce(new Vector2(_horizontalInputValue * _speed,0));
        }
    }
}
