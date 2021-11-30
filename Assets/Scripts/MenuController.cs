using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

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
        Debug.Log(nameEntry.text);
    }
}
