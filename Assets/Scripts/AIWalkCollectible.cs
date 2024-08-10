using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIWalkCollectible : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    private NavMeshAgent navMeshAgent; // Reference to the NavMeshAgent component
    private bool canMove = false; // To check if the character can move towards the player

    void Start()
    {
        // Get the NavMeshAgent component attached to this character
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (canMove && player != null)
        {
            // Set the destination of the NavMeshAgent to the player's position
            navMeshAgent.SetDestination(player.position);
        }
    }

    // Method to allow the character to start moving
    public void StartMoving()
    {
        canMove = true;
    }
}
