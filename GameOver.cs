using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    int score = 0;
    int highscore = 0;

	void Start ()
    {
        score = PlayerPrefs.GetInt("Score");
        highscore = PlayerPrefs.GetInt("Highscore");
    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 60, Screen.height  / 2, 150, 40), "Your score was: " + score);
        GUI.Label(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 50, 150, 40), "The highscore is: " + highscore);

        if (GUI.Button(new Rect(Screen.width / 2 - 30, Screen.height / 2 + 100, 60, 30), "Retry?"))
        {
            SceneManager.LoadScene(0);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 30, Screen.height / 2 + 150, 60, 30), "Quit?"))
        {
            Application.Quit();
        }
    }

}
