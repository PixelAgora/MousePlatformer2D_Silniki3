using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGamePanel : MonoBehaviour
{
    [SerializeField] private Image background;
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject winPanel; // Do zaimplementowania później
    [SerializeField] private Button restartButton;
    [SerializeField] private Button nextLevelButton; //Do zaimplementowania później

    private void Start()
    {
        Time.timeScale = 1;
        background.enabled = false;
        losePanel.SetActive(false);
        winPanel.SetActive(false);
        restartButton.onClick.AddListener(Restart);
    }

    public void OpenLosePanel()
    {
        Time.timeScale = 0;
        losePanel.SetActive(true);
        background.enabled = true;
    }
    
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}