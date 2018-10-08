using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour {

	public static void playerDeath(GameObject enemy){
		if (enemy.tag == "Car"){
			SceneManager.LoadScene(2);
		}
	}
}
