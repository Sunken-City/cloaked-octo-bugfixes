using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float moveForce = 365f;			// Amount of force added to move the player left and right.
	public float maxSpeed = 20f;				// The fastest the player can travel in the x axis.

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalInput = Input.GetAxis ("Horizontal");
		if (horizontalInput == 0f)
			this.rigidbody2D.velocity = new Vector2 (0f, 0f);

		if (horizontalInput * this.rigidbody2D.velocity.x < maxSpeed)
			this.rigidbody2D.AddForce(Vector2.right * horizontalInput * moveForce);

		if(Mathf.Abs(this.rigidbody2D.velocity.x) > maxSpeed)
			// ... set the player's velocity to the maxSpeed in the x axis.
			this.rigidbody2D.velocity = new Vector2(Mathf.Sign(this.rigidbody2D.velocity.x) * maxSpeed, this.rigidbody2D.velocity.y);
	}
}
