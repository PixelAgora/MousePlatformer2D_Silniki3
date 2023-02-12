using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePlane : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.position += Vector3.left * (speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Killer"))
        {
            Destroy();
        }
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
