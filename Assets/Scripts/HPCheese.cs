using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPCheese : MonoBehaviour
{
    [SerializeField] private Sprite emptyLife;
    [SerializeField] private Sprite fullLife;
    [SerializeField] private Image image;
    
    private bool isFull;

    public void SetHP(bool isFull)
    {
        this.isFull = isFull;
        
        image.sprite = isFull ? fullLife : emptyLife;
        /*
        if(isFull) 
        {
            image.sprite = fullLife;
        }
        else
        {
            image.sprite = emptyLife;
        }
        */
    }
}