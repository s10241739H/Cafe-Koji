using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectivesManager : MonoBehaviour
{
    public GameObject objectivesPanel;
    public TextMeshProUGUI objective1Text;
    public TextMeshProUGUI objective2Text;
    public TextMeshProUGUI objective3Text;
    public TextMeshProUGUI[] objectiveTexts;
    public TextMeshProUGUI objectiveCounterText; // Text to show 0/3, 1/3, etc.

    private bool objectivesPanelActive = false;
    private int completedObjectives = 0;
    private int totalObjectives;

    void Start()
    {
        // Initialize objectives
        objective1Text.text = "1. Collect Coffee Beans from the farmer.";
        objective2Text.text = "2. Collect Coffee Machine in the Hardware store.";
        objective3Text.text = "3. Collect milk & eggs from the supermarket.";

        // Set the total objectives count
        totalObjectives = objectiveTexts.Length;

        // Initialize the objective counter display
        UpdateObjectiveCounter();

        // Ensure the panel is hidden at the start
        objectivesPanel.SetActive(objectivesPanelActive);
    }

    private void Update()
    {
        // Toggle the objectives panel when the "G" key is pressed
        if (Input.GetKeyDown(KeyCode.G))
        {
            objectivesPanelActive = !objectivesPanelActive;
            objectivesPanel.SetActive(objectivesPanelActive);
        }
    }

    public void CompleteObjective(int objectiveNumber)
    {
        if (objectiveNumber >= 0 && objectiveNumber < objectiveTexts.Length)
        {
            if (!objectiveTexts[objectiveNumber].text.Contains("<s>")) // Ensure it hasn't been completed already
            {
                // Mark the objective as completed
                objectiveTexts[objectiveNumber].text = "<s>" + objectiveTexts[objectiveNumber].text + "</s>";

                // Increment the completed objectives count
                completedObjectives++;

                // Update the objective counter display
                UpdateObjectiveCounter();
            }
        }
        else
        {
            Debug.LogWarning("Objective number is out of range!");
        }
    }

    private void UpdateObjectiveCounter()
    {
        objectiveCounterText.text = $"{completedObjectives}/{totalObjectives}";
    }
}
