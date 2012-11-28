using UnityEngine;
using System.Collections;

public class BrokenWallParticleBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Remove();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Destroy after 5 seconds
	IEnumerator Remove() {
        yield return new WaitForSeconds(5);
        GameObject.Destroy(gameObject);
    }
}
