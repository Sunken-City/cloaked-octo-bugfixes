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

	public string[] winComments = 
	{
		"You did it.",
		"Fantastic effort.",
		"Wow.",
		"What a show.",
		"Good job.",
		"You are talented.",
		"Excellent work.",
		"You are strong.",
		"I'm proud of you."
	};
	// Use this for initialization
	void Start () {
		getSnark ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void getSnark() 
	{
		if(positiveSnark)
		{
			this.GetComponent<GUIText>().text = winComments[Random.Range(0, winComments.Length)];
		}
		else
		{
			this.GetComponent<GUIText>().text = loseComments[Random.Range(0, loseComments.Length)];
		}	
	}
}
