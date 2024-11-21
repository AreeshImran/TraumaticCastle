using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAudio : MonoBehaviour
{

    public GameObject audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        audioPlayer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindGameObjectWithTag("StartScreen")){
            audioPlayer.SetActive(true);
        }
        
    }
}
