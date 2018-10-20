using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Snake : Enemy {

	[SerializeField]
	public GameObject venom;
	public AudioSource snakeShoot;

	private float fireRate;
	private float nextFire;

	// Use this for initialization
	void Start () {
		fireRate = 0.75f;
		nextFire = Time.time;
	}

	void Update(){
		CheckFireStatus();
	}

	void CheckFireStatus(){
		if (Time.time > nextFire){
			snakeShoot.Play();
			Instantiate(venom, transform.position, Quaternion.identity);
			nextFire = Time.time + fireRate;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player"){
			PlayerDeath.DeathBy(this);
		} else if (other.tag == "Snake") return;
	}
}
