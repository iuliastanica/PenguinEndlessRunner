using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform player;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.position = new Vector3(player.position.x + 6, player.position.y + 4, -10);
        //transform.position = new Vector3(player.position.x + 6, 0, -10);
    }
}
