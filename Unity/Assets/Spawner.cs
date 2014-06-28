using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public Transform brick;
	// Use this for initialization
	void Start () {
		Spawn ();
		//InvokeRepeating("Spawn", 5f, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn() {
		for (int y = 0; y < 25; y+=2) {
			for (int x = -10; x < 25; x+=2) {
				Instantiate(brick, new Vector3(x, y, 0), Quaternion.identity);
			}
		}
	}
}
