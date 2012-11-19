using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Assign a rigidbody component if one doesn't exist
		if (gameObject.GetComponent<Rigidbody>() == null) {
			gameObject.AddComponent<Rigidbody>();
		}
	}
	
	// Update is called once per frame
	void Update () {
		// Keep ball from sleeping
		if (rigidbody.IsSleeping()) {
			rigidbody.WakeUp();	
		}
	}
}
