using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float moveForce = 365f;			// Amount of force added to move the player left and right.
	public float maxSpeed = 20f;				// The fastest the player can travel in the x axis.
	private float currMaxSpeed = 20f;
	// Use this for initialization
	void Start () {
		currMaxSpeed = maxSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		//Grab the horizontal movement from wasd or arrow keys.
		//GetAxisRaw lets the paddle stop on a dime once the button is let up.
		float horizontalInput = Input.GetAxisRaw ("Horizontal");
		//If you hold down shift, you can move faster
		if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.LeftShift))
			currMaxSpeed *= 2f;

		if (horizontalInput == 0f)
			this.rigidbody2D.velocity = new Vector2 (0f, 0f);

		if (horizontalInput * this.rigidbody2D.velocity.x < currMaxSpeed)
			this.rigidbody2D.velocity = Vector2.right * horizontalInput * currMaxSpeed;

		currMaxSpeed = maxSpeed;
	}
}
