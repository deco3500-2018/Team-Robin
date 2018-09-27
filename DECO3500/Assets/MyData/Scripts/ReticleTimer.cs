using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReticleTimer : MonoBehaviour {

	public Sprite load1;
	public Sprite load2;
	public Sprite load3;
	public Sprite load4;
	public Sprite load5;
	public Sprite load6;
	public Sprite load7;
	public Sprite load8;

	private float timeDuration = 3f;
	private float timer = 0f;

	// Update is called once per frame
	void Update () {

	}

	/*Give a loading timer for when something is OnHover() EventTrigger
	to simulate a gaze timer reticle*/
	public void reticleTimer(float time) {
		if (time <= 0.30f) {
			GetComponent<Image>().sprite = load1;
		} else if (time >= 0.31f && time <= 0.60f) {
			GetComponent<Image>().sprite = load2;
		} else if (time >= 0.61f && time <= 1.00f) {
			GetComponent<Image>().sprite = load3;
		} else if (time >= 1.01f && time <= 1.30f) {
			GetComponent<Image>().sprite = load4;
		} else if (time >= 1.31f && time <= 1.60f) {
			GetComponent<Image>().sprite = load5;
		} else if (time >= 1.61f && time <= 2.00f) {
			GetComponent<Image>().sprite = load6;
		} else if (time >= 2.01f && time <= 2.50f) {
			GetComponent<Image>().sprite = load7;
		} else if (time >= 2.51f) {
			GetComponent<Image>().sprite = load8;
		}
	}
}
