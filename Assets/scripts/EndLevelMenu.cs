using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelMenu : MonoBehaviour
{
    public Canvas endMenu;

    private void Awake()
    {
        endMenu.enabled = false;
    }
   

    void MainMenu()
    {

    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
