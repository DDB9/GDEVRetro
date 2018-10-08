using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	public static GameObject car;

	// Use this for initialization
	void Start () {
		car = Resources.Load("Car_Red") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}