using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private HPUIController hpController;
    [SerializeField] private EndGamePanel endGamePanel;
    public void SetMaxHP(int maxHP)
    {
        hpController.Setup(maxHP);
    }

    public void SetCurrentHP(int currentHP)
    {
        hpController.SetHP(currentHP);
    }
    public void SetEndGame(bool win)
    {
        if (!win)
        {
            endGamePanel.OpenLosePanel();
        }
        else
        {
            
        }
    }
}
