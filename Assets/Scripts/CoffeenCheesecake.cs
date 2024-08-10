using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoffeenCheesecake : MonoBehaviour
{
 public TextMeshProUGUI pickupPromptText; // The UI text that shows the pickup prompt
    public TaskManager taskManager; // Reference to TaskManager

    private bool isPlayerNear = false; // To track if the player is near the item

    private void Start()
    {
        pickupPromptText.gameObject.SetActive(false); // Hide the pickup prompt at the start
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
            pickupPromptText.text = "Press F to pick up"; // Set the prompt text
            pickupPromptText.gameObject.SetActive(true); // Show the pickup prompt
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
            pickupPromptText.gameObject.SetActive(false); // Hide the pickup prompt
        }
    }

    private void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.F))
        {
            taskManager.OnCollectiblePickedUp(); // Notify TaskManager
            pickupPromptText.gameObject.SetActive(false); // Hide the pickup prompt

        }
    }
}
