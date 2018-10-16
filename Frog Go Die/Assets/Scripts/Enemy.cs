using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public static Enemy instance = null;

	public Rigidbody2D rigBod;

	public float minSpeed = 1;
	public float maxSpeed = 5;

	public float speed;

	// Target GameObject (player)
	// public retreatDistance (Perhaps a collider could make this unnecessary)

	// Use this for initialization
	void Start () {
		rigBod = GetComponent<Rigidbody2D>();

		speed = Random.Range(minSpeed, maxSpeed);
	}
	
	// FixedUpdate is called once per frame.
	public virtual void Move () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);

		rigBod.MovePosition(rigBod.position + forward * Time.fixedDeltaTime * speed);
		
	}
}
