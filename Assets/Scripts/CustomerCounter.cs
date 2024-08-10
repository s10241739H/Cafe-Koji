using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomerCounter : MonoBehaviour
{
    public TextMeshProUGUI objectiveCounterText; // Text to show 0/3, 1/3, etc.

    private int completedObjectives = 0;
    private int totalObjectives = 5; // Set this to the total number of objectives

    private void Start()
    {
        // Initialize the counter display
        UpdateObjectiveCounter();
    }

    public void CompleteObjective()
    {
        // Increment the completed objectives count
        completedObjectives++;

        // Update the objective counter display
        UpdateObjectiveCounter();
    }

    private void UpdateObjectiveCounter()
    {
        if (objectiveCounterText != null)
        {
            objectiveCounterText.text = $"{completedObjectives}/{totalObjectives}";
        }
        else
        {
            Debug.LogWarning("Objective counter text is not assigned!");
        }
    }
}
