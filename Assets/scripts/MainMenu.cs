using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Canvas mainMenu;
    public Canvas howToMenu;
    

    private void Awake()
    {    
        howToMenu.enabled = false;
    }

    public void LoadOn()
    {
        SceneManager.LoadScene(1);
        GameManager.Instance.DeleteKey();
    }

    public void HowTo()
    {
        mainMenu.enabled = false;
        howToMenu.enabled=true;
    }

    public void Return()
    {
        mainMenu.enabled = true;
        howToMenu.enabled = false;
    }

    public void Exit()
    {
        Application.Quit();
        GameManager.Instance.DeleteKey();
    }
}
