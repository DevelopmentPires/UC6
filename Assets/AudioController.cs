using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    public AudioClip wallHit;
    public AudioSource source;

    
    // Use this for initialization
    void Awake () {

    
    }


    private void Start()
    {
//        
    }

    // Update is called once per frame
    void Update () {

        

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Walls")
        {
            source.PlayOneShot(wallHit, 1f);
        }
    }

}
