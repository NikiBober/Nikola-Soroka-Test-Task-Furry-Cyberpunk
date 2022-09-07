using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Save();
    }

    void Save()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("LastPlayedSceneIndex", sceneIndex);
    }
}
