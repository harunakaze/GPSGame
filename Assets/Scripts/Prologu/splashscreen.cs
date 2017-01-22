using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splashscreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(waitanimation());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator waitanimation()
    {
        yield return new WaitForSeconds(1.5f);
        Application.LoadLevel(1);
    }
}
