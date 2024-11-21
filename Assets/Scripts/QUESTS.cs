using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QUESTS : MonoBehaviour
{

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "The hunters are after you. Kill them! (Spacebar to Attack)";
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindGameObjectWithTag("Enemy")){
            text.text = "The castle gate seems to have opened and inside waits a horror.";
        }
    }
}
