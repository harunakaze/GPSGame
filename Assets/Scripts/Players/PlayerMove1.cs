using UnityEngine;
using System.Collections;

public class PlayerMove1 : MonoBehaviour {
	public float vspeed = 5f;
    public float hspeed = 7f;
    //public float hspeed=0.07f;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		this.transform.Translate (new Vector3 (0, v, 0) * Time.deltaTime * vspeed);
		this.transform.Rotate (new Vector3 (0, 0, -h) * hspeed);
		


	}

	}

