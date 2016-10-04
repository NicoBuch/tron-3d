using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public KeyCode right;
	public KeyCode left;
	public KeyCode jump;
	public float jumpForce;
	public float speed;
    public PauseMenu pauseMenu;

    private bool onGround = true;
	
	void LateUpdate() {
        if (!pauseMenu.isPaused())
        {
            transform.position += (-1) * transform.right * Time.deltaTime * speed;
            if (Input.GetKeyUp(left))
            {
                transform.Rotate(0, -90, 0);
            }
            if (Input.GetKeyUp(right))
            {
                transform.Rotate(0, 90, 0);
            }
            if (Input.GetKeyUp(jump) && onGround)
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0f, jumpForce, 0f));
                onGround = false;
            }
        }
	}

    void OnCollisionEnter(Collision coll)
    {
        onGround = true;
    }
}
