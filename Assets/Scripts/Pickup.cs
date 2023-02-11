using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private int health;

    public int Collect()
    {
        Destroy(gameObject);
        return health;
    }
};