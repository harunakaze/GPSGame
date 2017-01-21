using UnityEngine;
using System.Collections;

public class PlayerBullet1 : MonoBehaviour {
	public float speed=800f;

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
        if (type == BulletType.NW)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);

        }
        else if (type == BulletType.NE)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);

        }
        else if (type == BulletType.SE)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);

        }
        else if (type == BulletType.SW)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);

        }
	}
	
	// Update is called once per frame
	void Update () {

    
	}
    void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(gameObject);
    }
}
