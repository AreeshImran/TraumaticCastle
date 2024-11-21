using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vamp : MonoBehaviour
{
    public GameObject vampPlayer;
    public GameObject dieScreen;
    public GameObject audioPlayer;
    public int HP = 100;
    public int currentHealth;
    public HealthBar healthbar;

    void Start(){
        currentHealth = HP;
        healthbar.SetMaxHealth(HP);
    }
    
    public void TakeDamage(int damageAmount){
        HP -= damageAmount;
        currentHealth = HP;
        healthbar.setHealth(currentHealth);
        if(HP <= 0){
            Destroy(vampPlayer);
            dieScreen.SetActive(true);
            Destroy(audioPlayer);
        }
    }
}
