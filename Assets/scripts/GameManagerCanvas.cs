using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerCanvas : MonoBehaviour
{
    public Canvas Canvas;
    public Text scoreText, highScoreText;

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

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
        PlayerPrefs.DeleteKey("score");
    }
}
