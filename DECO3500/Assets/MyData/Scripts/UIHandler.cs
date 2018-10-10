using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIHandler : MonoBehaviour {
    private Button[] btns;
    private Text DisplayText;
    private string lastText;
    public string number;
    public bool enterPressed; // true, if the enter button is pressed.
	// Use this for initialization
	void Start () {
        // DisplayText = this.transform.Find("HLayout/Image/Text").GetComponent<Text>();
        DisplayText = GameObject.Find("HLayout/Image/Text").GetComponent<Text>();
        DisplayText.text = "";
        btns = this.GetComponentsInChildren<Button>();
        foreach(Button b in btns) {
            b.onClick.AddListener(OnButtonClick);
        }
        number = "";
        enterPressed = false;
	}
	
	/*// Update is called once per frame
	void Update () {
		
	}*/

    void OnButtonClick() {
        string name = EventSystem.current.currentSelectedGameObject.name;
        if (name == "Enter") {
            number = DisplayText.text;
            DisplayText.text = "";
            enterPressed = true;
        } else if (name == "Empty") {
            DisplayText.text = lastText;
        } else {
            lastText = DisplayText.text;
            DisplayText.text += name;
        }

        if (name == "Backspace") {
            DisplayText.text = "";
            enterPressed = false;
        }
    }

}
