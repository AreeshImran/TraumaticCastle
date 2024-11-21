using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killedHunters : MonoBehaviour
{
    public GameObject bars;
    public GameObject dumpling;

    // Start is called before the first frame update
    void Start()
    {
        dumpling.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindGameObjectWithTag("Enemy")){
            Destroy(bars);
            dumpling.SetActive(true);
        }
        
    }
}
