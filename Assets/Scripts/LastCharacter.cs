using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastCharacter : MonoBehaviour
{
    public CustomerCounter customerCounter; // Reference to the CustomerCounter
    public int targetSceneIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Debugging
            Debug.Log("Character touched the player.");

            // Check if the customerCounter reference is assigned
            if (customerCounter == null)
            {
                Debug.LogWarning("CustomerCounter reference is not assigned!");
                return;
            }

            // Notify CustomerCounter about the completed objective
            customerCounter.CompleteObjective();

            // Destroy the character after a short delay to allow any destruction effects
            Destroy(gameObject, 1f); // 1 second delay before destroying

            ChangeScene();
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(targetSceneIndex);
    }
}
