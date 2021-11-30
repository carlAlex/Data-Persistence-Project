using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSingleton : MonoBehaviour
{
    public static GameSingleton Instance;

    private string playerName;
    
    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    private int highScore;

    public int HighScore
    {
        get { return highScore; }
        set { highScore = value; }
    }

    private string highScoreHolder;

    public string HighScoreHolder
    {
        get { return highScoreHolder; }
        set { highScoreHolder = value; }
    }


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
