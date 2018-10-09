using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject car;
	GameObject temp;

	void Start(){
		StartCoroutine("carSpawner");
	}
	
	private IEnumerator carSpawner(){
		while (true){
			temp = Instantiate(car, transform.position, transform.rotation);
			yield return new WaitForSeconds(1.5f);
			Destroy(temp, 2);
		}
	}
}
