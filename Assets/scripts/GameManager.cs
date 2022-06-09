using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    public Text scoreText;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        instance = this;
    }

  
}
