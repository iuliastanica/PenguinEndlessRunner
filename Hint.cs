using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour {

	// Use this for initialization
	private void Start ()
    {
        Invoke("Hide", 5f);
	}
	
	private void Hide()
    {
        Destroy(gameObject);
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2, 10, Screen.width / 3, Screen.height / 10), "Don't be afraid to use...THE DOUBLE JUMP!!");
    }
}
