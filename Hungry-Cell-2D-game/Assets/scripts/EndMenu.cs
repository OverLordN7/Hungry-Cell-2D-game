using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public GameObject endMenu;
    [SerializeField] private HealthBar healthBar;
    public static bool gameIsOver = false;

   
    void Update()
    {
        
        if (healthBar.GetHealth() <= 0)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }
    
     public void Restart()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1f;
    }
    void Pause()
    {
        endMenu.SetActive(true);
        Time.timeScale = 0f;
        gameIsOver = true;
    }
    public void Resume()
    {
        endMenu.SetActive(false);
        Time.timeScale = 1f;
        gameIsOver = false;
    }
    
    void End()
    {
        endMenu.SetActive(true);
        Time.timeScale = 0f;
        gameIsOver = true;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    
}
