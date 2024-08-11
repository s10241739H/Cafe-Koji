using UnityEngine;
using UnityEngine.SceneManagement; // Include this namespace

public class SceneChangerTimeline : MonoBehaviour
{
    public int targetSceneIndex; // The scene index to load

    public void ChangeScene()
    {
        SceneManager.LoadScene(targetSceneIndex);
    }
}
