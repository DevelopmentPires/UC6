﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationKeys : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(new Vector3(50f,0f,0f) * Time.deltaTime);
		
	}
}
