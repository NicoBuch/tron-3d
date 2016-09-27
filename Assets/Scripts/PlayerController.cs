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
	
	void LateUpdate() {
		transform.position += transform.forward * Time.deltaTime * speed;			
		if (Input.GetKeyUp (left)) {
			transform.Rotate(0,-90,0);
			//Debug.Log("left");
			//Quaternion originalRot = transform.rotation;
			//transform.rotation = originalRot * Quaternion.AngleAxis (90, Vector3.right);
		} 
		if (Input.GetKeyUp (right)) {
			transform.Rotate(0,90,0);
			//Debug.Log("right");
			//Quaternion originalRot = transform.rotation;
			//transform.rotation = originalRot * Quaternion.AngleAxis (90, Vector3.right);
		}
		if (Input.GetKeyUp (jump)) {
			GetComponent<Rigidbody>().AddForce(new Vector3(0f, jumpForce, 0f));
		}
	}

}
