using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    ScoreCalculator calculator;

    private void Start()
    {
        calculator = GameObject.Find("Main Camera").GetComponent<ScoreCalculator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.tag.Equals("BigPowerUp"))
        {            
            calculator.AddPowerUp(5000);
            Destroy(this.gameObject);
            Debug.Log("5000");
        }
        else 
            if (collision.tag.Equals("Player"))
                {
                    calculator.AddPowerUp(100);
                    Destroy(this.gameObject);
                }
    }
}
