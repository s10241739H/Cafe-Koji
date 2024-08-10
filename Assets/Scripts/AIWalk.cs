using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIWalk : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    private NavMeshAgent navMeshAgent; // Reference to the NavMeshAgent component

    void Start()
    {
        // Get the NavMeshAgent component attached to this character
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (player != null)
        {
            // Set the destination of the NavMeshAgent to the player's position
            navMeshAgent.SetDestination(player.position);
        }
    }
}
