using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LogManager : MonoBehaviour {

	IEnumerator OnTriggerStay2D(Collider2D other){
		if (other.tag == "WaterTile"){
			other.enabled = false;
			yield return new WaitForSeconds(1f);
			other.enabled = true;
		}
	}
}