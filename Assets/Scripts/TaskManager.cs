using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public List<AIWalkCollectible> characters; // List of characters controlled by AIWalk scripts
    private int currentTaskIndex = 0; // Index of the current task/character

    // Method to be called when a task is completed
    public void CompleteTask()
    {
        if (currentTaskIndex < characters.Count)
        {
            characters[currentTaskIndex].StartMoving(); // Start the current character moving toward the player
            currentTaskIndex++; // Move to the next task
        }
    }
}
