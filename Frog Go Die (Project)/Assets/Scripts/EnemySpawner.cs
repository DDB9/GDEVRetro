using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour {

    ObjectPooler objectPooler;

    [SerializeField]
	private float spawnRate = 1f;

    void Start(){
        objectPooler = ObjectPooler.instance;

        Scene currentScene = SceneManager.GetActiveScene();
        int buildIndex = currentScene.buildIndex;

        switch (buildIndex) {
            case 1:
                StartCoroutine(CarSpawner());
                break;

            case 2:
                StartCoroutine(SnakeSpawner());         // Spawns snakes if the current scene is the "forest" level.
                break;

            case 3:
                StartCoroutine(CrocLogSpawner());       // Spawns crocodiles and logs if the current scene is the "lake" level.
                break;
        }
    }


    private IEnumerator CarSpawner() {                                                              // --- CARS ---
        while (true) {
            objectPooler.spawnFromPool("Car", transform.position, transform.rotation);              // Spawn the objects from the pool (set active).
            yield return new WaitForSeconds(spawnRate);                                             // Wait for user-specified delay before repeating.
        }
    }


	private IEnumerator SnakeSpawner(){														        // --- SNAKES --- 
		while (true){
            objectPooler.spawnFromPool("Snake", transform.position, transform.rotation);            // Spawn the objects from the pool (set active).
            yield return new WaitForSeconds(spawnRate);                                             // Wait for user-specified delay before repeating.
        }
	}


	private IEnumerator CrocLogSpawner(){															// --- CROCS 'N LOGS ---
		while (true){
			int crocOrLog = Random.Range(1, 21);                                                    // Wether a croc, a log or a crocLog is being spawned is chosen randomly. 
                                                                                                    // Crocs and Croclogs have less of a chance to spawn.

			if (crocOrLog > 0 && crocOrLog < 5){                                                    // Spawns a croc...
                objectPooler.spawnFromPool("Croc", transform.position, transform.rotation);         // Spawn the objects from the pool (set active).
            }
			else if (crocOrLog > 5 && crocOrLog < 18){												// ...or a log...
                objectPooler.spawnFromPool("Log", transform.position, transform.rotation);          // Spawn the objects from the pool (set active).
            }
			else if (crocOrLog > 18 && crocOrLog < 21){												// ...or a crocodile in disguise!
                objectPooler.spawnFromPool("Croclog", transform.position, transform.rotation);      // Spawn the objects from the pool (set active).
            }
			yield return new WaitForSeconds(spawnRate);                                             // Wait for user-specified delay before repeating.
		}
	}
}
