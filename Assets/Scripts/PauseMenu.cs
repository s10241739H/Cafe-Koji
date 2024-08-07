using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI; // The main pause menu UI
    public GameObject volumeSliderUI; // The volume slider UI
    public GameObject backButton; // The back button in the volume slider UI

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        volumeSliderUI.SetActive(false); // Hide the volume slider when resuming
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void ShowVolumeSlider()
    {
        pauseMenuUI.SetActive(false); // Hide the pause menu
        volumeSliderUI.SetActive(true); // Show the volume slider UI
    }

    public void BackToPauseMenu()
    {
        volumeSliderUI.SetActive(false); // Hide the volume slider UI
        pauseMenuUI.SetActive(true); // Show the pause menu
    }
}
