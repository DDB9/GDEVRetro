using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : Enemy {

    private void OnEnable() {
        minSpeed = 4f;
        maxSpeed = 4;
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

    IEnumerator OnTriggerStay2D(Collider2D other){
        if (other.tag == "Player"){
            other.transform.parent = this.transform;
        }
        if (other.tag == "WaterTile") {
            other.enabled = false;
            yield return new WaitForSeconds(1f);
            other.enabled = true;
        }
    }
}
