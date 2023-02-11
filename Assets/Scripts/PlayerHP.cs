using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerHP : MonoBehaviour
{
    [SerializeField] private int maxHP = 3;
    private int currentHP;
    [SerializeField] private Rigidbody2D rb;
    private Vector3 startPosition;

    private int CurrentHP
    {
        get
        {
            return currentHP;
        }
        set
        {
            currentHP = value;
            if (currentHP <= 0)
            {
                //uiController.SetEndGame(false);
                Debug.Log("Lose");
            }
        }
    }
    private void Start()
    {
        startPosition = transform.position;
        CurrentHP = maxHP;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BlackPlane") || other.CompareTag("Point"))
        {
            Die();
        }
    }
    private void Die()
    {
        transform.position = startPosition;
        rb.velocity = Vector2.zero;
        CurrentHP--;
    }

}
