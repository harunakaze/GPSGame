using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {
    Transform tr;
	// Use this for initialization
	void Start () {
        tr = transform;
        InvokeRepeating("floating", 1, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void floating() {
        tr.Translate(new Vector3(Random.Range(-2, 2), Random.Range(-2, 2),tr.position.z)*Time.deltaTime*4);
    }
}
