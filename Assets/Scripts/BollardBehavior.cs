using UnityEngine;
using System.Collections;

public class BollardBehavior : MonoBehaviour {
	
	public Transform post;
	public bool extended = true;
	
	// Use this for initialization
	void Start () {
		if (extended) {
			Toggle();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Not exactly sure how this method will be called
	void Toggle() {
		if (post.localPosition == Vector3.zero) {
			post.localPosition = new Vector3(0, 0, 1);
		} else {
			post.localPosition = Vector3.zero;
		}
	}
}
