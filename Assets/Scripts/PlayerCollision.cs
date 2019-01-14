using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerCollision : MonoBehaviour {

    private GameObject alien;

    public Text dies;
    public Text gens;
    static private int countDies;
    static private int Dimonds = 0;
    public float vida = 100;
    public Image barraVida;

    // Use this for initialization
    void Start () {

        alien = GameObject.Find("Alien");
       
        	}
	
	// Update is called once per frame
	void Update () {


        dies.text = "You Die " + countDies + " times";
        gens.text = Dimonds.ToString();

        if(vida <= 0)
        {
            Morreu();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Walls" || collision.transform.tag == "Lava" || collision.transform.tag == "Fim")
        {
            Handheld.Vibrate();
            Morreu();
        }

        if (collision.transform.tag == "Stalack" || collision.transform.tag == "Thorns")
        {
            vida -= 50;
            barraVida.fillAmount = (vida / 100);
            Handheld.Vibrate();
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

        if (other.transform.tag == "Diamond")
        {
            Dimonds++;
            Destroy(other.gameObject);
        }

    }

    void Morreu()
    {
        countDies++;
        Dimonds = 0;
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
