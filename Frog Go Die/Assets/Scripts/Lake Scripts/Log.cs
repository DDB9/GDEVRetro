using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : Enemy {

    private void OnEnable() {
        SetSpeed();
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
