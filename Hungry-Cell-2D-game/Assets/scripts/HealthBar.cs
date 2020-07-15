using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private float health = 1.0f;
    
    private Transform bar;
    // Start is called before the first frame update
    private void Awake()
    {
        bar = transform.Find("Bar");
    }

    private void Start()
    {
        bar = transform.Find("Bar");
    }

    public void SetSize(float sizeNormalized)
    {
        bar.localScale=new Vector3(sizeNormalized,1f);
    }

    public void HealHealth(float heal)
    {
        if (health < 1.0f)
        {
            health += heal;
            bar.localScale=new Vector3(health,1f); 
        }

    }

    public float GetHealth()
    {
        return health;
    }
    


    public IEnumerator DamageOverTime(float inputDamage)
    {
        while (health>0)
        {
            health -= inputDamage;
            bar.localScale=new Vector3(health,1f);
            yield return new WaitForSeconds(1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
