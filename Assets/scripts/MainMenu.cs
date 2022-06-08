using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Canvas mainMenu;
    public Canvas HowToMenu;
    

    private void Awake()
    {    
        HowToMenu.enabled = false;
    }

    public void LoadOn()
    {
        SceneManager.LoadScene(1);
    }

    public void HowTo()
    {
        mainMenu.enabled = false;
        HowToMenu.enabled=true;
    }

    public void Return()
    {
        mainMenu.enabled = true;
        HowToMenu.enabled = false;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
