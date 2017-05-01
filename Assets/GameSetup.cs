using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour {

	public Camera mainCam; //may need to change to public
	public BoxCollider2D bottomWall;
	public BoxCollider2D topWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;

	public Transform Player01;
	public Transform Player02;
	// Use this for initialization
	void Start () {

		//we need to make the top wall the width of the screen (technically the box collider)
		topWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width *2f, 0f, 0f)).x,1f); //cant use screen.width as that is measured in pixels
		//now we need to make the height of the collider on the screen
		topWall.offset = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f,Screen.height,0f)).y + 0.5f);

		//do the same for the rest of the walls:
		bottomWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width *2f, 0f, 0f)).x,1f);
		bottomWall.offset = new Vector2(0f, mainCam.ScreenToWorldPoint (new Vector3(0f,0f,0f)).y - 0.5f); 

		leftWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f,Screen.height *2f, 0f)).y);
		leftWall.offset = new Vector2(mainCam.ScreenToWorldPoint (new Vector3(0f,0f,0f)).x - 0.5f, 0f);

		rightWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f,Screen.height *2f, 0f)).y);
		rightWall.offset = new Vector2(mainCam.ScreenToWorldPoint (new Vector3(Screen.width,0f,0f)).x + 0.5f, 0f);

		//the positions of the players relative to the size of the screen
		//needs to be fixed
		//Player01.position.x = mainCam.ScreenToWorldPoint (new Vector3 (75f, 0f, 0f)).x;
		//Player02.position.x = mainCam.ScreenToWorldPoint (new Vector3 (Screen.width -75f, 0f, 0f)).x;

	}
	
	// Update is called once per frame
	void Update () {
		
	


	}
}
