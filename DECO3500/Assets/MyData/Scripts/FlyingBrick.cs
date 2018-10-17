﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlyingBrick : MonoBehaviour {

	private int count;
	private bool LaunchBrick;
	private GameObject flyingBrick;
	
	private GameObject player;
	private Player playerScript;
	private Vector3 playerStartingPosition;
	private float x;
	private float y;
	private int countDown;
	public AudioClip clip;
	

	private UIHandler uiHandler;

	private EnterButton enterButton;
	
	// Use this for initialization
	void Start () {
		count = 0;
		LaunchBrick = false;
		flyingBrick = GameObject.Find("FlyingBrick");
		
		//player teleporting stuff
		player = GameObject.Find("Player");
		playerScript = player.GetComponent<Player>();
		playerStartingPosition = player.transform.position;
		x = playerStartingPosition.x;
		y = playerStartingPosition.y;
		
		countDown = 100;
		//get UIHandelr script
		GameObject handlerObject = GameObject.Find("Canvas");
		uiHandler = handlerObject.GetComponent<UIHandler>();

		//get EnterButton script
		GameObject enterbuttonObject = GameObject.Find("Enter");
		enterButton = enterbuttonObject.GetComponent<EnterButton>();

	}
	
	// Update is called once per frame
	void Update () {
		if(LaunchBrick) {
			if (countDown == 0) {
				GetConsoleNumber(uiHandler.number);
				count++;
			} else {
				countDown--;
			}
		}
	}

	/**
	 * Receives the console numbers text and from that determins what method
	 * to use to set the brick landing position.
	 * @param {String} string text [The console number used for determing the 
	 * brick fight position of landing.]
	 */
	public void GetConsoleNumber(string text) {
		int number = 0;
		int.TryParse(text, out number);
		Debug.Log("number is " + number);
		
		if (number == 13) {
			Debug.Log("= 13");
			SetBrickPositionLand(count);
		}

		if (number < 13) {
			Debug.Log("<13");
			SetBrickPositionInfront(count);
		}

		if (number > 13) {
			Debug.Log(">13");
			SetBrickPositionBehind(count);
		}
	}

	//method called for the brick to land on the bullseye
	private void SetBrickPositionLand(int count) {
		switch(count) {
			case 1:
				flyingBrick.transform.position = new Vector3(-2.69f, 3.19f, -0.069f);
			    break; 
		    case 2:
				flyingBrick.transform.position = new Vector3(-1.76f, 2.82f, -0.069f);
			    break; 
			case 3:
				flyingBrick.transform.position = new Vector3(-0.84f, 2.46f, -0.069f);
			    break; 
			case 4:
				flyingBrick.transform.position = new Vector3(0.09f, 2.09f, -0.069f);
			    break; 
			case 5:
				flyingBrick.transform.position = new Vector3(1.02f, 1.73f, -0.069f);
			    break; 
			case 6:
				flyingBrick.transform.position = new Vector3(1.95f, 1.36f, -0.069f);
			    break; 
		    case 7:
				flyingBrick.transform.position = new Vector3(2.88f, 0.99f, -0.069f);
			    break; 
		    case 8:
				flyingBrick.transform.position = new Vector3(3.80f, 0.63f, -0.069f);
			    break; 
		    case 9:
				flyingBrick.transform.position = new Vector3(4.73f, 0.26f,-0.069f);
			    break; 
		    case 10:
				flyingBrick.transform.position = new Vector3(5.66f, 0.1f, -0.069f);
			    break; 
		    case 11:
			    LaunchBrick = false;
			    break; 
		}

	}

	//method called for brick to land infront of bullseye
	private void SetBrickPositionInfront(int count) {
		switch(count) {
			case 1:
				flyingBrick.transform.position = new Vector3(-2.8598f, 3.19f, -0.069f);
			    break; 
		    case 2:
				flyingBrick.transform.position = new Vector3(-2.0996f, 2.82f, -0.069f);
			    break; 
			case 3:
				flyingBrick.transform.position = new Vector3(-1.3394f, 2.46f, -0.069f);
			    break; 
			case 4:
				flyingBrick.transform.position = new Vector3(-0.5792f, 2.09f, -0.069f);
			    break; 
			case 5:
				flyingBrick.transform.position = new Vector3(0.181f, 1.73f, -0.069f);
			    break; 
			case 6:
				flyingBrick.transform.position = new Vector3(0.9412f, 1.36f, -0.069f);
			    break; 
		    case 7:
				flyingBrick.transform.position = new Vector3(1.7014f, 0.99f, -0.069f);
			    break; 
		    case 8:
				flyingBrick.transform.position = new Vector3(2.4616f, 0.63f, -0.069f);
			    break; 
		    case 9:
				flyingBrick.transform.position = new Vector3(3.2218f, 0.26f,-0.069f);
			    break; 
		    case 10:
				flyingBrick.transform.position = new Vector3(3.982f, 0.1f, -0.069f);
			    break; 
		    case 11:
			    LaunchBrick = false;
			    break; 
		}
	}

	//method called for brick to land behind of bullseye
	private void SetBrickPositionBehind(int count) {
		switch(count) {
			case 1:
				flyingBrick.transform.position = new Vector3(-2.349f, 3.19f, -0.069f);
			    break; 
		    case 2:
				flyingBrick.transform.position = new Vector3(-1.078f, 2.82f, -0.069f);
			    break; 
			case 3:
				flyingBrick.transform.position = new Vector3(0.193f, 2.46f, -0.069f);
			    break; 
			case 4:
				flyingBrick.transform.position = new Vector3(1.464f, 2.09f, -0.069f);
			    break; 
			case 5:
				flyingBrick.transform.position = new Vector3(2.735f, 1.73f, -0.069f);
			    break; 
			case 6:
				flyingBrick.transform.position = new Vector3(4.006f, 1.36f, -0.069f);
			    break; 
		    case 7:
				flyingBrick.transform.position = new Vector3(5.277f, 0.99f, -0.069f);
			    break; 
		    case 8:
				flyingBrick.transform.position = new Vector3(6.548f, 0.63f, -0.069f);
			    break; 
		    case 9:
				flyingBrick.transform.position = new Vector3(7.819f, 0.26f,-0.069f);
			    break; 
		    case 10:
				flyingBrick.transform.position = new Vector3(9.09f, 0.1f, -0.069f);
			    break; 
		    case 11:
			    LaunchBrick = false;
			    break; 
		}
	}

	// uses EventTrigger on Luanch Butoon to set this value.
	public void FlyNow(bool clicked) {
		if (uiHandler.enterPressed) {
			LaunchBrick = clicked;
			// player.transform.position = new Vector3(x, y, -11.7f);
			playerScript.resetTeleport();
		} else {
			Debug.Log("eeeeeeppp");
			AudioSource audio = GameObject.Find("Wrong").GetComponent<AudioSource>();
			audio.PlayOneShot(clip,0.7f);
			enterButton.invalidPress();
		}
	}

	//TODO: [write] reset function definition (99)
	public void reset() {
		Debug.Log("hfjdsahjfhdsjafhjkd");
		count = 0;
		LaunchBrick = false;
		countDown = 100;
	}
}
