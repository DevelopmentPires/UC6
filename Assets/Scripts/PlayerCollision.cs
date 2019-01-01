using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

    GameObject alien;

  // Use this for initialization
	void Start () {

        alien = GameObject.Find("Alien");
        
        	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Stalack" || collision.transform.tag == "Walls" || collision.transform.tag == "Lava")
        {
            Morreu();
        }

        if (collision.transform.tag == "Platforms")
        {
            Debug.Log("Arvore");
            alien.transform.parent = collision.transform;
        }

        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Key")
        {
            Destroy(other.gameObject);

        }
    }

    //private void OnTriggerEnter(Collider other)
    //{

    //    if (other.transform.tag == "Traps" || other.transform.tag == "Walls")
    //    {
    //        Morreu();
    //    }


    //}

    void Morreu()
    {
        Debug.Log("Morreu!!!");
    }

  
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Platforms")
        {
            alien.transform.parent = null;
        }

    }
}
