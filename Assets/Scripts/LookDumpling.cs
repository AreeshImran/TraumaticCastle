using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookDumpling : MonoBehaviour
{
    public Text text;

    Transform dumpling;
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        dumpling = GameObject.FindGameObjectWithTag("Dumpling").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToTarget = player.position - dumpling.position;
        float distance = directionToTarget.magnitude;
 
        if (distance < 2){
            text.text = "A blood dumpling has been growing like mould in your castle! FINISH IT!";
        }
    }
}
