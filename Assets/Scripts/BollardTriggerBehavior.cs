using UnityEngine;
using System.Collections;

public class BollardTriggerBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Swap the positions of green/red blocks
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag != "Player") {
			return;
		}
		
		GameObject[] blocks = GameObject.FindGameObjectsWithTag("Bollard");
		
		foreach (GameObject block in blocks) {
			block.SendMessage("Toggle");
		}
		
		// Pause game briefly
		StartCoroutine(Pause(0.25f));
		
		// Get reference to the audio source
		AudioSource sound = gameObject.GetComponent<AudioSource>();
		
		if (sound != null) {
			sound.Play();
		}
	}
	
	private IEnumerator Pause(float p) {
	    Time.timeScale = 0.0001f;
	    float pauseEndTime = Time.realtimeSinceStartup + p;
	    while (Time.realtimeSinceStartup < pauseEndTime) {
	        yield return 0;
	    }
	    Time.timeScale = 1.0f;
	}
	
	// This doesn't work for some reason
	/*
	IEnumerator PauseWaitResume(float delay) {
		Time.timeScale = 0.0000001f;
		yield return new WaitForSeconds(delay * Time.timeScale);
		Time.timeScale = 1.0f;
	}
	*/
}
