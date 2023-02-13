using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGamePanel : MonoBehaviour
{
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private Button restartButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private Button nextLevelButton;

    private void Start()
    {
        Time.timeScale = 1;
        losePanel.SetActive(false);
        winPanel.SetActive(false);
        restartButton.onClick.AddListener(Restart);
        quitButton.onClick.AddListener(Quit);
        nextLevelButton.onClick.AddListener(NextLevel);
    }

    private void NextLevel()
    {
        Debug.Log("no");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Quit()
    {
        Application.Quit();
    }

    public void OpenLosePanel()
    {
        Time.timeScale = 0;
        losePanel.SetActive(true);
    }
    
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void OpenWinPanel()
    {
        Time.timeScale = 0;
        winPanel.SetActive(true);
    }
}