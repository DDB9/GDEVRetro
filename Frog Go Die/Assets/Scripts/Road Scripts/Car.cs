using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Enemy {

    public void OnEnable() {
        minSpeed = 5f;
        maxSpeed = 7;
        StartCoroutine(CarRot());
        SetSpeed();
    }

    public void Update() {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rigBod.MovePosition(rigBod.position + forward * Time.fixedDeltaTime * speed);   // Moves the enemy forward.
    }

    public override void SetSpeed() {
        rigBod = GetComponent<Rigidbody2D>();

        if (gameObject.GetComponent<Snake>()) {
            maxSpeed = 3;
        }

        speed = Random.Range(minSpeed, maxSpeed);
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
