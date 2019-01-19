using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadGame : MonoBehaviour {

    // Use this for initialization

    public GameObject preFabStalackBegin;
    public GameObject preFabStalackEnd;

    private void Awake()
    {
        Instantiate(preFabStalackBegin);
        Instantiate(preFabStalackEnd);


    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
