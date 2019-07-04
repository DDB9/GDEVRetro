using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Snake : Enemy {

    public GameObject venom;
	public AudioSource snakeShoot;

	private float fireRate;
	private float nextFire;

	// Use this for initialization
	public void OnEnable () {
        minSpeed = 1.5f;
        maxSpeed = 5;
        fireRate = 1;
		nextFire = Time.time;
        SetSpeed();
	}

    public void Update() {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rigBod.MovePosition(rigBod.position + forward * Time.fixedDeltaTime * speed);   // Moves the enemy forward.

        CheckFireStatus();  // checks if the enemy can fire.
    }

    public override void SetSpeed() {
        rigBod = GetComponent<Rigidbody2D>();

        if (gameObject.GetComponent<Snake>()) {
            maxSpeed = 3;
        }

        speed = Random.Range(minSpeed, maxSpeed);
    }

    void CheckFireStatus(){
		if (Time.time > nextFire){
			snakeShoot.Play();
            ObjectPooler.instance.spawnFromPool("Venom", transform.position, Quaternion.identity);
            //Instantiate(venom, transform.position, transform.rotation);
			nextFire = Time.time + fireRate;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player"){
			PlayerDeath.DeathBy(this);
		} else if (other.tag == "Snake") return;
	}
}
