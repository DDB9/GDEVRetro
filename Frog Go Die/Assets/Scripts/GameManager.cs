using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager gmInstance;

    public Transform playerSpawn;

    private void Awake() {
        if (gmInstance == null) {
            DontDestroyOnLoad(gameObject);
            gmInstance = this;
        }
        else if (gmInstance != this) {
            Destroy(gameObject);
        }
    }

    void Update(){	
		for (int i = 0; i < EnemySpawner.spawnList.Count; i++){		// Moves all the enmies in the EnemySpawner spawnList.
			Enemy temp = EnemySpawner.spawnList[i];
			if (temp != null){										//...Unless they're null of course.
				temp.Move();
			}
		}

        // If any of the GameOver Scenes are currently the active scene
        if (SceneManager.GetActiveScene().name == "GameOverCar" || SceneManager.GetActiveScene().name == "GameOverCroc" || 
            SceneManager.GetActiveScene().name == "GameOverCroclog" || SceneManager.GetActiveScene().name == "GameOverLake" || 
            SceneManager.GetActiveScene().name == "GameOverSnake" || SceneManager.GetActiveScene().name == "GameOverVenom") {

            // Destroy the PlayerController instance.
            if (PlayerController.playerInstance != null) {
                Destroy(PlayerController.playerInstance.gameObject);
            }
        }
	}

	IEnumerator OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player"){
			yield return new WaitForSeconds(0.1f);
			Score.score++;						
			SceneManager.LoadScene(Random.Range(1, 4));				// Load one of the 3 level scenes.
            PlayerController.playerInstance.transform.position = playerSpawn.position;
		}
	}
}
