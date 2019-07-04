using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public Rigidbody2D rigBod;

	public float minSpeed;
	public float maxSpeed;

	public float speed;

    private void Start() {
        minSpeed = 1.5f;
        maxSpeed = 5;
    }

    public virtual void Update() {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);

        rigBod.MovePosition(rigBod.position + forward * Time.fixedDeltaTime * speed);
    }

    // SetSpeed sets the speed variable and assigns the object's rigidbody to the rigBod variable.
    public void SetSpeed () {
        rigBod = GetComponent<Rigidbody2D>();
        
        if (gameObject.GetComponent<Snake>()) {
            maxSpeed = 3;
        }

        speed = Random.Range(minSpeed, maxSpeed);
    }
	
}
