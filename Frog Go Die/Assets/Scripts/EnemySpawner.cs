using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	void Start(){
		StartCoroutine("carSpawner");
	}
	
	private IEnumerator carSpawner(){
		while (true){
			Instantiate(GameManager.car, transform.position, transform.rotation);
			yield return new WaitForSeconds(1.5f);
		}
	}
}
