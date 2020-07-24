using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private float health = 1.0f;

    [SerializeField] private HealthBar healthBar;
    
     void Start()
    {
        healthBar.SetSize(health);
        StartCoroutine(healthBar.DamageOverTime(0.05f));
    }
     
    void Update()
    {
        if (healthBar.GetHealth() <= 0)
        {
            Time.timeScale = 0;
            Restart();
        }
    }
    
    void Restart()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
}
