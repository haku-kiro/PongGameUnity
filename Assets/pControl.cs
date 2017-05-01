using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pControl : MonoBehaviour {

	public GameObject player;
	public KeyCode moveUp = KeyCode.W;
	public KeyCode moveDown = KeyCode.S;
	public float speed = 10f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(moveUp)) 
		{
			player.GetComponent<Rigidbody2D> ().velocity = new Vector3 (0,speed,0); 
			//Debug.Log ("You are attempting to move up.");
		} 
		else if (Input.GetKey(moveDown)) 
		{
			player.GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, speed *-1, 0);
			//Debug.Log ("You are attempting to move down.");
		} 
		else 
		{
			player.GetComponent<Rigidbody2D> ().velocity = new Vector3 (0,0,0);
			//Debug.Log ("You have let go of a control, or have not pressed anything.");
		}
	}
}
