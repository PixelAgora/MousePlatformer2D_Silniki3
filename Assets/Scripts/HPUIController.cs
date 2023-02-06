using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPUIController : MonoBehaviour
{
    [SerializeField] private HPCheese hpCheesePrefab;

    private HPCheese[] hpElements;

    public void Setup(int maxHP)
    {
        hpElements = new HPCheese[maxHP];
        
        for (int i = 0; i < maxHP; i++)
        {
            HPCheese e = Instantiate(hpCheesePrefab, transform);
            e.SetHP(true);
            hpElements[i] = e;
        }
    }

    public void SetHP(int amount)
    {
        for (int i = 0; i < hpElements.Length; i++)
        {
            hpElements[i].SetHP(i<amount);
        }
    }
}