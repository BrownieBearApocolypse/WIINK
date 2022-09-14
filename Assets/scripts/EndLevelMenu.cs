using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelMenu : MonoBehaviour
{
    public Canvas endMenu;

    //when the player collides with the object, the end menu is enabled
    public void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            endMenu.enabled = true;
        }
    }

    //makes sure that when the scene is loaded the player can't see the end menu
    private void Awake() 
    {
        endMenu.enabled = false;
    }

    //button that allows player to return to main menu and also deletes score data of current play
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        GameManager.Instance.DeleteKey();

    }

    //button to reload level and delete level score but also to remove score earned
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameManager.Instance.LevelNO();
        GameManager.Instance.FixScore();
    }

    //takes player to the next level
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
