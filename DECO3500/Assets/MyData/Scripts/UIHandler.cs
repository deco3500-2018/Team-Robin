using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIHandler : MonoBehaviour {
    Button[] btns;
    Text DisplayText;
	// Use this for initialization
	void Start () {
        DisplayText = this.transform.Find("HLayout/Image/Text").GetComponent<Text>();
        DisplayText.text = "";
        btns = this.GetComponentsInChildren<Button>();
        foreach(Button b in btns)
        {
            b.onClick.AddListener(OnButtonClick);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnButtonClick()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        if (name == "Enter")
            DisplayText.text = "";
        else
            DisplayText.text += name;
    }
}
