using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuGUI : Jun_ComponentSingletonObject <MenuGUI> {

	public GUI_Button pauseButton;

	// Use this for initialization
	void Start () {
		pauseButton.SetNewListener (pauseButton_OnClick);
	}

	void pauseButton_OnClick (GameObject go)
	{
		MenuGUI_PuaseUI.instance.Show ();
		Hide ();
	}
}
