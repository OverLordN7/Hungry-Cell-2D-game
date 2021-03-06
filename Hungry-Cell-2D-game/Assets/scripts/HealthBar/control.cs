﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBarScript _HealthBarScripts;
    
    void Start()
    {
        currentHealth = maxHealth;
        _HealthBarScripts.SetMaxHealth(maxHealth);
        StartCoroutine(_HealthBarScripts.DamageOverTime(5f));
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //TakeDamage(20);
            TakeHeal(20);
        }
    }


    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        _HealthBarScripts.SetHealth(currentHealth);
    }
    void TakeHeal(int heal)
    {
        currentHealth += heal;
        _HealthBarScripts.SetHealth(currentHealth);
    }
}
