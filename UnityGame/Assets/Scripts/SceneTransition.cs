using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad; // Name of the scene to transition to.

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
