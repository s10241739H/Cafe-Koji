using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public AIWalkCollectible[] characters; // Array of characters to come in sequence
    private int currentCharacterIndex = 0; // Index of the current character to come in

    void Start()
    {
        // Initially, all characters should be inactive or not moving
        foreach (var character in characters)
        {
            character.gameObject.SetActive(false);
        }
    }

    public void OnCollectiblePickedUp()
    {
        // Check if there's a character to activate
        if (currentCharacterIndex < characters.Length)
        {
            // Activate the next character and let them start moving
            characters[currentCharacterIndex].gameObject.SetActive(true);
            characters[currentCharacterIndex].StartMoving();
            
            // Move to the next character in the sequence
            currentCharacterIndex++;
        }
    }
}

