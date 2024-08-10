using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConvoStarter : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;
    [SerializeField] private GameObject canvasObject; // Reference to the Canvas GameObject

    private void Start()
    {
        // Ensure the canvas is inactive at the start
        if (canvasObject != null)
        {
            canvasObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (myConversation != null)
            {
                // Activate the canvas when the player enters the trigger
                if (canvasObject != null)
                {
                    canvasObject.SetActive(true);
                }

                ConversationManager.Instance.StartConversation(myConversation);
            }
            else
            {
                Debug.LogWarning("myConversation is not assigned in the Inspector!");
            }
        }
    }
}
