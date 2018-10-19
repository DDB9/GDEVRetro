using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	void Update(){	
		for (int i = 0; i < EnemySpawner.spawnList.Count; i++){		// Moves all the enmies in the EnemySpawner spawnList.
			Enemy temp = EnemySpawner.spawnList[i];
			if (temp != null){										//...Unless they're null of course.
				temp.Move();
			}
		}
	}

	IEnumerator OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player"){
			yield return new WaitForSeconds(0.1f);
			Score.score++;						
			SceneManager.LoadScene(Random.Range(1, 4));				// Load one of the 3 level scenes.
		}
	}
}
