using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Car : MonoBehaviour {

	public GameObject target;

	public Rigidbody2D rigBod;

	public float minSpeed = 1;
	public float maxSpeed = 5;

	private float speed;

    public float rotationSpeed = 5;

	void Start(){
		speed = Random.Range(minSpeed, maxSpeed);
	}

	void FixedUpdate(){
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);

		rigBod.MovePosition(rigBod.position + forward * Time.fixedDeltaTime * speed);
	}

	void OnTriggerEnter2D(Collider2D other){
         transform.rotation = Quaternion.Slerp(transform.rotation, 
		 									   Quaternion.LookRotation(other.transform.position - transform.position), 
		 									   rotationSpeed * Time.deltaTime);
	}
}
