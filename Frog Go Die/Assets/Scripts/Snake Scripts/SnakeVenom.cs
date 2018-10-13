using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SnakeVenom : MonoBehaviour {

	private float moveSpeed = 5f;	
	private Rigidbody2D rigBod;
	private GameObject target;
	private Vector2 moveDirection;
	
	void Start(){
		rigBod = GetComponent<Rigidbody2D>();
		target = GameObject.FindGameObjectWithTag("Player");
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
		rigBod.velocity = new Vector2(moveDirection.x, moveDirection.y);
		Destroy(gameObject, 3f);
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Player"){
			SceneManager.LoadScene("GameOverSnake");
		}
	}


}
