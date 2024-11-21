using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy"){
            other.GetComponent<VampHunter>().TakeDamage(20);
        }

        if(other.tag == "Dumpling"){
            other.GetComponent<Dumpling>().TakeDamage(30);
        }
    }
}
