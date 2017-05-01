using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

	public GameObject ball;
	public static int rallyCount = 0; //static? So it can be reset globally?

	public GUISkin theSkin;

	// Use this for initialization

	public float ballspeed = 100; 

	void Start () {
		StartCoroutine (GoBall ());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D colInfo)
	{
		if (colInfo.collider.tag == "Player1") {
			//if we collide with a padle we want to "transfer our velocity"
			//var velY = ball.GetComponent<Rigidbody2D>().velocity.y; //using this variable would make it static, we want it to update
			ball.GetComponent<Rigidbody2D> ().velocity = new Vector2 (15f, ball.GetComponent<Rigidbody2D>().velocity.y / 2 + colInfo.collider.GetComponent<Rigidbody2D> ().velocity.y / 3);
			rallyCount += 1;
		}
		else if (colInfo.collider.tag == "Player2") { 
			ball.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-15f, ball.GetComponent<Rigidbody2D>().velocity.y / 2 + colInfo.collider.GetComponent<Rigidbody2D> ().velocity.y / 3);
			rallyCount += 1;
		}
		//except, now - whenever the player hits the ball with the back of the paddle it goes backwards
	}
		
	IEnumerator GoBall() {
		yield return new WaitForSeconds (2); //wont work unless the return type is IEnumerator
		var randomNum = Random.Range (0, 2);
		if (randomNum <= 0.5) {
			Debug.Log ("shoot right");
			ball.GetComponent<Rigidbody2D> ().AddForce (new Vector2(ballspeed,10));
		} else {
			Debug.Log ("Shoot left");
			ball.GetComponent<Rigidbody2D> ().AddForce (new Vector2(-ballspeed,-10));
		}
			
	}

	IEnumerator ResetBall(){
		ball.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		//ball.GetComponent<Rigidbody2D> ().position = new Vector2(0,0);
		ball.transform.position = new Vector2(0,0);

		yield return new WaitForSeconds (0); //not needed as I use the waitforseconds method inside of the GoBall method

		StartCoroutine( GoBall ());

	}

}
