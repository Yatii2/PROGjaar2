using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Scoreboard : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = 0;

    private void OnEnable()
    {
        PickUp.OnPickupCollected += AddScore;
        
    }

    private void OnDisable()
    {
        PickUp.OnPickupCollected -= AddScore;
    }

    private void AddScore()
    {
        score += 50;
        scoreText.text = "Score: " + score;
    }

}
