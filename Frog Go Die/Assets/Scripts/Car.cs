using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

	public Rigidbody2D rigBod;

	public float minSpeed = 1;
	public float maxSpeed = 5;

	public float speed;

	void Start(){
		speed = Random.Range(minSpeed, maxSpeed);
	}

	void FixedUpdate(){
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);

		rigBod.MovePosition(rigBod.position + forward * Time.fixedDeltaTime * speed);
	}
}
