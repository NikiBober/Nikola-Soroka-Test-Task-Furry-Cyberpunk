using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;

    public void StartNewGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
