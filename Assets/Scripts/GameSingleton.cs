using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

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
        LoadHighScore();
    }

    internal void SetHighScore(int m_Points)
    {
        SaveHighScore(m_Points);
    }

    [System.Serializable]
    class HighScoreData
    {
        public string Name;
        public int Score;
    }

    private void SaveHighScore(int score)
    {
        HighScoreData data = new HighScoreData();
        data.Name = PlayerName;
        data.Score = score;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    private void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            HighScoreData data = JsonUtility.FromJson<HighScoreData>(json);

            HighScoreHolder = data.Name;
            HighScore = data.Score;
        }
    }
}
