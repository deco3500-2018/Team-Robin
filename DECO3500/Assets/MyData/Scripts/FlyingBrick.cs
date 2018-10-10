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
	

	// private Text DisplayText;
	// opponentScript theScript  = OBJhit.GetComponent("opponentScript");
	private UIHandler uiHandler;
	
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
		GameObject handlerObject = GameObject.Find("Canvas");
		uiHandler = handlerObject.GetComponent<UIHandler>();


	}
	
	// Update is called once per frame
	void Update () {
		if(LaunchBrick) {
			if (countDown == 0) {
				// SetBrickPositionLand(count++);
				//  opponentScript theScript  = OBJhit.GetComponent("opponentScript");
				Debug.Log("countdoen = 0");
				GetConsoleNumber(uiHandler.number);
				//TODO: change to 10 eventually
				count++;
				if (count == 6) {
					LaunchBrick = false;
				}
			} else {
				countDown--;
			}
		}
	}

	//TODO: [write] function definition (99) GetConsoleNumber
	public void GetConsoleNumber(string text) {
		int number = 0;
		int.TryParse(text, out number);

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

	//TODO: change for 10 cases
	//method called for the brick to land on the bullseye
	private void SetBrickPositionLand(int count) {
		//add if not number from console
		// player.transform.position = new Vector3(0.001f, 0.001f, 0.83671f);
		Debug.Log("SerBrick Land position on");
		switch(count) {
			case 1:
				flyingBrick.transform.position = new Vector3(-2.07f, 2.958f,-0.069f);
			    break; 
		    case 2:
				flyingBrick.transform.position = new Vector3(-0.52f, 2.366f ,-0.069f);
			    break; 
			case 3:
				flyingBrick.transform.position = new Vector3(1.03f, 1.774f,-0.069f);
			    break; 
			case 4:
				flyingBrick.transform.position = new Vector3(2.58f, 1.182f,-0.069f);
			    break; 
			case 5:
				flyingBrick.transform.position = new Vector3(5.681f, 0.59f,-0.069f);
			    break; 
		}

	}

	//method called for brick to land infront of bullseye
	private void SetBrickPositionInfront(int count) {

	}

	//method called for brick to land behind of bullseye
	private void SetBrickPositionBehind(int count) {

	}

	// uses EventTrigger on Luanch Butoon to set this value.
	public void FlyNow(bool clicked) {
		Debug.Log("Launch Button pressed" + clicked);
		LaunchBrick = clicked;
		player.transform.position = new Vector3(x, y, -11.7f);
	}
}
