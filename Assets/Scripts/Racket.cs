﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Racket : MonoBehaviour
{
    public Text ScoreText;
    public float MoveSpeed;
    protected float Score;

    private void Start()
    {
        MoveSpeed = 10.0f;
    }
    public void ScoreUp() //Skor yap
    {
        Score++;
        ScoreText.text = Score.ToString();
    }
}
