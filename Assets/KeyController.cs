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
   

    private bool exit = false;
    
    // Use this for initialization
    void Start()
    {
        imgKeyGreen.active = false;
        imgKeyBlue.active = false; 
    }
	
	// Update is called once per frame
	void Update () {

        if (KeyGreen == null)
        {
            imgKeyGreen.active = true;
            
        }

        if (KeyBlue == null)
        {
            imgKeyBlue.active = true;
        }

    }

}
