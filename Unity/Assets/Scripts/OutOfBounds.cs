using UnityEngine;
using System.Collections;

public class OutOfBounds : MonoBehaviour {

	public int m_LevelBallDestroyLimit;
	private int m_numberBallsDestroyed;
	public GUIText BallsRemainingText;

	// Use this for initialization
	void Start () {
		m_numberBallsDestroyed = 0;
		m_LevelBallDestroyLimit = Brick.brickCount + 1;
		BallsRemainingText.text ="x " + m_LevelBallDestroyLimit + "/" + m_LevelBallDestroyLimit;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D( Collision2D collision )
	{
		if( collision.gameObject.CompareTag("Ball") )
		{
			Destroy( collision.gameObject );
			m_numberBallsDestroyed++;

			BallsRemainingText.text = "x " + ( m_LevelBallDestroyLimit - m_numberBallsDestroyed ) + "/" + m_LevelBallDestroyLimit;

			if( m_LevelBallDestroyLimit - m_numberBallsDestroyed <= 0 )
			{
				GameOver();
			}
			


		}
	}

	public void resetBrickCount ()
	{
		Start ();
	}

	void GameOver()
	{
		//TODO
	}
}
