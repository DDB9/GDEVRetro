using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : Enemy {
    
    void OnTriggerStay2D(Collider2D other){
        if (other.tag == "Player"){
            other.transform.parent = this.transform;
        }
    }
}
