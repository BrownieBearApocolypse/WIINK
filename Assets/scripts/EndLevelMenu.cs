using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelMenu : MonoBehaviour
{
    public Canvas endMenu;

    public void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            endMenu.enabled = true;
        }
    }

    private void Awake() 
    {
        endMenu.enabled = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        GameManager.Instance.DeleteKey();

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameManager.Instance.LevelNO();
        GameManager.Instance.FixScore();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
