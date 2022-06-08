using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Canvas HowToMenu;
    public Canvas mainMenu;

    private void Awake()
    {
        mainMenu.enabled = true;
        HowToMenu.enabled = false;
    }

    void HowTo()
    {
        mainMenu.enabled = false;
        HowToMenu.enabled=true;
    }

    void Return()
    {
        mainMenu.enabled = true;
        HowToMenu.enabled = false;
    }

    void Exit()
    {
        Application.Quit();
    }
}
