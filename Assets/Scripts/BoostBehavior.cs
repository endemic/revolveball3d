using UnityEngine;
using System.Collections;

public class BoostBehavior : MonoBehaviour {
	
	public int force = 10;
	private AudioSource sound;
	
	// Use this for initialization
	void Start () {
		// Get ref to audio source
		sound = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// When other object enters, apply a "boost" force
	void OnTriggerEnter(Collider other) {
		
		other.gameObject.rigidbody.AddForce(new Vector3(Mathf.Cos(Mathf.Deg2Rad * (transform.eulerAngles.z + 90)), Mathf.Sin(Mathf.Deg2Rad * (transform.eulerAngles.z + 90)), 0) * force, ForceMode.Impulse);
		
		if (sound != null) {
			sound.Play();
		}
	}
}
