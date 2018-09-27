using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Vector3 playerStartingPosition;
	private float x;
	private float y;
	private bool userAtConsole;
	public TextMesh text;

	//is the user looking at the console text
	private bool isLookedAt = false;
	//how long the user has to look at the console text in order to teleport
	public float timeDuration;
	//how long the user has been loking at the console text
	private float lookedAtTimer = 0f;
	//graphical progress indicator
	private ReticleTimer gazeTimer;
	private GameObject player;


	// public event Action
	// Use this for initialization
	void Start () {
		userAtConsole = false;
		player = GameObject.Find("Player");
		playerStartingPosition = player.transform.position;
		x = playerStartingPosition.x;
		y = playerStartingPosition.y;
		gazeTimer = GameObject.Find("ReticleLoader").GetComponent<ReticleTimer>();
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
			
		} else {
			player.transform.position = new Vector3(x, y, -11.7f);
		}
	}

	/*Checks if user is looking at the console text gaze object and calls 
	ReticleTimer function to change the reticle timer image based on time left.
	*/
	private void consoleTextGaze() {
		if (isLookedAt) {
			//increment timeDuration
			lookedAtTimer += Time.deltaTime;
			// Debug.Log("timer: " + lookedAtTimer);
			//modify graphical indicator
			gazeTimer.reticleTimer(lookedAtTimer);
			if (lookedAtTimer > timeDuration) {
				lookedAtTimer = 0f;

				Debug.Log("teleported to console");
				atConsole();
				toConsoleTeleport();
			}
		} else {
			lookedAtTimer = 0f;
			//reset graphical indicator to 0
		}
	}

	/*Sets if the user is at the console or not. Changes the gaze text to the
	appropriate string deponding if user is or is not at the console.*/
	private void atConsole() {
		if (userAtConsole) {
			userAtConsole = false;
			text.text = "View Control Panel";
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
