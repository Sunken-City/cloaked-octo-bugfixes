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

		void OnCollisionEnter2D (Collision2D collision)
		{
			Debug.Log (" ASDFKAJSFLK ");
		}

	
	void OnTriggerEnter2D( Collider2D other )
	{
		Destroy (other.gameObject);
		Debug.Log (" ASDFKAJSFLK ");
	}
}
