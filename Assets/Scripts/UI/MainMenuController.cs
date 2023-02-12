using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{

    [SerializeField] private Button startGameButton;
    [SerializeField] private Button optionsButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button quitGameButton;
    [SerializeField] private Button quitOptionsMenuButton;
    [SerializeField] private Button quitCreditsMenuButton;
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject OptionsMenu;
    [SerializeField] private GameObject CreditsMenu;


    private void Awake()
    {
        startGameButton.onClick.AddListener(OnStartGameButtonClicked);
        optionsButton.onClick.AddListener(OnOptionsButtonClicked);
        creditsButton.onClick.AddListener(OnSCreditsButtonClicked);
        quitGameButton.onClick.AddListener(OnQuitGameButtonClicked);
        quitOptionsMenuButton.onClick.AddListener(OnQuitOptionsMenuButtonClicked);
        quitCreditsMenuButton.onClick.AddListener(OnQuitCreditsMenuButtonClicked);

    }

    private void OnStartGameButtonClicked()
    {
        SceneManager.LoadScene("Cutscene",LoadSceneMode.Single);
    }
    private void OnOptionsButtonClicked()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
        CreditsMenu.SetActive(false);
    }
    private void OnQuitOptionsMenuButtonClicked()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
        CreditsMenu.SetActive(false);
    }
    private void OnSCreditsButtonClicked()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        CreditsMenu.SetActive(true);
    }
    private void OnQuitCreditsMenuButtonClicked()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
        CreditsMenu.SetActive(false);
    }
    private void OnQuitGameButtonClicked()
    {
        Application.Quit();
        Debug.Log("Quitter");
    }
}