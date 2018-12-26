using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour {

    Rigidbody rb;
    GameObject StalactitesBegin;
    GameObject StalactitesEnd;
    GameObject LeftStoneWall;
    GameObject RightStoneWall;
    public static bool StalactitesBeginActive = false;
    public static bool StalactitesEndActive = false;
    public float countdown = 0f;
    public bool wallCollide = false;
    GameObject returnWall;


    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
        StalactitesBegin = GameObject.Find("Stalactites Begin");
        StalactitesEnd = GameObject.Find("Stalactites End");
        LeftStoneWall = GameObject.Find("ParedeEsmaga (1)");
        RightStoneWall = GameObject.Find("ParedeEsmaga (2)");
        returnWall = GameObject.Find("Collider Return");




    }
	
	// Update is called once per frame
	void Update () {

        if(StalactitesBeginActive)
            StalactitesBegin.transform.Translate(new Vector3(0f,-0.1f,0f));
        if (StalactitesEndActive)
            StalactitesEnd.transform.Translate(new Vector3(0f, -0.1f, 0f));

        
    }

    private void FixedUpdate()
    {

        
    }

    
    public static void AtivouStackBegin() {

        
    }

    public static void AtivouStackEnd()
    {

        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

}
