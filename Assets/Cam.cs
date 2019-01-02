using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {

    public GameObject cameraTwo;
    public GameObject cameraPrincipal;

    // Use this for initialization
    void Start () {

        Debug.Log("Quando?");
        Invoke("VoltaPlayer",5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
