﻿using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	public GameObject nw;
	public GameObject sw;
	public GameObject ne;
	public GameObject se;

    public Transform nwPos;
    public Transform swPos;
    public Transform nePos;
    public Transform sePos;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Q)) {
		Instantiate (nw, nwPos.position, nwPos.rotation);
			
				}
		if (Input.GetKeyDown(KeyCode.E)) {
			Instantiate (ne, nePos.position, nePos.rotation);
			
		}
		if (Input.GetKeyDown(KeyCode.C)) {
			Instantiate (se, sePos.position, sePos.rotation);
			
		}
		if (Input.GetKeyDown(KeyCode.Z)) {
			Instantiate (sw, swPos.position, swPos.rotation);
			
		}
		//		this.transform.position =new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);

	}
}
