using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SnakeVenom : MonoBehaviour {

	private float moveSpeed = 5f;	
	private Rigidbody2D rigBod;
	private GameObject target;
	private Vector2 moveDirection;

    bool ranOnce;
	
	public void OnEnable(){
        ranOnce = false;
		rigBod = GetComponent<Rigidbody2D>();
		target = GameObject.FindGameObjectWithTag("Player");
	}

    private void Update() {
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        if (!ranOnce) {
            rigBod.velocity = new Vector2(moveDirection.x, moveDirection.y);
            ranOnce = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Player"){
			SceneManager.LoadScene("GameOverVenom");
		}
	}
}
