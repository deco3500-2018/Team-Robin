using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TextGaze : MonoBehaviour {

	public TextMesh text;

	/*Changes the console text colour when hovered over by reticle*/
	public void OnGazeEnter() {
		text.color = new Color(130.0f/255.0f, 130.0f/255.0f, 130.0f/255.0f, 1f);
	}

	/*Changes the console text colour when hovered over by reticle*/
	public void OnGazeLeave(){
		text.color = new Color(255.0f/255.0f, 255.0f/255.0f, 255.0f/255.0f, 1f);
	}
}

