using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointManager : MonoBehaviour
{
    public static PointManager Instance { get; private set; }
    public int totalScore = 0;   
    public int pointsPerCollectable = 1;
    public Text scoreText;  
    float displayScore;
    public int transitionSpeed = 50;
    public Canvas pointManager;
    

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            pointManager.enabled = true;
        }
    }

    public void Update()
    {
        displayScore = Mathf.MoveTowards(displayScore, totalScore, transitionSpeed * Time.deltaTime);
        UpdateScoreDisplay();
        
    }

    private void Awake()
    {

        Instance = this;
        pointManager.enabled = false;
    }

    public void IncreaseScore(int totalScore)
    {
        totalScore += pointsPerCollectable;
        
    }

    public void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + totalScore;
    }

    
}
