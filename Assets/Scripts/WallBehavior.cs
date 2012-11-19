using UnityEngine;
using System.Collections;

public class WallBehavior : MonoBehaviour {
	
	public AudioSource sfx;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Play sound effect on collision
	void OnCollisionEnter(Collision collision) {
		if (collision.relativeVelocity.magnitude > 1 && sfx != null) {
			sfx.Play();
		}
	}
}
