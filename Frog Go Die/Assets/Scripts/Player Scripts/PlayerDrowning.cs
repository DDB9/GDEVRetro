using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerDrowning : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		SceneManager.LoadScene("GameOverLake");
	}

}
