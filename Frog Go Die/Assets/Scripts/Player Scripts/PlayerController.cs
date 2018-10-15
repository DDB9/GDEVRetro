using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public static PlayerController playerReference;
	
	public Rigidbody2D player;
	public AudioSource walk;
	
	void Awake(){
		playerReference = this;
	}

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

		// --- RRESTRICT MOVEMENT ---
		if (transform.position.x <= -4f) {									// X-Axis
			transform.position = new Vector2(-4f, transform.position.y);
		} else if (transform.position.x >= 4.3f) {
			transform.position = new Vector2(4.3f, transform.position.y);
		}
			
		if (transform.position.y <= -3.94f) {								// Y-Axis
			transform.position = new Vector3(transform.position.x, -3.94f, -2f);
		} else if (transform.position.y >= 1.55f) {
			transform.position = new Vector3(transform.position.x, 1.5f, -2f);
		}
	}
}
