using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public Transform brick;

	public int [,] Level1 = 
	{
		{0,0,1,1,1,1,0,0},
		{0,0,1,1,1,1,0,0},
		{0,0,1,1,1,1,0,0},
		{0,0,1,1,1,1,0,0},
	};
	// Use this for initialization
	void Start () {
		Spawn ();
		//InvokeRepeating("Spawn", 5f, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn() {
		foreach (var layer in Level1) 
		{

		}
	}
}
