using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyController : MonoBehaviour {

    public GameObject KeyGreen;
    public GameObject KeyBlue;
    public GameObject imgKeyGreen;
    public GameObject imgKeyBlue;
    
    // Use this for initialization
    void Start()
    {
        imgKeyGreen.SetActive(false);
        imgKeyBlue.SetActive(false); 
    }
	
	// Update is called once per frame
	void Update () {

        if (KeyGreen == null)
        {
            imgKeyGreen.SetActive(true);
            
        }

        if (KeyBlue == null)
        {
            imgKeyBlue.SetActive(true);
        }



    }

}
