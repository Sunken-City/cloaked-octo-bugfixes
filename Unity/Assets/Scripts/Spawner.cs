using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public Transform brick;
	public AudioClip[] songs;
	public int Level = 0;
	public OutOfBounds BallDestroyer;
	private static bool brickCountReady = false;

	public int[][][] Levels =
	{
		//Level 0
		new int[][]
		{
			new int[] {0,0,0,0,1,0,0,0,0},
			new int[] {0,0,0,0,0,0,0,0,0},
			new int[] {0,0,1,0,0,0,1,0,0},
			new int[] {0,0,0,0,0,0,0,0,0},
		},
		//Level 1
		new int[][]
		{
			new int[] {0,0,0,0,0,0,0,0,0},
			new int[] {0,0,1,0,1,0,1,0,0},
			new int[] {0,0,0,1,0,1,0,0,0},
			new int[] {0,0,0,0,0,0,0,0,0},
		},
		//Level 2
		new int[][]
		{
			new int[] {0,0,0,1,1,1,0,0,0},
			new int[] {0,0,0,1,1,1,0,0,0},
			new int[] {0,0,0,0,1,0,0,0,0},
			new int[] {0,0,0,0,0,0,0,0,0},
		},
		//Level 3
		new int[][]
		{
			new int[] {0,1,0,0,0,0,0,1,0},
			new int[] {0,0,0,1,1,1,0,0,0},
			new int[] {0,0,0,1,1,1,0,0,0},
			new int[] {0,1,0,0,0,0,0,1,0},
		},
		//Level 4
		new int[][]
		{
			new int[] {0,1,1,0,0,0,1,1,0},
			new int[] {0,1,1,0,0,0,1,1,0},
			new int[] {0,1,1,0,0,0,1,1,0},
			new int[] {0,1,1,0,0,0,1,1,0},
		},
		//Level 5
		new int[][]
		{
			new int[] {0,0,0,0,0,0,0,0,0},
			new int[] {0,0,1,1,1,1,1,0,0},
			new int[] {0,0,1,1,1,1,1,0,0},
			new int[] {0,0,1,1,1,1,1,0,0},
		},
		//Level 6
		new int[][]
		{
			new int[] {0,1,1,1,1,1,1,1,0},
			new int[] {0,1,1,1,1,1,1,1,0},
			new int[] {0,1,1,1,1,1,1,1,0},
			new int[] {0,1,1,1,1,1,1,1,0},
		},
	};

	// Use this for initialization
	void Start () {
		Spawn (Level);
	}
	
	// Update is called once per frame
	void Update () {
		if (Brick.brickCount == 0) 
		{
			Level++;
			Spawn (Level);
		}
	}

	public static int getBrickCount()
	{
		if(brickCountReady)
		{
			brickCountReady = false;
			return Brick.brickCount;
		}
		return 0;
	}

	void Spawn(int levelNumber) 
	{
		this.GetComponent<AudioSource>().clip = songs [levelNumber];
		this.GetComponent<AudioSource>().Play ();
		float y = 3f;
		foreach (var layer in Levels[levelNumber]) 
		{
			float x = -12f;
			foreach (int position in layer) 
			{
				if(position == 1)
				{
					var block = Instantiate(brick, new Vector3(x, y, 0f), Quaternion.identity);
				}
				x += 3f;
			}
			y += 0.8f;
		}
		
		if( BallDestroyer )
		{
			BallDestroyer.resetBrickCount();
		}
		brickCountReady = true;
	}
}
