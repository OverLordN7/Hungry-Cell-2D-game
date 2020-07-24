using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EffectScript : MonoBehaviour
{
    public GameObject effectPrefab;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(effectPrefab, transform.position, Quaternion.Euler(0, 0, 0));
        Destroy(gameObject);
    }
}
