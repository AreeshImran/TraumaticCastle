using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdle : StateMachineBehaviour
{
    Transform player;
    float sprintRange = 8;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){
        
        float distance = Vector3.Distance(player.position, animator.transform.position);
        if(distance < sprintRange){
            animator.SetBool("isSprint", true);
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){

    }
}
