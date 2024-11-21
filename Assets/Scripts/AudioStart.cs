using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioStart : MonoBehaviour
{
    public AudioSource audio1;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindGameObjectWithTag("StartScreen")){
            audio1.Stop();
        }
    }
}
