using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player"){
			SceneManager.LoadScene(Random.Range(1, 3));
		} else return;
	}
}
