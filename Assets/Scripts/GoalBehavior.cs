using UnityEngine;
using System.Collections;

public class GoalBehavior : MonoBehaviour {

	private AudioSource sound;
	
	// Use this for initialization
	void Start () {
		// Get ref to audio source
		sound = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		Debug.Log("Entered goal area!");
		
		// TODO: Send message here that says player finished the level
		
		if (sound != null) {
			sound.Play();	
		}
	}
}
