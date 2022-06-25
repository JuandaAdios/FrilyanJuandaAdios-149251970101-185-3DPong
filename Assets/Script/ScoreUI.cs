using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public int scorePlayer1;
	public int scorePlayer2;
    public int scorePlayer3;
    public int scorePlayer4;

	public GUIStyle style;


	public int winningScore = 5;

	void OnGUI()
	{

		float x = Screen.width/2f;
		float y = 30f;
		float width = 300f;
		float height = 20f;
		string text =  scorePlayer1 + " / " + scorePlayer2 + " / " + scorePlayer3 + " /" + scorePlayer4;
		

		GUI.Label(new Rect(x-(width/100f), y, width, height), text, style);


		if (scorePlayer1 >= winningScore || scorePlayer2 >= winningScore || scorePlayer3 >= winningScore || scorePlayer4 >= winningScore)
		{

			GameObject ball = GameObject.Find("Ball");
			if (ball != null)
			{
				ball.SetActive(false);
			}


			string winMessage = "Player 2 Lose";
			if (scorePlayer1 <= winningScore)
			{
				if (scorePlayer3 >= scorePlayer1 || scorePlayer3 >= scorePlayer2 || scorePlayer3 >= scorePlayer4)
			{
				winMessage = "Player 3 won";
			}
				if (scorePlayer4 >= scorePlayer1 || scorePlayer4 >= scorePlayer2 || scorePlayer4 >= scorePlayer3)
				{
					winMessage = "Player 4 won";
				}
				
				
				winMessage = "Player 1 won";
			} 
			
			

            //string winMessage2 = "Player 4 Lose";
			//if (scorePlayer3 <= winningScore)
			//{
			//	winMessage2 = "Player 3 won";
			//}

			GameObject Border = GameObject.Find("Border2");
			if (Border != null)
			{
				Border.SetActive(true);
				Debug.Log("salah");
			}

			y = Screen.height/2f;
			GUI.Label(new Rect(x-(width/2f), y+(height/2f), width, height), winMessage, style);
		}

	}
}
