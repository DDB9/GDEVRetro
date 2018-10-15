using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : Enemy {

	// Use this for initialization
	void Start () {
		speed = Random.Range(minSpeed, maxSpeed); // Why do I have to create this part for the snake, but not for the car?

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		Vector2 forward = new Vector2(transform.right.x, transform.right.y); // Also this part.

		rigBod.MovePosition(rigBod.position + forward * Time.fixedDeltaTime * speed); // And this.
	}
}
