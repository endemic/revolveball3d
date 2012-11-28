using UnityEngine;
using System.Collections;

public class WallBehavior : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Play sound effect on collision
	void OnCollisionEnter(Collision collision) {
		if (collision.relativeVelocity.magnitude > 1) {
			// Get reference to the audio source
			AudioSource sound = gameObject.GetComponent<AudioSource>();
			
			if (sound != null) {
				sound.Play();
			}
		}
	}
}
