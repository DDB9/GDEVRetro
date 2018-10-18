using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	public Croc croc;
	public Log log;
	public Car car;
	public Snake snake;

	void Start(){
		Scene currentScene = SceneManager.GetActiveScene();
		int buildIndex = currentScene.buildIndex;

		switch(buildIndex){					// This sets the enemy's speed.
			case 1:
				car.SetSpeed();				// SetSpeed for cars if the current scene is the "road" level.
				break;

			case 2:
				snake.SetSpeed();			// SetSpeed for snakes if the current scene is the "forest" level.
				break;
			
			case 3:
				croc.SetSpeed();			// SetSpeed for crocodiles and logs if the current scene is the "lake" level.
				log.SetSpeed();				
				break;
		}
	}

	void Update(){	
		Scene currentScene = SceneManager.GetActiveScene();
		int buildIndex = currentScene.buildIndex;

		switch(buildIndex){					// This moves the enemy
			case 1:
				car.Move();					// Move for cars if the current scene is the "road" level.
				break;

			case 2:
				snake.Move();				// Move for snakes if the current scene is the "forest" level.
				break;
			
			case 3:
				croc.Move();				// Move for crocodiles and logs if the current scene is the "lake" level.
				log.Move();				
				break;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player"){
			SceneManager.LoadScene(Random.Range(1, 3));
		} else return;
	}
}
