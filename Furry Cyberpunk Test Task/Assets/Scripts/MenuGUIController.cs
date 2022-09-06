using UnityEngine;

public class MenuGUIController : MonoBehaviour {

	[SerializeField] KeyCode pauseKey;

    public static MenuGUIController Instance;

    bool isPaused;

    void Awake()
    {
        Instance = this;
    }

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
    }


    // Pause
    public void PauseGame()
    {
        MenuGUI_PuaseUI.instance.Show();
        MenuGUI.instance.Hide();
        isPaused = true;
    }

    // Resume/Unpause
    public void ResumeGame()
    {
        MenuGUI_PuaseUI.instance.Hide();
        MenuGUI.instance.Show();
        isPaused = false;
    }


}
