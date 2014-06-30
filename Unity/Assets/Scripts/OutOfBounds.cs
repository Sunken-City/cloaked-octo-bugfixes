using UnityEngine;
using System.Collections;

public class OutOfBounds : MonoBehaviour {

	public int m_LevelBallDestroyLimit;
	private int m_numberBallsDestroyed;
	public GUIText BallsRemainingText;
	public static int BallsInPlay;

	// Use this for initialization
	void Start () {
		m_numberBallsDestroyed = 0;
		m_LevelBallDestroyLimit = Brick.brickCount + 1;
		BallsRemainingText.text ="x " + m_LevelBallDestroyLimit + "/" + m_LevelBallDestroyLimit;
		OutOfBounds.BallsInPlay = 1;
	}
	
	// Update is called once per frame
	void Update () {
		int count = Spawner.getBrickCount();
		if (count != 0) 
		{
			m_LevelBallDestroyLimit = count + 1;
			m_numberBallsDestroyed = 0;
			BallsRemainingText.text = "x " + (m_LevelBallDestroyLimit - m_numberBallsDestroyed) + "/" + m_LevelBallDestroyLimit;
		}
	}

	void OnCollisionEnter2D( Collision2D collision )
	{
		if( collision.gameObject.CompareTag("Ball") )
		{
			Destroy( collision.gameObject );
			m_numberBallsDestroyed++;

			BallsRemainingText.text = "x " + ( m_LevelBallDestroyLimit - m_numberBallsDestroyed ) + "/" + m_LevelBallDestroyLimit;



			OutOfBounds.BallsInPlay--;
			if( OutOfBounds.BallsInPlay == 0 )
			{
				GameOver();
			}

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
		Application.LoadLevel (StartGame.scenes[3]);
	}
}
