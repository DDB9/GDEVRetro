using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine;


public class MenuScript : MonoBehaviour {

	public AudioMixer master;

	public void PlayGame(){
		SceneManager.LoadScene(Random.Range(1, 3));		// Loads a random (playable) scene for the player to start te game.
	}

	public void QuitGame(){
		Application.Quit();								// Exit's the aplication.
		Debug.Log("Quit!");
	}

	public void FullScreen(){
		Screen.fullScreen = !Screen.fullScreen; 		// Toggles fullscreen
	}

	public void SetVolume(float volume){
		master.SetFloat("Volume", volume);  			// Changes the master Audio mixer's value based on the sliders value.
	}
}
