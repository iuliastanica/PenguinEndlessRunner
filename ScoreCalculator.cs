using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour {

    float score;
    float highscore = -9999;

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscore");

    }

    void Update ()
    {
        score += (Time.deltaTime / 2) * 100;
	}

    public void AddPowerUp (int value)
    {
        score += value;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, Screen.width / 10, Screen.height / 10), "Your score: " + (int)score);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)score);
        Debug.Log("HERE!!!!");
        if (score > highscore)
        {
            PlayerPrefs.SetInt("Highscore", (int)score);
        }
    }
}
