using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public Transform brick;


	public int [][] Level1 = 
	{
		new int[] {0,0,1,1,1,1,1,0,0},
		new int[] {0,0,1,1,1,1,1,0,0},
		new int[] {0,0,1,1,1,1,1,0,0},
		new int[] {0,0,1,1,1,1,1,0,0},
	};
	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn() 
	{
		float y = 3f;
		foreach (var layer in Level1) 
		{
			float x = -12f;
			foreach (int position in layer) 
			{
				if(position == 1)
				{
						Instantiate(brick, new Vector3(x, y, 0f), Quaternion.identity);
				}
				x += 3f;
			}
			y += 0.8f;
		}
	}
}
