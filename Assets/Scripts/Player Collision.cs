using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the tag "Character"
        if (other.CompareTag("Character"))
        {
            // Destroy the character
            Destroy(other.gameObject);
        }
    }
}
