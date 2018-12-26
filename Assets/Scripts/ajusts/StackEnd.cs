using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (collision.transform.tag != "Scenario")
        {
            Destroy(gameObject);
            Traps.AtivouStackEnd();
        }
    }
}
