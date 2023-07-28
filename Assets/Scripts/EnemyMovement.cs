using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent (typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
public class EnemyMovement : MonoBehaviour
{
    private Transform player;
    private NavMeshAgent agent;
    private Animator animator;
    private Rigidbody rb;    

    // Start is called before the first frame update
    void Start()
    {
        player = Settings.Player;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if(dist < 10)
        {            
            agent.isStopped = false;
            agent.speed = 3;
            animator.SetTrigger("Run");
            agent.SetDestination(player.position);
        }
        else
        {            
            agent.speed = 0;
            agent.isStopped = true;
            animator.SetTrigger("Idle");
        }
    }
}
