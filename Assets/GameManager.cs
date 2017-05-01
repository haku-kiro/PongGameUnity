using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	static int playerScore1 = 0;
	static int playerScore2 = 0;
	public GUISkin theSkin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void Score(string wallName){
		if (wallName == "rightWall") {
			playerScore1 += 1;
		} else {
			playerScore2 += 1;
		}
		Debug.Log ("Player 1's score: " + playerScore1);
		Debug.Log ("Player 2's score: " + playerScore2);
	}
		

	void OnGUI()
	{
		GUI.skin = theSkin;
		GUI.Label (new Rect (Screen.width / 2 - 150-12, Screen.height/2, 100, 100), playerScore1.ToString());
		GUI.Label (new Rect (Screen.width / 2 + 150-12, Screen.height/2, 100, 100), playerScore2.ToString());
		GUI.Label (new Rect (Screen.width / 2 -50, Screen.height-150f, 180, 100), "Rally Count: " + BallControl.rallyCount);
	}
}
