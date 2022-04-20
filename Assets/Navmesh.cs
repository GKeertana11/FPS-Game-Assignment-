using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navmesh : MonoBehaviour
{
    public GameObject player;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
        if (!player)
        {
            Debug.Log("Make sure your player is tagged!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
        agent.stoppingDistance = 20f;
    }
}
