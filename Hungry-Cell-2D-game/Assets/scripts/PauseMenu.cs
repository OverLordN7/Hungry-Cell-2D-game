﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenu;

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        } 
    }

     public void Resume()
     {
         pauseMenu.SetActive(false);
         Time.timeScale = 1f;
         GameIsPaused = false;
     }

     void Pause()
     {
         pauseMenu.SetActive(true);
         Time.timeScale = 0f;
         GameIsPaused = true;
     }

     public void Restart()
     {
         SceneManager.LoadScene("Main");
         Time.timeScale = 1f;
     }

     public void Quit()
     {
         Application.Quit();
     }
}
