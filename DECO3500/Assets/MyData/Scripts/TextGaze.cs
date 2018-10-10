﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TextGaze : MonoBehaviour {

	public TextMesh text;
	private UIHandler uiHandler;

	private GameObject launchButton;
	public Material blackLaunchButton;

	void Start() {
		GameObject handlerObject = GameObject.Find("Canvas");
		uiHandler = handlerObject.GetComponent<UIHandler>();

		launchButton = GameObject.Find("LaunchButton");
	}

	/*Changes the console text colour when hovered over by reticle*/
	public void OnGazeEnter() {
		text.color = new Color(130.0f/255.0f, 130.0f/255.0f, 130.0f/255.0f, 1f);
	}

	/*Changes the console text colour when hovered over by reticle*/
	public void OnGazeLeave(){
		text.color = new Color(255.0f/255.0f, 255.0f/255.0f, 255.0f/255.0f, 1f);
	}

	public void clickReset() {
		//console tet == "";
		//LaunchButton is black
		uiHandler.DisplayText.text = "";
		launchButton.GetComponent<Renderer>().material = blackLaunchButton;
		uiHandler.enterPressed = false;

	}

}

