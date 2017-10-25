﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public bool levelOneBtn;
	public bool levelTwoBtn;
	public bool levelThreeBtn;
	public bool scoresBtn;
	public bool quitBtn;
	void OnMouseUp(){
		if (levelOneBtn) {
			SceneManager.LoadScene("Level1", LoadSceneMode.Single);
			GetComponent<Renderer>().material.color = Color.cyan;
		}
		if (levelTwoBtn) {
			SceneManager.LoadScene(2);
			GetComponent<Renderer>().material.color = Color.cyan;
		}
		if (levelThreeBtn) {
			SceneManager.LoadScene(3);
			GetComponent<Renderer>().material.color = Color.cyan;
		}
		if (scoresBtn) {
			SceneManager.LoadScene(4);
			GetComponent<Renderer>().material.color = Color.cyan;
		}
	}
		
}
