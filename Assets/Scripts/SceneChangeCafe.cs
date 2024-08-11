using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeCafe : MonoBehaviour
{
    public int targetSceneIndex; // The scene index to load
    public ObjectivesManager objectivesManager; // Reference to ObjectivesManager
    public GameObject lockMessage; // UI message to show if objectives are incomplete

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Check if all objectives are completed
            if (objectivesManager.AreAllObjectivesCompleted())
            {
                // If all objectives are completed, change scenes
                ChangeScene();
            }
            else
            {
                // Show the lock message
                lockMessage.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Hide the lock message when the player leaves the trigger
            lockMessage.SetActive(false);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(targetSceneIndex);
    }
}
