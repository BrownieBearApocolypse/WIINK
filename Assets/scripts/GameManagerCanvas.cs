using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerCanvas : MonoBehaviour
{
    public Canvas Canvas;
    public Text scoreText, highScoreText;

    //tracks what the text on the canvas should say and also lets game know when to change the highscore
    public void Update()
    {
        scoreText.text = "Score " + GameManager.Instance.score.ToString();
        highScoreText.text = "HighScore " + GameManager.Instance.highScore.ToString();
        
        if (GameManager.Instance.score > GameManager.Instance.highScore)
        {
            GameManager.Instance.highScore = GameManager.Instance.score;
            GameManager.Instance.Save();
        }
    }

    //loads scene 0 when button clicked and also deletes current score
    public void Restart()
    {
        SceneManager.LoadScene(0);
        GameManager.Instance.DeleteKey();
    }

    //exits application and deletes current score
    public void Exit()
    {
        Application.Quit();
        GameManager.Instance.DeleteKey();
    }
}
