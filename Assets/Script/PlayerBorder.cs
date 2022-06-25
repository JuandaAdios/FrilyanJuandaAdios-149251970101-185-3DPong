using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBorder : MonoBehaviour
{
 
	public ePlayer player;

	public ScoreUI score;

	public int wait = 15;
	

	void OnCollisionEnter(Collision col)
	{

		BallController ball = col.gameObject.GetComponent<BallController>();

		if (ball != null)		
		{
			ball.transform.position = new Vector3(-4.34f, 0.39f, -3.99f);


			//StartCoroutine(waitTime());

			
			// Player Score
			if (player == ePlayer.PlayerOne) score.scorePlayer1++;
			else if (player == ePlayer.PlayerTwo) score.scorePlayer2++;
            else if (player == ePlayer.PlayerThree) score.scorePlayer3++;
            else if (player == ePlayer.PlayerFour) score.scorePlayer4++;
		}
	}

	//private IEnumerator waitTime()
	//{
	//	yield return new WaitForSeconds(wait);
		
		

	//}

	

}
