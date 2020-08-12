using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{

    public Slider slider;

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    
    public IEnumerator DamageOverTime(float inputDamage)
    {
        while (slider.value>0)
        {
            slider.value -= inputDamage;
            SetHealth((int) slider.value);
            yield return new WaitForSeconds(1f);
        }
    }


    public void ReduceHealth(int damage) { slider.value -= damage; }
    public void IncreaseHealth(int heal) { slider.value += heal; }
    public int GetHealth() { return (int) slider.value; }
    
}
