using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dumpling : MonoBehaviour
{
    public GameObject dumpling;
    public int HP = 100;
    public GameObject winScreen;
    public GameObject audioPlayer;
    public GameObject canvas;
    
    public void TakeDamage(int damageAmount){
        HP -= damageAmount;
        if(HP <= 0){
            Destroy(dumpling);
            winScreen.SetActive(true);
            Destroy(audioPlayer);
            Destroy(canvas);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            other.GetComponent<Vamp>().TakeDamage(30);
        }
    }
}

