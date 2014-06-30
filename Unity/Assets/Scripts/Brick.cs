using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Transform ball;
	public Sprite[] sprites;
	public Color[] colors;
	private bool isQuitting = false;
	public static int brickCount = 0;

	void Awake() 
	{
		var renderer = this.GetComponent<SpriteRenderer>();
		//renderer.material.color = new Color (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f));
		renderer.sprite = sprites[Random.Range(0, 3)];
		brickCount += 1;
	}

	// Use this for initialization
	void Start () {
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
			Instantiate(ball, new Vector3(this.transform.position.x, this.transform.position.y, 0), Quaternion.identity);
			brickCount -= 1;
		}
	}

}
