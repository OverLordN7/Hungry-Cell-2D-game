﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
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

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
