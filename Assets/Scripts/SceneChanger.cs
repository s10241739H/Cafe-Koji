using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int targetSceneIndex;

    private void OnTriggerEnter(Collider other)
    {
        // Check wether the object has the player tag
        if(other.tag == "Player")
        {
            // If its the player, change scenes
            ChangeScene();
        }

    }

    void ChangeScene()
    {
        SceneManager.LoadScene(targetSceneIndex);

    }
}
