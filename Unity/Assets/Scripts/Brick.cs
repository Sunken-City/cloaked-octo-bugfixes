using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Transform ball;
	public Sprite[] sprites;
	private bool isQuitting = false;

	void Awake() 
	{

	}

	// Use this for initialization
	void Start () {
		var color = this.GetComponent<SpriteRenderer>();
		color.color = new Color(Random.Range(0, 256), Random.Range(0, 256), Random.Range(0, 256));
		color.sprite = sprites[Random.Range(0, 3)];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnApplicationQuit() 
	{ 
		isQuitting = true; 
	}
	void OnDestroy() {
		if (!isQuitting)
		{
		    GameObject newBall = Instantiate(ball, new Vector3(this.transform.position.x, this.transform.position.y, 0), Quaternion.identity) as GameObject;
			if( newBall )
			{
				newBall.layer = 8;
			}
		}
	}

}
