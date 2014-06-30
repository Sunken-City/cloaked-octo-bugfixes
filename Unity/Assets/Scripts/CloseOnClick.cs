using UnityEngine;
using System.Collections;

public class CloseOnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	
	void OnMouseDown()
	{
		Spawner theSpawner = FindObjectOfType (typeof(Spawner)) as Spawner;
		//theSpawner.nextLevel ();
		Destroy ( this );
	}
}
