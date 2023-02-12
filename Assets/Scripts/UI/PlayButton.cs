using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private Button playButton;
    private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
    }
    private void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("Level 1",LoadSceneMode.Single);
    }
}
