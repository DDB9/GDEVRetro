using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour {

	public static PlayerDeath instance = null;

	public static void playerDeath(Enemy enemy){
		if (enemy.tag == "Car"){
			SceneManager.LoadScene(2);
		}
	}
}
