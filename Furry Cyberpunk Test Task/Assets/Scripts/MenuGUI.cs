using UnityEngine;

public class MenuGUI : Jun_ComponentSingletonObject <MenuGUI> {

	public GUI_Button pauseButton;

	// Use this for initialization
	void Start () {
		pauseButton.SetNewListener (pauseButton_OnClick);
	}

	void pauseButton_OnClick (GameObject go)
	{
		MenuGUIController.Instance.PauseGame();
	}
}
