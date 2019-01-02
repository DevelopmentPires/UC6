using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePortao : MonoBehaviour {

    public GameObject cameraTwo;
    public GameObject cameraPrincipal;
    public GameObject KeyGreen;
    public GameObject KeyBlue;
    public Animator animim;
    public GameObject particulasWin;
    private bool pass = false;

    // Use this for initialization
    void Start () {

        animim = GetComponent<Animator>();

     
    }
	
	// Update is called once per frame
	void Update () {

        if (KeyGreen == null && KeyBlue == null && pass == false)
        {

            cameraTwo.SetActive(true);
            cameraPrincipal.SetActive(false);
            animim.enabled = true;
            particulasWin.SetActive(true);
            Invoke("VoltaPlayer",5f);
        }



	}

    private void VoltaPlayer()
    {
        
        cameraPrincipal.SetActive(true);
        cameraTwo.SetActive(false);
        pass = true;
        Invoke("EncerraAnimim",0f);

    }

    private void EncerraAnimim() {

        animim.enabled = false;
    }
}
