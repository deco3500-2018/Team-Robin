using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGaze : MonoBehaviour {

	public void OnGazeEnter() {
		Debug.Log("looking at text");
	}

	public void OnGazeLeave(){
		Debug.Log("not looking at text");
	}
}
