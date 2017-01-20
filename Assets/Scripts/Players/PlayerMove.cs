using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public float vspeed=0.07f;
	public float hspeed=0.07f;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			rb.MovePosition(new Vector3 (this.transform.position.x,this.transform.position.y+vspeed,this.transform.position.z));
//			this.GetComponent<Rigidbody>().AddForce(0,50000,0);
				}
		if (Input.GetKey(KeyCode.D)) {
			rb.MovePosition(new Vector3 (this.transform.position.x+hspeed,this.transform.position.y,this.transform.position.z));
		}
		if (Input.GetKey(KeyCode.S)) {
			rb.MovePosition(new Vector3 (this.transform.position.x,this.transform.position.y-vspeed,this.transform.position.z));
		}
		if (Input.GetKey(KeyCode.A)) {
			rb.MovePosition(new Vector3 (this.transform.position.x-hspeed,this.transform.position.y,this.transform.position.z));
		}
	}
}
