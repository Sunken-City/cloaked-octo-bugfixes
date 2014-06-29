using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		Application.LoadLevel ("TestScene1");
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
