using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour {

	public static void DeathBy(Enemy enemy){
		if (enemy.tag == "Car"){
			SceneManager.LoadScene(2);
		}
	}
}
