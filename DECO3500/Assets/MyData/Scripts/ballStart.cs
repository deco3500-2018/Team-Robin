using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballStart : MonoBehaviour {

    public GameObject Ball;
    public bool ballMove;

	// Update is called once per frame
	void Update () {
		if (ballMove == true)
        {
            Ball.transform.Translate(Vector3.down * Time.deltaTime * 5);

        }

        if (Ball.transform.position.y > 7f)
        {
            ballMove = false;
        }
	}
    void OnMouseDown()
    {
        ballMove = true;
    }
}
