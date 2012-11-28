using UnityEngine;
using System.Collections;

public class BreakableWallBehavior : MonoBehaviour {
	
	public Transform particle;
	
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
			
			// Create 8 "particle" prefabs here
			// TODO: Have these fade out and then disappear
			Instantiate(particle, new Vector3(transform.position.x - 0.5f, transform.position.y + 0.5f, 0.5f), Quaternion.identity);
			Instantiate(particle, new Vector3(transform.position.x + 0.5f, transform.position.y + 0.5f, 0.5f), Quaternion.identity);
			Instantiate(particle, new Vector3(transform.position.x + 0.5f, transform.position.y - 0.5f, 0.5f), Quaternion.identity);
			Instantiate(particle, new Vector3(transform.position.x - 0.5f, transform.position.y - 0.5f, 0.5f), Quaternion.identity);
			
			Instantiate(particle, new Vector3(transform.position.x - 0.5f, transform.position.y + 0.5f, -0.5f), Quaternion.identity);
			Instantiate(particle, new Vector3(transform.position.x + 0.5f, transform.position.y + 0.5f, -0.5f), Quaternion.identity);
			Instantiate(particle, new Vector3(transform.position.x + 0.5f, transform.position.y - 0.5f, -0.5f), Quaternion.identity);
			Instantiate(particle, new Vector3(transform.position.x - 0.5f, transform.position.y - 0.5f, -0.5f), Quaternion.identity);
			
			// Destroy self
			GameObject.Destroy(gameObject);
		}
	}
}
