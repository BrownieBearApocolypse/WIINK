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

    //calls Load funciton at scene start
    private void Start()
    {
        Load();  
        
    }

    //at scene awake makes sure there is only one game object with this code
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

    //funciton to add lvl score to the total game score
    public void AddScore(int score)
    {      
        score += lvlScore;
        Save();
    }

    //funciton to track when scores are collected
    public void IncreaseScore(int totalScore)
    {
        lvlScore += PointManager.Instance.pointsPerCollectable;

    }

    //funciton, finds the saved data of current score and previous high score
    public void Load()
    {
        score = PlayerPrefs.GetInt("score");
        highScore = PlayerPrefs.GetInt("highscore");
    }

    //makes sure that the data for current score and previous high score are saved
    public void Save()
    {
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.SetInt("highscore", highScore);
        
    }

    //resets level score
    private void OnLevelWasLoaded(int level)
    {
        lvlScore = 0;
        // if previous scene = this scene { PlayerPrefs.DeleteKey("score");  }
    }

    //resets current score for full game when called
    public void DeleteKey()
    {
        score = 0;
    }

    //resets lvl score when called
    public void LevelNO()
    {
       lvlScore = 0;
    }

    //takes 3 from score when called
    public void FixScore()
    {
        score =- 3; 
    }
}
