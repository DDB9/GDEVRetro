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
		fireRate = 1;
		nextFire = Time.time;
        SetSpeed();
	}

    public override void Update() {
        base.Update();

        CheckFireStatus();
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
