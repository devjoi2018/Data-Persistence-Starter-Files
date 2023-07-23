using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    [Tooltip("Input field for player name")]
    [SerializeField] private TMP_InputField inputName;
    [Tooltip("Button to start the game")]
    [SerializeField] private Button startButton;
    [Tooltip("Button to exit the game")]
    [SerializeField] private Button exitButton;

    private void Start()
    {
        //inputName.text = GameManager.Instance.playerName;
    }
    private void ValueChangeCheck()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.playerName = inputName.text;
        }
    }


    public void StartGame()
    {
        ValueChangeCheck();
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}