using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public KeyCode right;
	public KeyCode left;
	public KeyCode jump;
	public float jumpForce;
	public float turnSpeed;
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate() {
		Vector3 vel = transform.forward * speed;
		GetComponent<Rigidbody>().velocity = vel;		
		if (Input.GetKey (left)) {
			transform.Rotate (new Vector3(0,-90,0));
		} 
		if (Input.GetKey (right)) {
			transform.Rotate (new Vector3(0,90,0));
		}
		if (Input.GetKey (jump)) {
			GetComponent<Rigidbody>().AddForce(new Vector3(0f, jumpForce, 0f));
		}
	}

}
