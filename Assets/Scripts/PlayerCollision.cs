using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerCollision : MonoBehaviour {

    private GameObject alien;

    public Text dies;
    static private int countDies;

    // Use this for initialization
    void Start () {

        alien = GameObject.Find("Alien");
       
        	}
	
	// Update is called once per frame
	void Update () {


        dies.text = "You Die " + countDies + " times";
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Stalack" || collision.transform.tag == "Walls" || collision.transform.tag == "Lava" || collision.transform.tag == "Thorns" || collision.transform.tag == "Fim")
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

        if(other.transform.tag == "Fim")
        {
            countDies = -1;
            Morreu();
        }

    }

    void Morreu()
    {
        countDies++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

  
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Platforms")
        {
            alien.transform.parent = null;
        }

    }
}
