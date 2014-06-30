using UnityEngine;
using System.Collections;

public class Snark : MonoBehaviour {

	public bool positiveSnark;

	public string[] loseComments = 
	{
		"You tried so hard.",
		"This attempt is over.",
		"Keep at it.",
		"Don't give up.",
		"You are beautiful.",
		"Please don't cry.",
		"You did your best.",
		"You are my rose.",
		"Don't do that again."
	};
	// Use this for initialization
	void Start () {
		if(positiveSnark)
		{

		}
		else
		{
			this.GetComponent<GUIText>().text = loseComments[Random.Range(0, loseComments.Length)];
		}	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
