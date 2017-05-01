using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		if (hitInfo.name == "Ball") {
			var wallName = transform.name;
			GameManager.Score (wallName);
			hitInfo.gameObject.SendMessage ("ResetBall");
			//we also want to reset the rally count when the ball goes out
			BallControl.rallyCount = 0;
		}
	}
}
