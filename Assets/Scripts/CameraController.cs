using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	public Transform target;
	
	public int rotationSpeed = 75;
	public float gravity = 9.8f;
	
	private float previousAngle, currentAngle;
	
	// Use this for initialization
	void Start () {
		// Create an audio listener if one doesn't exist
		if (gameObject.GetComponent<AudioListener>() == null) {
			gameObject.AddComponent<AudioListener>();	
		}
	}
	
	// Update is called once per frame
	void Update () {
		float z = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
		Vector2 currentInput = Input.mousePosition;
		
		// Keyboard controls
		if (z != 0) {
			// Rotate the camera itself around the z-axis
			transform.Rotate(0, 0, z);
			
			// Get current total angle of rotation - transform.rotation, target.rotation
			//float rotation = Quaternion.Angle(transform.rotation, new Quaternion(0, 0, 1, 0));
			
			Vector2 newGravity = new Vector2(Mathf.Sin(Mathf.Deg2Rad * transform.rotation.eulerAngles.z) * gravity, -Mathf.Cos(Mathf.Deg2Rad * transform.rotation.eulerAngles.z) * gravity);
			
			Physics.gravity = newGravity;
		}
		
		// Init the "previous" value
		// This condition is analogous to "onTouchStart"
		if (Input.GetMouseButtonDown(0)) {
			previousAngle = Mathf.Atan2(Screen.height / 2 - currentInput.y, Screen.width / 2 - currentInput.x) * Mathf.Rad2Deg;
		}
		
		// Mouse controls
		// "onTouchMove"
		if (Input.GetMouseButton(0)) {
			
			currentAngle = Mathf.Atan2(Screen.height / 2 - currentInput.y, Screen.width / 2 - currentInput.x) * Mathf.Rad2Deg;

			transform.Rotate(0, 0, previousAngle - currentAngle);
			
			Vector2 newGravity = new Vector2(Mathf.Sin(Mathf.Deg2Rad * transform.rotation.eulerAngles.z) * gravity, -Mathf.Cos(Mathf.Deg2Rad * transform.rotation.eulerAngles.z) * gravity);
		
			Physics.gravity = newGravity;
			
			previousAngle = currentAngle;
		}
		
		// Alter the slightly "downward" angle of the camera
		transform.eulerAngles = new Vector3(Mathf.Cos(Mathf.Deg2Rad * transform.eulerAngles.z) * 20, Mathf.Sin(Mathf.Deg2Rad * transform.eulerAngles.z) * 20, transform.eulerAngles.z);
		
		// Move camera based on target position
		// Be sure to account for the camera's "tilt"
		// tan(x) = opposite/adjacent - do this for both X and Y
		// tan(x) * adjacent = opposite
		float xOffset = Mathf.Tan(Mathf.Deg2Rad * transform.eulerAngles.x) * 10;
		float yOffset = Mathf.Tan(Mathf.Deg2Rad * transform.eulerAngles.y) * 10;
		Debug.Log(xOffset + ", " + yOffset);
		
		transform.position = new Vector3(target.position.x + xOffset, target.position.y + yOffset, transform.position.z);
	}
}
