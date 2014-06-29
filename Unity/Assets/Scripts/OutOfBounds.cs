using UnityEngine;
using System.Collections;

public class OutOfBounds : MonoBehaviour {

	private int m_numberBallsDestroyed;

	// Use this for initialization
	void Start () {
		m_numberBallsDestroyed = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D( Collision2D collision )
	{
		if( collision.gameObject.CompareTag("Ball") )
		{
			Destroy( collision.gameObject );
			m_numberBallsDestroyed++;
		}
	}
}
