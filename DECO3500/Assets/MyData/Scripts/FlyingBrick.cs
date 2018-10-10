using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBrick : MonoBehaviour {

	private int count;
	private bool LaunchBrick;
	private GameObject flyingBrick;
	
	private GameObject player;
	private Vector3 playerStartingPosition;
	private float x;
	private float y;
	private int countDown;
	
	// Use this for initialization
	void Start () {
		count = 0;
		LaunchBrick = false;
		flyingBrick = GameObject.Find("FlyingBrick");
		player = GameObject.Find("Player");
		playerStartingPosition = player.transform.position;
		x = playerStartingPosition.x;
		y = playerStartingPosition.y;
		countDown = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if(LaunchBrick) {
			if (countDown == 0) {
				SetBrickPosition(count++);
			} else {
				countDown--;
			}
			// count++;
		}
	}

	private void SetBrickPosition(int count) {
		//add if not number from console
		// player.transform.position = new Vector3(0.001f, 0.001f, 0.83671f);
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

	// uses EventTrigger on Luanch Butoon to set this value.
	public void FlyNow(bool clicked) {
		Debug.Log("Launch Button pressed" + clicked);
		LaunchBrick = clicked;
		player.transform.position = new Vector3(x, y, -11.7f);
	}
}
