using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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


}
