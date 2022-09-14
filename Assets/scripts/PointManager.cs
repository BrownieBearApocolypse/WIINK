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
    
    //enables the canvas displaying the lvl score when player collides with object
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            pointManager.enabled = true;
        }
    }

    //updates the text on the score display as points collected
    public void Update()
    {
        displayScore = Mathf.MoveTowards(displayScore, totalScore, transitionSpeed * Time.deltaTime);
        UpdateScoreDisplay();
        
    }

    //makes sure that the point canvas isn't visible during gameplay
    private void Awake()
    {

        Instance = this;
        pointManager.enabled = false;
    }

    //adds poitns collected to toal score
    public void IncreaseScore(int totalScore)
    {
        totalScore += pointsPerCollectable;
        
    }

    //says what the score text should say
    public void UpdateScoreDisplay()
    {
        scoreText.text = "Level Score: " + totalScore + "/3";
    }

}
