using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public TextMeshProUGUI nameEntry;
    public Button startButton;

    private void Start()
    {
        startButton.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        Debug.Log(nameEntry.text + " is entering the game..");
        GameSingleton.Instance.PlayerName = nameEntry.text;
        SceneManager.LoadScene(1);
    }
}
