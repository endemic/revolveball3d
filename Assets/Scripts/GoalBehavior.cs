using UnityEngine;
using System.Collections;

public class GoalBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		Debug.Log("Entered goal area!");
		
		// TODO: Send message here that says player finished the level
		
		// As a temporary effect, warp the player back to the origin
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		
		if (player != null) {
			player.transform.position = Vector3.zero;
		}
		
		AudioSource sound = gameObject.GetComponent<AudioSource>();
		
		if (sound != null) {
			sound.Play();	
		}
	}
}
