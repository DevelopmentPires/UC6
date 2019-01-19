using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour {

    GameObject alien;

    // Use this for initialization
    void Start () {
        alien = GameObject.Find("Alien");
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    // Não esta funcionando adequadamente
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            alien.transform.parent = null;
        }
    }
}
