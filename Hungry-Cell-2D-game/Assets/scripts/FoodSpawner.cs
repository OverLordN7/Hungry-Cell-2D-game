using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FoodSpawner : MonoBehaviour
{
    public GameObject foodPrefab;

    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    private bool gameStarted = true;

    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,
            Screen.height, Camera.main.transform.position.z));
        StartCoroutine(FoodWave());
    }

    private void spawnFood()
    {
        GameObject a = Instantiate(foodPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x+5, screenBounds.x-5), 
            Random.Range(-screenBounds.y + 2, screenBounds.y - 2));
        Destroy(a,2.5f);
    }

    IEnumerator FoodWave()
    {
        while (gameStarted)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnFood();
        }
    }
}
