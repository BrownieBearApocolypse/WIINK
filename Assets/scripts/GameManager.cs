using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score, highScore;
    public int lvlScore = 0;

    private void Start()
    {
        Load();  
        
    }

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        
    }

    public void AddScore(int score)
    {      
        score += lvlScore;
        Save();
    }

    public void IncreaseScore(int totalScore)
    {
        lvlScore += PointManager.Instance.pointsPerCollectable;

    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("score");
        highScore = PlayerPrefs.GetInt("highscore");
    }
    public void Save()
    {
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.SetInt("highscore", highScore);
        
    }

    private void OnLevelWasLoaded(int level)
    {
        lvlScore = 0;
        // if previous scene = this scene { PlayerPrefs.DeleteKey("score");  }
    }

    public void DeleteKey()
    {
        score = 0;
    }

    public void LevelNO()
    {
       lvlScore = 0;
    }

    public void FixScore()
    {
        score - 3; 
    }
}
