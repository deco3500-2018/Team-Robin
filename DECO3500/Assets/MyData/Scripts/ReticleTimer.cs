using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReticleTimer : MonoBehaviour {

	public GameObject load1;
	public GameObject load2;
	public GameObject load3;
	public GameObject load4;
	public GameObject load5;
	public GameObject load6;
	public GameObject load7;
	public GameObject load8;
	public GameObject load0;

	private float timeDuration = 3f;
	private float timer = 0f;

	//used for initialisation
	void Awake() {
		load0 = GameObject.Find("Load0");
		load1 = GameObject.Find("Load1");
		load2 = GameObject.Find("Load2");
		load3 = GameObject.Find("Load3");
		load4 = GameObject.Find("Load4");
		load5 = GameObject.Find("Load5");
		load6 = GameObject.Find("Load6");
		load7 = GameObject.Find("Load7");
		load8 = GameObject.Find("Load8");
	}

	void Start() {
		load0.SetActive(false);
		reset();
	}

	public void reset() {
		load1.SetActive(false);
		load2.SetActive(false);
		load3.SetActive(false);
		load4.SetActive(false);
		load5.SetActive(false);
		load6.SetActive(false);
		load7.SetActive(false);
		load8.SetActive(false);
	}

	// Update is called once per frame
	void Update () {

	}

	/*Give a loading timer for when something is OnHover() EventTrigger
	to simulate a gaze timer reticle*/
	public int reticleTimer(float time) {
		// Debug.Log("batman");
		if (time >= 2.51f) {
			load1.SetActive(false);
			load2.SetActive(false);
			load3.SetActive(false);
			load4.SetActive(false);
			load5.SetActive(false);
			load6.SetActive(false);
			load7.SetActive(false);
			load8.SetActive(true);
			return 0;
		}

		if (time >= 2.01f && time <= 2.50f) {
			load1.SetActive(false);
			load2.SetActive(false);
			load3.SetActive(false);
			load4.SetActive(false);
			load5.SetActive(false);
			load6.SetActive(false);
			load7.SetActive(true);
			load8.SetActive(false);
			return 0;
		}

		if (time >= 1.61f && time <= 2.00f) {
			load1.SetActive(false);
			load2.SetActive(false);
			load3.SetActive(false);
			load4.SetActive(false);
			load5.SetActive(false);
			load6.SetActive(true);
			load7.SetActive(false);
			load8.SetActive(false);
			return 0;
		}

		if (time >= 1.31f && time <= 1.60f) {
			load1.SetActive(false);
			load2.SetActive(false);
			load3.SetActive(false);
			load4.SetActive(false);
			load5.SetActive(true);
			load6.SetActive(false);
			load7.SetActive(false);
			load8.SetActive(false);
			return 0;
		}

		if (time >= 1.01f && time <= 1.30f) {
			load1.SetActive(false);
			load2.SetActive(false);
			load3.SetActive(false);
			load4.SetActive(true);
			load5.SetActive(false);
			load6.SetActive(false);
			load7.SetActive(false);
			load8.SetActive(false);
			return 0;
		}

		if (time >= 0.61f && time <= 1.00f) {
			load1.SetActive(false);
			load2.SetActive(false);
			load3.SetActive(true);
			load4.SetActive(false);
			load5.SetActive(false);
			load6.SetActive(false);
			load7.SetActive(false);
			load8.SetActive(false);
			return 0;
		}

		if (time >= 0.31f && time <= 0.60f) {
			load1.SetActive(false);
			load2.SetActive(true);
			load3.SetActive(false);
			load4.SetActive(false);
			load5.SetActive(false);
			load6.SetActive(false);
			load7.SetActive(false);
			load8.SetActive(false);
			return 0;
		}

		if (time <= 0.30f) {
			load1.SetActive(true);
			load2.SetActive(false);
			load3.SetActive(false);
			load4.SetActive(false);
			load5.SetActive(false);
			load6.SetActive(false);
			load7.SetActive(false);
			load8.SetActive(false);
			return 0;
		}
		return 5;
	}
}
