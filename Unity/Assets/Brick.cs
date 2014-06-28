using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Ball")
		{
			Destroy( this );
		}
	}

	void OnTriggerEnter( Collider other )
	{
		Destroy (other.gameObject);
		Debug.Log (" ASDFASD ASDFASDF ASDF ");
	}
}
