﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{

		private Rigidbody2D m_rb;

		// Use this for initialization
		void Start ()
		{
			float speed = 10.0f;

				m_rb = GetComponent< Rigidbody2D > ();
				if (m_rb) {
					m_rb.velocity = new Vector2( speed * Mathf.Cos ( Mathf.Deg2Rad * 45.0f ), speed * Mathf.Sin ( Mathf.Deg2Rad * 45.0f ) );
				}

				
		}

		// Update is called once per frame
		void Update ()
		{
			//transform.position += m_velocity * Time.deltaTime;
		}

		void OnCollisionEnter2D (Collision2D collision)
		{
			//If collided with a brick, destroy it
			if (collision.gameObject.CompareTag( "Brick"))
			{
				Destroy( collision.gameObject );
			}
			
			//If collided withe the paddle, change the angle of the ball based on the direction
			if (collision.gameObject.name == "Paddle")
			{
			    Vector3 directionToBall = transform.position - collision.gameObject.transform.position;
				float ballSpeed = 10.0f;
			    
			    Vector3 newBallVelocity = directionToBall.normalized * ballSpeed;
     			newBallVelocity.x *= 20;
				m_rb.velocity = newBallVelocity;
			}
		}
}
