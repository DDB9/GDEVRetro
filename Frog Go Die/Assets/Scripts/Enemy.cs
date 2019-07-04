using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour {

	public Rigidbody2D rigBod;

	public float minSpeed;
	public float maxSpeed;

	public float speed;

    public abstract void SetSpeed();
	
}
