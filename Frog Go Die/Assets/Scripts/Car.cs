using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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

	void OnTriggerEnter(Collider other){
		transform.position = Vector2.MoveTowards(transform.position, other.transform.position, 5f);
	}
}
