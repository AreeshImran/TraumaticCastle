using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AttackState : StateMachineBehaviour
{

    NavMeshAgent agent;

    Transform player;


    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){

        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){
        
        animator.transform.LookAt(player);

        float distance = Vector3.Distance(player.position, animator.transform.position);
        if(distance > 1f){
            animator.SetBool("isAttack", false);
        }

    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){

    }
}