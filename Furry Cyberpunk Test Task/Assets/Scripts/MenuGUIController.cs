using UnityEngine;

public class MenuGUIController : MonoBehaviour {

	[SerializeField]
	KeyCode pauseKey;

    bool isPaused;

	// Use this for initialization
	void Start () 
	{
		MenuGUI_PuaseUI.instance.Hide ();
	}

	void Update()
	{
		if (Input.GetKeyDown(pauseKey))
			Toggle_Pause();
	}

    public void Toggle_Pause()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }

        isPaused = !isPaused;
    }


    // Pause
    public void PauseGame()
    {
        MenuGUI_PuaseUI.instance.Show();
        MenuGUI.instance.Hide();
    }

    // Resume/Unpause
    public void ResumeGame()
    {
        MenuGUI_PuaseUI.instance.Hide();
        MenuGUI.instance.Show();
    }


}
