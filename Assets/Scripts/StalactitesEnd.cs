using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalactitesEnd : MonoBehaviour {

    GameObject StalactitesGroup;
    GameObject SensorStalac;
    public static bool StalacActiveDois = false;
    public GameObject groupStack;

    // Use this for initialization
    void Start () {

        StalactitesGroup = GameObject.Find("Stalactites End");
        SensorStalac = GameObject.Find("Stalactites End/Sensor");

    }

    // Update is called once per frame
    void Update () {

        if (StalacActiveDois)
        {
            StalactitesGroup.transform.Translate(new Vector3(0f, -0.09f, 0f));
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (other.transform.tag == "Player" && !StalacActiveDois)
        {
            StalacActiveDois = true;
            Destroy(SensorStalac);

        }

        if (other.transform.tag == "Scenario" || (other.transform.tag == "Player" && StalacActiveDois))
        {
            Destroy(gameObject);
            
        }

        if (StalacActiveDois && groupStack == null && other.transform.tag != "Player")
        {
            StalacActiveDois = !StalacActiveDois;
        }


    }
}
