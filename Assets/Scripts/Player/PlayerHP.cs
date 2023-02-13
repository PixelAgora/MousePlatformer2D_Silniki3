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
    [SerializeField] private UIController uiController;

    private int CurrentHP
    {
        get { return currentHP; }
        set
        {
            currentHP = value;
            if (currentHP <= 0)
            {
                uiController.SetEndGame1(false);
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
        Pickup pickup = other.GetComponent<Pickup>();
        if (pickup != null) //true jeśli other zawiera Pickup, false jeśli go nie zawiera
        {
            CurrentHP += pickup.Collect();
        }

        if (other.CompareTag("BlackPlane") || other.CompareTag("Point") || other.CompareTag("PlayerKiller"))
        {
            Die();
        }
        if (other.CompareTag("Cable"))
        {
            uiController.SetEndGame2(false);
        }
    }

    private void Die()
    {
        transform.position = startPosition;
        rb.velocity = Vector2.zero;
        CurrentHP--;
    }
}
