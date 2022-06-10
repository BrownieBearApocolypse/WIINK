using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float Score = 0;
    public Canvas highScoreCanvas;
    public float pointsPerCollectable = 1;
    public Text scoreText;
    private float displayScore;
    public float transitionSpeed = 100;

    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        highScoreCanvas.enabled = false;
    }

    public void Update()
    {
        displayScore = Mathf.MoveTowards(displayScore, Score, transitionSpeed * Time.deltaTime);
        UpdateScoreDisplay();
    }

    public void IncreaseScore(float amount)
    {
        Score += amount;

    }

    public void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + Score;
    }



}
