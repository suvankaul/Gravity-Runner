using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
	public Button Playbutton;
	public Button QuitButton;
	// Use this for initialization
	void Start () {
		Playbutton.onClick.AddListener (() => {
			Application.LoadLevel("Gravity Runner");
		
		});
		QuitButton.onClick.AddListener (() => {
			Application.Quit();

		});
	}
	
	// Update is called once per frame

}
