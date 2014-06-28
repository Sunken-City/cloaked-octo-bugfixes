using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name == "Ball")
		{
			Destroy( this );
		}
	}

	void OnTriggerEnter2D( Collider2D other )
	{
		Destroy (other.gameObject);
		Debug.Log (" ASDFASD ASDFASDF ASDF ");
	}
}
