using UnityEngine;
using System.Collections;

public class BrokenBlockParticleBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Remove after 5 seconds
		GameObject.Destroy(gameObject, 3);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
