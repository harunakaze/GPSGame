﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Application.LoadLevel(3);
            Debug.Log("Jalan");
        }
		
	}
}