using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class EnemyMovement : MonoBehaviour
{
    public Vector3 Target;

    private float Timer = 1f;

    Vector3 destination;
   // public float UpdateSpeed = 0.1f; //path recalculation time

    private NavMeshAgent Agent;

    

    

    

    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        Target = GameObject.FindWithTag("Castle").transform.position;

        Agent.SetDestination(Target);
        Agent.autoRepath = true;
       
        //StartCoroutine(FollowTarget());
    }

    /*private IEnumerator FollowTarget()
    {
        WaitForSeconds Wait = new WaitForSeconds(UpdateSpeed);
        
        while (enabled)
        {
            Timer = .5f;

            Agent.SetDestination(Target.transform.position);
            yield return Wait;
        }
    }*/


    // Update is called once per frame
    void Update()
    {
        if(Agent.pathStatus != NavMeshPathStatus.PathComplete && Timer <= 0)
        {
            Timer = 1;
            BuildManager.Obstructed();
            GameObject.FindWithTag("GameController").SendMessage("DeselectNode");
            Agent.ResetPath();
            Agent.SetDestination(Target);
        }
        if(Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
    }
}
