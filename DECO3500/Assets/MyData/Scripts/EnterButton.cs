using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterButton : MonoBehaviour {

	private Button enterButton;
	private ColorBlock colourBlock;
	private Color pressed;
	private Color notPressed;
	private Color green;

	//Launch Button
	private GameObject launchButton;
	public Material redLaunchButton;
	public Material blackLaunchButton;


	// Use this for initialization
	void Start () {
		notPressed = Color.black;
		pressed = new Color(243f, 26f, 26f, 255f);
		green = new Color(58f, 241f, 27f, 255f);

		launchButton = GameObject.Find("LaunchButton");
		enterButton = GameObject.Find("Enter").GetComponent<Button>();
		colourBlock = enterButton.colors;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void ChangeLaunchButtonColour(bool press) {
		if (press) {
			launchButton.GetComponent<Renderer>().material = redLaunchButton;
			//TODO: add good sound here
		} 
	}

	//as StartCoroutine can't be called from another script
	public void invalidPress() {
		StartCoroutine(FlashEnterButton());
	}


	IEnumerator FlashEnterButton(){
		Color currentColor = colourBlock.normalColor;
		colourBlock.normalColor = green;
		enterButton.colors = colourBlock;
		
		yield return new WaitForSeconds(1);
		colourBlock.normalColor = currentColor;
		enterButton.colors = colourBlock;

		yield return new WaitForSeconds(1);
		colourBlock.normalColor = green;
		enterButton.colors = colourBlock;

		yield return new WaitForSeconds(1);
		colourBlock.normalColor = currentColor;
		enterButton.colors = colourBlock;
	}

}
