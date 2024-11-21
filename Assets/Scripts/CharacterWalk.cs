using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterWalk : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent player;
    public Animator playerAnimator;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;

            if(Physics.Raycast(ray, out hitPoint)){
                player.SetDestination(hitPoint.point);
            }
        }

        if(player.velocity != Vector3.zero){
            playerAnimator.SetBool("walk", true);
        }
        else if(player.velocity == Vector3.zero){
            playerAnimator.SetBool("walk", false);
        }
    }

}
