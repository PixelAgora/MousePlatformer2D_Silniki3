using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private EndGamePanel endGamePanel;
    public void SetEndGame1(bool win)
    {
        if (!win)
        {
            endGamePanel.OpenLosePanel();
        }
        else
        {
            
        }
    }

    public void SetEndGame2(bool lose)
    {
        if (!lose)
        {
            endGamePanel.OpenWinPanel();
        }
    }
}
