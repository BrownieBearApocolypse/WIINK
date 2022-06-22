using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerCanvas : MonoBehaviour
{
    public Canvas Canvas;
    public Text scoreText, highScoreText;

    public void Update()
    {
        scoreText.text = GameManager.Instance.score.ToString();
        highScoreText.text = GameManager.Instance.highScore.ToString();

    }
}