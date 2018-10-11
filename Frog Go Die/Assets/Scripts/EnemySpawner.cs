using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour {

	public static EnemySpawner instance = null;

	public GameObject car;
	public GameObject snake;
	GameObject temp;

	void Start(){
		Scene currentScene = SceneManager.GetActiveScene();
		int buildIndex = currentScene.buildIndex;

		switch(buildIndex){
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
}
