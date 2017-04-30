using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destructor : MonoBehaviour {

    public Transform player;

    private void Update()
    {
        transform.position = new Vector3(player.position.x + 6, -9.8f, -10);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(1);
            return;
        }
    }
}
