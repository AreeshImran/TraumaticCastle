using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChaseState : StateMachineBehaviour
{
    float timer;
    NavMeshAgent agent;

    Transform player;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){
        agent = animator.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent.speed = 0.05f;
        
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){
        
        agent.SetDestination(player.position);
        float distance = Vector3.Distance(player.position, animator.transform.position);
        if(distance > 15){
            animator.SetBool("isSprint", false);
        }
        if(distance < 0.7f){
            animator.SetBool("isAttack", true);
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){
        
    }
}