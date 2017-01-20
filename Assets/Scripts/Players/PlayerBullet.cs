using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {
	public float speed=0.7f;
	private Transform tf;
	// Use this for initialization
	void Start () {
		tf = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
	if (this.tag=="NW") {
		tf.position =new Vector3(this.transform.position.x-speed,this.transform.position.y+speed,this.transform.position.z);
		
				}
		else if (this.tag=="NE") {
		tf.position =new Vector3(this.transform.position.x+speed,this.transform.position.y+speed,this.transform.position.z);
			
				}
		else if (this.tag=="SE") {
			tf.position =new Vector3(this.transform.position.x+speed,this.transform.position.y-speed,this.transform.position.z);
			
		}
		else if (this.tag=="SW") {
			tf.position =new Vector3(this.transform.position.x-speed,this.transform.position.y-speed,this.transform.position.z);
			
		}
	}
}
