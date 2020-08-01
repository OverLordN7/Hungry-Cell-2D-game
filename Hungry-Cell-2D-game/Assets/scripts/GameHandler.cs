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
     
    
}
