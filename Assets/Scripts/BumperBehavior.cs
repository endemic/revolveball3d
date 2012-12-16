using UnityEngine;
using System.Collections;

public class BumperBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision) {
		ContactPoint contact = collision.contacts[0];
		
		// Get the colliding object (e.g. the ball) and add a force to its' rigidbody
		collision.rigidbody.AddForce(contact.point, ForceMode.Impulse);
	}
}
