using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointManager : MonoBehaviour
{
    public static PointManager instance { get; private set; }
    public float Score = 0;
    public float pointsPerCollectable = 1;
    public Text scoreText;
    float displayScore;
    public float transitionSpeed = 100;
    public Canvas pointManager;

    public void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            pointManager.enabled = true;
        }
    }

    public void Update()
    {
        displayScore = Mathf.MoveTowards(displayScore, Score, transitionSpeed * Time.deltaTime);
        UpdateScoreDisplay();
    }

    private void Awake()
    {
        instance = this;
        pointManager.enabled = false;
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
