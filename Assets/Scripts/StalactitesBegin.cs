using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalactitesBegin : MonoBehaviour {

    GameObject StalactitesGroup;
    GameObject SensorStalac;
    public static bool StalacActive = false;
    public GameObject groupStack;

    // Use this for initialization
    void Start () {

        StalactitesGroup = GameObject.Find("Stalactites Begin");
        SensorStalac = GameObject.Find("Stalactites Begin/Sensor");

    }

    // Update is called once per frame
    void Update () {

        
        if (StalacActive)
        { 
            StalactitesGroup.transform.Translate(new Vector3(0f, -0.2f, 0f));
        }

    }

    private void FixedUpdate()
    {

       
    }


    private void OnTriggerEnter(Collider other)
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (other.transform.tag == "Player" && !StalacActive)
        {
            StalacActive = true;
            Destroy(SensorStalac);
            


        }
        
         if(other.transform.tag == "Scenario" ||(other.transform.tag == "Player" && StalacActive))
         {
            Destroy(gameObject);
           


        }

        if(StalacActive && groupStack == null && other.transform.tag != "Player")
        {
            StalacActive = !StalacActive;
        }
         

    }



}
