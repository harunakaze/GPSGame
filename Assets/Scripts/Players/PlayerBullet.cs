using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {
	public float speed=0.7f;

    public enum BulletType {
        NW,
        NE,
        SE,
        SW,
    }

    public BulletType type;

	private Transform tf;
	// Use this for initialization
	void Start () {
		tf = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
    if (type == BulletType.NW) {
		tf.position =new Vector3(this.transform.position.x-speed,this.transform.position.y+speed,this.transform.position.z);
		
				}
		else if (type == BulletType.NE) {
		tf.position =new Vector3(this.transform.position.x+speed,this.transform.position.y+speed,this.transform.position.z);
			
				}
		else if (type == BulletType.SE) {
			tf.position =new Vector3(this.transform.position.x+speed,this.transform.position.y-speed,this.transform.position.z);
			
		}
		else if (type == BulletType.SW) {
			tf.position =new Vector3(this.transform.position.x-speed,this.transform.position.y-speed,this.transform.position.z);
			
		}
	}
}
