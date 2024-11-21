using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VampHunter : MonoBehaviour
{

    public GameObject enemy;
    public int HP = 100;
    
    public void TakeDamage(int damageAmount){
        HP -= damageAmount;
        if(HP <= 0){
            Destroy(enemy);
        }
    }

  
}
