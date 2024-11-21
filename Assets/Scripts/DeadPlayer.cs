using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeadPlayer : MonoBehaviour
{
    public GameObject deadCanvas;
    public GameObject vamp;

    // Start is called before the first frame update
    void Start()
    {
        deadCanvas.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ClickRestartButton(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
