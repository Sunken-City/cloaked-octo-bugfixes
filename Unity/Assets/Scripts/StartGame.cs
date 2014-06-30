using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public static string[] scenes = {
		"Title",
		"TestScene1",
		"GoodJob",
		"GameOgre",
		"YouWin",
	};

	public int sceneNumber;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		Application.LoadLevel (scenes[sceneNumber]);
	}

	void OnMouseOver()
	{
		this.GetComponent<GUIText>().fontSize = 70;
	}

	void OnMouseExit()
	{
		this.GetComponent<GUIText>().fontSize = 60;
	}
}
