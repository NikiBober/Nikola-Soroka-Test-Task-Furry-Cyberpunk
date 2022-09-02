using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadController : MonoBehaviour
{
    public void Load()
    {
        int sceneIndex = PlayerPrefs.GetInt("LastPlayedSceneIndex");
        SceneManager.LoadScene(sceneIndex);
    }
}
