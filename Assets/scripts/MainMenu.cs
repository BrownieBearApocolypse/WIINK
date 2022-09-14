using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Canvas mainMenu;
    public Canvas howToMenu;
    
    //makes it so you only see the main canvas on boot up
    private void Awake()
    {    
        howToMenu.enabled = false;
    }

    //function for the button to load first level
    public void LoadOn()
    {
        SceneManager.LoadScene(1);
        GameManager.Instance.DeleteKey();
    }

    //for the button to open how to canvas and close menu cnavas. 
    public void HowTo()
    {
        mainMenu.enabled = false;
        howToMenu.enabled=true;
    }

    //opposite if the how to button, returns player to menu screen
    public void Return()
    {
        mainMenu.enabled = true;
        howToMenu.enabled = false;
    }

    //shuts down application and deletes current score data
    public void Exit()
    {
        Application.Quit();
        GameManager.Instance.DeleteKey();
    }
}
