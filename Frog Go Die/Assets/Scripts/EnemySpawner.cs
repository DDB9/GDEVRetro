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
				StartCoroutine(CarSpawner());
				break;

			case 2:
				StartCoroutine(SnakeSpawner());
				break;
			
			case 3:
				// StartCoroutine(CrocLogSpawner());
				break;
		}
	}
	
	private IEnumerator CarSpawner(){
		while (true){
			temp = Instantiate(car, transform.position, transform.rotation);
			yield return new WaitForSeconds(1f);
			Destroy(temp, 2);
		}
	}

	private IEnumerator SnakeSpawner(){
		while (true){
			temp = Instantiate(snake, transform.position, transform.rotation);
			yield return new WaitForSeconds(1f);
			Destroy(temp, 2);
		}
	}

	private IEnumerator CrocLogSpawner(){											// Spawns Logs and Crocodiles at random.
		int crocOrLog = Random.Range(1, 2);											// Wether a croc or a log is being spawned is chosen randomly.

		if (crocOrLog == 1){														// Spawns a croc.
			while (true){
				temp = Instantiate(croc, transform.position, transform.rotation);
				yield return new WaitForSeconds(1f);
				Destroy(temp, 1f);
			}
		}
		if (crocOrLog == 2){														// Spawns on log.
			while (true){
				temp = Instantiate(log, transform.position, transform.rotation);
				yield return new WaitForSeconds(1f);
				Destroy(temp, 1f);
			}
		}
	}
}
