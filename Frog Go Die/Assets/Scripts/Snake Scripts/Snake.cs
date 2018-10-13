using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : Enemy {

	[SerializeField]
	public GameObject venom;

	private float fireRate;
	private float nextFire;

	// Use this for initialization
	void Start () {
		speed = Random.Range(minSpeed, maxSpeed); // Why do I have to create this part for the snake, but not for the car?

		fireRate = 1f;
		nextFire = Time.time;
	}

	void Update(){
		CheckFireStatus();
	}

	void CheckFireStatus(){
		if (Time.time > nextFire){
			Instantiate(venom, transform.position, Quaternion.identity);
			nextFire = Time.time + fireRate;
		}
	}

	void FixedUpdate(){
		Vector2 forward = new Vector2(transform.right.x, transform.right.y); // Also this part.

		rigBod.MovePosition(rigBod.position + forward * Time.fixedDeltaTime * speed); // And this.
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player"){
			PlayerDeath.DeathBy(this);
		} else if (other.tag == "Snake") return;
	}
}
