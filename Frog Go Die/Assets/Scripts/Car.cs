using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : Enemy {

	public Rigidbody2D rigBod;
	
	void Awake(){
		StartCoroutine(CarRot());
	}

	void FixedUpdate(){
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);

		rigBod.MovePosition(rigBod.position + forward * Time.fixedDeltaTime * speed);
	}

	private IEnumerator CarRot(){
		yield return new WaitForSeconds(0.25f);
		transform.Rotate(0f, 0f, Random.Range(-15f, 15f));
	}

	private void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player"){
			PlayerDeath.DeathBy(this);
		} else if (other.tag == "Car") transform.Rotate(0f, 0f, Random.Range(-30, 30));
	}
} 
