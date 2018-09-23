using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour {

	public int PlayerSpeed;
	// public Vector3 cameraPos = Camera.main.transform.position;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1")) {
			transform.position = transform.position + 
				Camera.main.transform.forward * Time.deltaTime;
		}
	}
}
