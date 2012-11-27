using UnityEngine;
using System.Collections;

public class WallBehavior : MonoBehaviour {
	
	private AudioSource sound;
	
	// Use this for initialization
	void Start () {
		// Get reference to the audio clip
		sound = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Play sound effect on collision
	void OnCollisionEnter(Collision collision) {
		if (collision.relativeVelocity.magnitude > 1 && sound != null) {
			sound.Play();
		}
	}
}
