using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAttack : MonoBehaviour
{
    public NavMeshAgent player;
    public Animator playerAnimator;
    public Transform enemy;

    void Start(){
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            playerAnimator.SetBool("attack", true);
        }
        else{
            playerAnimator.SetBool("attack", false);
        }

        float distance = Vector3.Distance(enemy.position, playerAnimator.transform.position);
        if(distance < 1f){
            playerAnimator.transform.LookAt(enemy);
        }
        
    }
}
