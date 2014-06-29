using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Transform ball;
	private bool isQuitting = false;
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
			Instantiate(ball, new Vector3(this.transform.position.x, this.transform.position.y, 0), Quaternion.identity);
	}

}
