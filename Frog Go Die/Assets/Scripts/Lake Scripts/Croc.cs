using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Croc : Enemy {

    private void OnEnable() {
        SetSpeed();
    }

    IEnumerator OnTriggerStay2D(Collider2D other){
		if (other.tag == "WaterTile"){
			other.enabled = false;
			yield return new WaitForSeconds(1f);
			other.enabled = true;
		} 
		if (other.tag == "Player"){
			PlayerDeath.DeathBy(this);
		}
	}
}
