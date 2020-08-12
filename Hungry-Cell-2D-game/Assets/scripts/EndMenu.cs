using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public GameObject endMenu;
    
    //responsible for scaninng health status
    public HealthBarScript _HealthBarScripts;
    
    public static bool gameIsOver = false;

   
    void Update()
    {
        if (_HealthBarScripts.GetHealth() <= 0)
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
    

    public void BackToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    
}
