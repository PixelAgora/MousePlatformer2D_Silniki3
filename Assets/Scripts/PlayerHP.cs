using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerHP : MonoBehaviour
{
    [SerializeField] private int maxHP = 3;
    [SerializeField] private UIController uiController;
    private int currentHP;
    
    private int CurrentHP
    {
        get
        {
            return currentHP;
        }
        set
        {
            currentHP = value;
            uiController.SetCurrentHP(currentHP);
            if (currentHP <= 0)
            {
                uiController.SetEndGame(false);
            }
        }
    }
    private void Start()
    {
        uiController.SetMaxHP(maxHP);
        CurrentHP = maxHP;
    }
}
