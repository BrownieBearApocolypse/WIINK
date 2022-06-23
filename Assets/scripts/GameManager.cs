using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool lastScene = false;
    public int score, highScore;
    public int lvlScore;


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

    public void AddScore(int amount)
    {
        score += lvlScore;
        
    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("score");
        highScore = PlayerPrefs.GetInt("highscore");
    }
    public void Save()
    {
        //PointManager.Instance.totalScore += PointManager.Instance.totalScore;
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.SetInt("highscore", highScore);
    }
}
