using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour {

	public static EnemySpawner instance = null;

	public GameObject car, snake, croc, log;

	private GameObject temp;					// Temporary gameobject because Unity doesnt allow destruction of assets (and neither do I).

	void Start(){
		Scene currentScene = SceneManager.GetActiveScene();
		int buildIndex = currentScene.buildIndex;

		switch(buildIndex){								// This spawns enemies depending on the current scene's index.
			case 1:
				StartCoroutine(CarSpawner());			// Spawns cars if the current scene is the "road" level.
				break;

			case 2:
				StartCoroutine(SnakeSpawner());			// Spawns snakes if the current scene is the "forest" level.
				break;
			
			case 3:
				// StartCoroutine(CrocLogSpawner());	// Spawns crocodiles and logs if the current scene is the "lake" level.
				break;
		}
	}
	
	private IEnumerator CarSpawner(){													// --- CARS ---
		while (true){
			temp = Instantiate(car, transform.position, transform.rotation);
			yield return new WaitForSeconds(1f);										// Every second a new car is spawned...
			Destroy(temp, 2);															// ...and destroyed after 2 seconds.
		}
	}

	private IEnumerator SnakeSpawner(){													// --- SNAKES --- 
		while (true){
			temp = Instantiate(snake, transform.position, transform.rotation);
			yield return new WaitForSeconds(5f);										// Every 5 seconds a new snake is spawned (because they move slower and fire projectiles)...
			Destroy(temp, 6);															// ...and destroyed after 6 seconds.
		}
	}

	private IEnumerator CrocLogSpawner(){												// --- CROCS 'N LOGS ---
		while (true){
			int crocOrLog = Random.Range(1, 2);											// Wether a croc or a log is being spawned is chosen randomly.

			if (crocOrLog == 1){														// Spawns a croc...
				temp = Instantiate(croc, transform.position, transform.rotation);
				yield return new WaitForSeconds(1f);
				Destroy(temp, 1f);

			}
			else if (crocOrLog == 2){													// ...or a log.
				temp = Instantiate(log, transform.position, transform.rotation);
				yield return new WaitForSeconds(1f);
				Destroy(temp, 1f);
			}
		}
	}
}
