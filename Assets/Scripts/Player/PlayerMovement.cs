using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    private Vector2 startPosition;
    private float inputX;


    private void Start()
    {
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        inputX = Input.GetAxis("Horizontal");
        transform.position += inputX * Vector3.right * Time.deltaTime * moveSpeed;
    }
}