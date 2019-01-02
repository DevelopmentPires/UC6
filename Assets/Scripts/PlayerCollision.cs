using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

    private GameObject alien;
    public GameObject particulaKeyGreen;
    public GameObject particulaKeyBlue;

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
