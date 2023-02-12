using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 normalized;
    [SerializeField] float walkSpeed = 3f;
    [SerializeField] float runSpeed = 6f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        Vector3 input = new Vector3
        {
            x = Input.GetAxis("Horizontal"),
            y = 0f,
            z = 0f,
        };
        input.Normalize();

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += input * Time.deltaTime * runSpeed;
        }
        else
        {
            transform.position += input * Time.deltaTime * walkSpeed;
        }
        
    }
}