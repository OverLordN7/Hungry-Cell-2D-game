using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private float health = 1.0f;

    [SerializeField] private HealthBar healthBar;
    // Start is called before the first frame update
     void Start()
    {
        healthBar.SetSize(health);
        if (healthBar.GetHealth() <= 0)
        {
           //ToDo game over. function which stops the game and make menu
        }
        else
        {
            StartCoroutine(healthBar.DamageOverTime(0.05f));
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
