using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Using TextMeshPro

public class ObjectivesManager : MonoBehaviour
{
    public GameObject objectivesPanel; // Reference to the Objectives Panel UI
    public TextMeshProUGUI objective1Text;
    public TextMeshProUGUI objective2Text;
    public TextMeshProUGUI objective3Text;

    private bool objectivesPanelActive = false; // To track the panel's visibility

    void Start()
    {
        // Initialize objectives
        objective1Text.text = "1. Collect Coffee Beans from the farmer.";
        objective2Text.text = "2. Collect Coffee Machine in the Hardware store.";
        objective3Text.text = "3. Collect milk & eggs from the supermarket.";

        // Ensure the panel is hidden at the start
        objectivesPanel.SetActive(objectivesPanelActive);
    }

        private void Update()
    {
        // Toggle the objectives panel when the "F" key is pressed
        if (Input.GetKeyDown(KeyCode.G))
        {
            objectivesPanelActive = !objectivesPanelActive;
            objectivesPanel.SetActive(objectivesPanelActive);
        }
    }


      public void CompleteObjective(int objectiveNumber)
    {
        switch (objectiveNumber)
        {
            case 1:
                if (!objective1Text.text.Contains("<s>"))
                {
                    objective1Text.text = "<s>1. Find the key.</s>"; // Strike-through text
                }
                break;
            case 2:
                if (!objective2Text.text.Contains("<s>"))
                {
                    objective2Text.text = "<s>2. Unlock the door.</s>";
                }
                break;
            case 3:
                if (!objective3Text.text.Contains("<s>"))
                {
                    objective3Text.text = "<s>3. Escape the room.</s>";
                }
                break;
            default:
                Debug.LogWarning("Invalid objective number.");
                break;
        }
    }
}
