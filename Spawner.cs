using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] objects;
    public float spawnTimeMin = 1f;
    public float spawnTimeMax = 2f;
    public Transform player;

    void Start ()
    {
        Spawn();
	}
	
    void Spawn()
    {
        Instantiate(objects[Random.Range(0, objects.Length)], new Vector2(transform.position.x, transform.position.y - player.position.y - 2), Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnTimeMin, spawnTimeMax));
    }
}
