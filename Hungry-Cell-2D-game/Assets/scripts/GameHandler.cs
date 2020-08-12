using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public int maxHealth = 100;
     public int currentHealth;

     public HealthBarScript _HealthBarScripts;
    
     void Start()
     {
         currentHealth = maxHealth;
         _HealthBarScripts.SetMaxHealth(maxHealth);
         StartCoroutine(_HealthBarScripts.DamageOverTime(10f));
     }
     
     public void TakeDamage(int damage) { _HealthBarScripts.ReduceHealth(damage); }
     public void TakeHeal(int heal) { _HealthBarScripts.IncreaseHealth(heal); }

     public int GetHealth() { return currentHealth; }
}
