using UnityEngine;
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

		void OnCollisionEnter (Collision collision)
		{
			foreach (ContactPoint contact in collision.contacts) {
				if( m_rb ) {
					//m_rb.velocity = Vector3.Reflect( m_rb.velocity, contact.normal );
				}
			}
		}
}
