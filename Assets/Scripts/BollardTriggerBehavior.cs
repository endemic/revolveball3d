using UnityEngine;
using System.Collections;

public class BollardTriggerBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Swap the positions of green/red blocks
	void OnTriggerEnter(Collider other) {
		GameObject[] blocks = GameObject.FindGameObjectsWithTag("Bollard");
		
		foreach (GameObject block in blocks) {
			block.SendMessage("Toggle");
		}
		
		// TODO: Pause game slightly
		// TODO: Play sound effect
	}
}
