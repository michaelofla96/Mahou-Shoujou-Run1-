using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_manager : MonoBehaviour {

    public Text ScoreText;

    public float ScoreCounter;
    public float pointspersecond;

    public bool Alive;

    internal static void GemPoints(int pointsGem)
    {
        throw new NotImplementedException();
    }

    void Update ()
    {
        if (Alive)
        {
            ScoreCounter += pointspersecond * Time.deltaTime;
        }

        ScoreText.text = "SCORE: " + Mathf.Round(ScoreCounter);
	}

    public static void GemPoints (int pointsGem, float ScoreCounter)
    {
        ScoreCounter += pointsGem;
    }

    public static void ResetScore (float ScoreCounter)
    {
        ScoreCounter = 0;
    }
}
