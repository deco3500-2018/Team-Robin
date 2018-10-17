using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Vector3 playerStartingPosition;
	private float x;
	private float y;
	public bool userAtConsole;
	public TextMesh text;

	//is the user looking at the console text
	private bool isLookedAt = false;
	//how long the user has to look at the console text in order to teleport
	public int timeDuration;
	//how long the user has been loking at the console text
	private int lookedAtTimer = 0;
	//graphical progress indicator
	private ReticleTimer gazeTimer;
	private GameObject player;
	private GameObject timer;
	private Transform timerTrans;

	private int waitTimer = 0;


	// public event Action
	// Use this for initialization
	void Start () {
		userAtConsole = false;
		player = GameObject.Find("Player");
		timer = GameObject.Find("ReticleTimer");
		timerTrans = timer.GetComponent<Transform>();
		playerStartingPosition = player.transform.position;
		x = playerStartingPosition.x;
		y = playerStartingPosition.y;
		gazeTimer = GameObject.Find("ConsoleTextGaze").GetComponent<ReticleTimer>();
	}
	
	// Update is called once per frame
	void Update () {
		consoleTextGaze();
	}

	/*
	 * Teleports the player to the console. Changes the users position.
	 */
	public void toConsoleTeleport( ) {
		if (userAtConsole) {
			player.transform.position = new Vector3(x, y, -8f);
			timerTrans.localScale = new Vector3(0.001f, 0.001f, 0.83671f);
			timer.transform.position = new Vector3(-0.5f, 0.9f, -6.868f);
			
		} else {
			player.transform.position = new Vector3(x, y, -11.7f);
			timerTrans.localScale = new Vector3(0.003f, 0.003f, 0.83671f);
			timer.transform.position = new Vector3(-0.467f, 0.506f, -6.868f);
		}
	}

	/*Checks if user is looking at the console text gaze object and calls 
	ReticleTimer function to change the reticle timer image based on time left.
	*/
	private void consoleTextGaze() {
		if (isLookedAt) {
			waity();
			if (lookedAtTimer == 10) {
				atConsole();
				toConsoleTeleport();
				isLookedAt = false;
			}
		} else {
			lookedAtTimer = 0;
		}
	}

	//used by the reset button in the virtual world, accessed in FlyingBrick.cs
	public void resetTeleport() {
		userAtConsole = false;
		text.text = "Go To Control Panel";
		toConsoleTeleport();
	}

	private void waity() {
		if (waitTimer == 10) {
			waitTimer = 0;
			gazeTimer.reticleTimer(lookedAtTimer);
			lookedAtTimer++;
		}
		++waitTimer;
	}

	/*Sets if the user is at the console or not. Changes the gaze text to the
	appropriate string deponding if user is or is not at the console. Changes
	to the opposite*/
	// private void atConsole() {
	public void atConsole() {
		if (userAtConsole) {
			userAtConsole = false;
			text.text = "Go To Control Panel";
		} else {
			userAtConsole = true;
			text.text = "Move Back";
		}
	}

	/*
	 * Sets if the text is being looked at by user. Called in EventTrigger on
	 * PointerEnter and PointerExit event
	 */
	public void SetGazedAt(bool gazedAt) {
		isLookedAt = gazedAt;
	}
}
