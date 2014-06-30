using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	

	public float moveForce = 365f;			// Amount of force added to move the player left and right.
	public float maxSpeed = 20f;				// The fastest the player can travel in the x axis.
	public float currMaxSpeed = 20f;

	public Ball BallPrefab;
	private Ball startBall;

	// Use this for initialization
	void Start () {
		currMaxSpeed = maxSpeed;

		//Create a new ball
		ResetBallAndPosition();
	}

	public void ResetBallAndPosition ()
	{
		//Create the ball
		Vector3 ballPosition = new Vector3( transform.position.x, transform.position.y + 0.25f, transform.position.z );

		if( startBall )
		{
			Destroy( startBall );
		}

		Ball ballbody = (Ball)Instantiate (BallPrefab, ballPosition, Quaternion.identity );
		startBall = ballbody.gameObject.GetComponent< Ball >();

		startBall.SetInitialBall();
		startBall.paddle = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		//Prevent the paddle from bouncing backwards when hit.
		this.transform.position.Set(this.transform.position.x, -6, this.transform.position.z);
		//Grab the horizontal movement from wasd or arrow keys.
		//GetAxisRaw lets the paddle stop on a dime once the button is let up.
		float horizontalInput = Input.GetAxisRaw ("Horizontal");
	    

		//If you hold down shift, you can move faster
		if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.LeftShift))
			currMaxSpeed = maxSpeed * 2f;
		else
			currMaxSpeed = maxSpeed;
		
		this.rigidbody2D.velocity = Vector2.right * horizontalInput * currMaxSpeed;

		//Launch the ball when spacebar is pressed
		if( Input.GetKeyDown( KeyCode.Space ) )
		{
			if( startBall )
			{
				startBall.LaunchBall();
			}

			//var balls = GameObject.FindGameObjectsWithTag( "Ball" );
			//
			//foreach( GameObject gameobject in balls )
			//{
			//	Ball ball = (Ball) gameobject.GetComponent( typeof( Ball ) );
			//	if( ball.initialBall )
			//	{
			//		ball.LaunchBall();
			//	}
			//}
		}
	}
}
