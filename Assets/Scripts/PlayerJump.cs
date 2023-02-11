using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private int maxJumps = 1;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform rayOriginTransform;
    [SerializeField] private float rayLength = 0.05f;
    private bool hasParent;
    private bool isGrounded;
    private bool wasLastGrounded;
    private int jumpCount = 0;

    private void FixedUpdate()
    {
        CheckGround();
    }

    private void Update()
    {
        Jump();
    }
    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && jumpCount < maxJumps)
        {
            jumpCount+= 1;
            Vector3 velocity = rb.velocity;
            velocity.y = 0f;
            rb.velocity = velocity;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void CheckGround()
    {
        RaycastHit2D raycastHit = Physics2D.Raycast(
            rayOriginTransform.position,
            Vector2.down, 
            rayLength);

        isGrounded = raycastHit.collider != null;

        if (isGrounded && !wasLastGrounded)
        {
            jumpCount = 0;
            
            wasLastGrounded = true;
        }

        if (isGrounded)
        {
            
            hasParent = raycastHit.collider.CompareTag("WhitePlane");
            if (hasParent)
            {
                transform.SetParent(raycastHit.collider.transform);
            }

        }
        else if(hasParent)
        {
            transform.SetParent(null);
            hasParent = false;
        }

        if (!isGrounded && wasLastGrounded)
        {
            wasLastGrounded = false;
        }

    }


}
