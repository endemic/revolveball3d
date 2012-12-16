using UnityEngine;
using System.Collections;

public class StarBehavior : MonoBehaviour {
	
	public AudioClip sfx;
	
	// Use this for initialization
	void Start () {
		//gameObject.AddComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		// Rotate around the y axis
		transform.Rotate(new Vector3(0, 1.5f, 0) * Time.deltaTime);
	}
	
	void OnTriggerEnter(Collider other) {
		// Play a one-shot clip
		AudioSource.PlayClipAtPoint(sfx, transform.position);
		
		// TODO: Send message that a star has been picked up
		
		GameObject.Destroy(gameObject);
	}
}
