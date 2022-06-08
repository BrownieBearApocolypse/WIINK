using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelMenu : MonoBehaviour
{
    public Canvas endMenu;

    public void OnTriggerEnter (Collider2D other)
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
   
    void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
