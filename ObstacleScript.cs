using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{

    ScoreCalculator calculator;

    private void Start()
    {
        calculator = GameObject.Find("Main Camera").GetComponent<ScoreCalculator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.tag.Equals("Obstacle") && (collision.tag.Equals("Player")))
        {
            calculator.AddPowerUp(-1000);
            // Destroy(this.gameObject);
            Debug.Log("-1000");
        }
    }
}