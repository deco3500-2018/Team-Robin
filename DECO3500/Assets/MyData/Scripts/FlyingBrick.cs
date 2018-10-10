using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlyingBrick : MonoBehaviour {

	private int count;
	private bool LaunchBrick;
	private GameObject flyingBrick;
	
	private GameObject player;
	private Vector3 playerStartingPosition;
	private float x;
	private float y;
	private int countDown;
	public AudioClip clip;
	

	// private Text DisplayText;
	// opponentScript theScript  = OBJhit.GetComponent("opponentScript");
	// private bool enterPressed;
	private UIHandler uiHandler;

	private EnterButton enterButton;
	
	// Use this for initialization

	 /*GameObject enemy = GameObject.Find("Enemy");
 	EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth>();
 // Get current health
 enemyHealth.CurrentHealth;*/
	void Start () {
		count = 0;
		LaunchBrick = false;
		flyingBrick = GameObject.Find("FlyingBrick");
		
		//player teleporting stuff
		player = GameObject.Find("Player");
		playerStartingPosition = player.transform.position;
		x = playerStartingPosition.x;
		y = playerStartingPosition.y;
		
		countDown = 100;
		// DisplayText = GameObject.Find("HLayout/Image/Text").GetComponent<Text>();
		//TODO: remember to set and reset in rest method
		// enterPressed = false;
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
			// Debug.Log("text: " + uiHandler.number);
			if (countDown == 0) {
				// Debug.Log("countdown = 0");
				GetConsoleNumber(uiHandler.number);
				count++;
			} else {
				countDown--;
			}
		}
	}

	//TODO: [write] function definition (99) GetConsoleNumber
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
		//add if not number from console
		switch(count) {
			/*case 1:
				flyingBrick.transform.position = new Vector3(-2.68f, 3.15f, -0.069f);
			    break; 
		    case 2:
				flyingBrick.transform.position = new Vector3(-1.74f, 2.75f, -0.069f);
			    break; 
			case 3:
				flyingBrick.transform.position = new Vector3(-0.8f, 2.35f, -0.069f);
			    break; 
			case 4:
				flyingBrick.transform.position = new Vector3(0.14f, 1.95f, -0.069f);
			    break; 
			case 5:
				flyingBrick.transform.position = new Vector3(1.08f, 1.55f, -0.069f);
			    break; 
			case 6:
				flyingBrick.transform.position = new Vector3(2.02f, 1.15f, -0.069f);
			    break; 
		    case 7:
				flyingBrick.transform.position = new Vector3(2.96f, 0.75f, -0.069f);
			    break; 
		    case 8:
				flyingBrick.transform.position = new Vector3(3.9f, 0.35f, -0.069f);
			    break; 
		    case 9:
				flyingBrick.transform.position = new Vector3(4.843f, -0.01f, -0.069f);
			    break; 
		    case 10:
				// flyingBrick.transform.position = new Vector3(1.08f, 1.55f,-0.069f);
			    LaunchBrick = false;
			    break; */
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
			player.transform.position = new Vector3(x, y, -11.7f);
		} else {
			Debug.Log("eeeeeeppp");
			//TODO: add bad/wrong/invalid sound here
			AudioSource audio = GameObject.Find("Wrong").GetComponent<AudioSource>();
			audio.PlayOneShot(clip,0.7f);
			enterButton.invalidPress();
		}
	}
}
