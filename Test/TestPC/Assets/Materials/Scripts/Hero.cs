using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Hero : MonoBehaviour
{
    public Transform Finish;
    public Transform StartPosition;
    public Transform MovePosition;
    public Transform MovePosition1;
    public Transform MovePosition2;
    private NavMeshAgent agent;
    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (agent.remainingDistance < 5)
        {
            Chill();
        }
        else
        {
            Run();
        }


        if (StartPosition == true)
        {
            agent.destination = StartPosition.position;
        }

        else if (MovePosition == true && StartPosition == false)
        {
            agent.destination = MovePosition.position;
        }

        else if (MovePosition == false && MovePosition1 == true && StartPosition == false)
        {
            agent.destination = MovePosition1.position;
        }

        else if (MovePosition == false && MovePosition1 == false && MovePosition2 == true && StartPosition == false)
        {
            agent.destination = MovePosition2.position;
        }

        else if (MovePosition == false && MovePosition1 == false && MovePosition2 == false && StartPosition == false)
        {
            agent.destination = Finish.position;
        }

    }

    void Run()
    {
        agent.isStopped = false;
        animator.SetBool("IsWalking", true);     
    }
    void Chill()
    {
        agent.isStopped = true;
        animator.SetBool("IsWalking", false);    
    }

    

}
