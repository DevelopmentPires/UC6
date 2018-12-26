using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalactitesEnd : MonoBehaviour {

    GameObject StalactitesGroup;
    GameObject SensorStalac;
    public static bool StalacActiveDois = false;

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
    private void OnCollisionEnter(Collision collision)
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (collision.transform.tag == "Player" && !StalacActiveDois)
        {
            StalacActiveDois = true;
            Destroy(SensorStalac);

        }

        if (collision.transform.tag == "Scenario" || (collision.transform.tag == "Player" && StalacActiveDois))
        {
            Destroy(gameObject);
            
        }


    }
}
