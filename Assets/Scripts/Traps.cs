using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour {

    Rigidbody rb;
    GameObject StalactitesBegin;
    public static bool StalactitesBeginActive = false;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
        StalactitesBegin = GameObject.Find("Stalactites Begin");


    }
	
	// Update is called once per frame
	void Update () {

        if(StalactitesBeginActive)
            StalactitesBegin.transform.Translate(new Vector3(0f,-0.1f,0f));


    }

    public static void AtivouStack() {

        StalactitesBeginActive = true;

    }

}
