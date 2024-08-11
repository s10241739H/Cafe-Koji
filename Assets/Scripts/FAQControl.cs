using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FAQControl : MonoBehaviour
{
    public GameObject panel; // Reference to the panel GameObject
    public Button toggleButton; // Reference to the button that will toggle the panel

    private void Start()
    {
        // Ensure the panel is initially hidden (optional, based on your preference)
        panel.SetActive(false);

        // Add a listener to the button to call the TogglePanel method when clicked
        toggleButton.onClick.AddListener(TogglePanel);
    }

    // Method to toggle the panel's visibility
    private void TogglePanel()
    {
        panel.SetActive(!panel.activeSelf);
    }
}
