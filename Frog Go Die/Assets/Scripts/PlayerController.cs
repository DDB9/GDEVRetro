using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody2D player;
	public AudioSource walk;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			player.MovePosition(player.position + Vector2.up); 		// Moves the player 1 "unit" forward.
			walk.Play();
		}		
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			player.MovePosition(player.position + Vector2.down); 	// Moves the player 1 "unit" backwards.
			walk.Play();
		}		
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			player.MovePosition(player.position + Vector2.left); 	// Moves the player 1 "unit" to the left.
			walk.Play();
		}		
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			player.MovePosition(player.position + Vector2.right); 	// Moves the player 1 "unit" to the right.
			walk.Play();
		}		
	}
}
