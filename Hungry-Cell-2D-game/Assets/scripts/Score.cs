using System;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int scoreAmount;
    public Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmount = 0;
    }

    void Update()
    {
        scoreText.text = "Score: " + scoreAmount;
    }
}
