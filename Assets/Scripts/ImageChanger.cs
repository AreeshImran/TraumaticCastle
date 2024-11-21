using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageChanger : MonoBehaviour
{
    public GameObject image;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;

    // Start is called before the first frame update
    void Start()
    {
        image2.SetActive(false);
        image3.SetActive(false);
        image4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonImage(){
        Destroy(image);
        image2.SetActive(true);
        
    }
}
