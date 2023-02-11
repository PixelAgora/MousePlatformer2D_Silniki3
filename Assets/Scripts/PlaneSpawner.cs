using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlaneSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float interval = 5;
    float timer;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            timer -= interval;
        }
    }
}
