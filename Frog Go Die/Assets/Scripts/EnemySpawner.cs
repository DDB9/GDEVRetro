using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public List<Sprite> cars = new List<Sprite>();

	public GameObject car;

	void Start(){
		StartCoroutine("carSpawner");
	}
	
	private IEnumerator carSpawner(){
		Instantiate(car, transform.position, transform.rotation);
		yield return new WaitForSeconds(2);
	}
}
