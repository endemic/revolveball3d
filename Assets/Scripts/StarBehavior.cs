using UnityEngine;
using System.Collections;

public class StarBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Rotate around the y axis
		transform.Rotate(new Vector3(0, 1.5f, 0) * Time.deltaTime);
	}
	
	void OnTriggerEnter(Collider other) {
		// Audio isn't playing -- look into this http://docs.unity3d.com/Documentation/ScriptReference/AudioSource.PlayClipAtPoint.html
		if (audio != null) {
			audio.Play();	
		}
		
		// TODO: Send message that a star has been picked up
		
		GameObject.Destroy(gameObject);
	}
}
