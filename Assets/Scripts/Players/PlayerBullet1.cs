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

    public AudioClip shot;
    public AudioSource sfxPlayer;

	private Transform tf;
	// Use this for initialization
	void Start () {
        sfxPlayer = GameObject.FindGameObjectWithTag("SFXPlayer").GetComponent<AudioSource>();
        tf = this.transform;
        if (type == BulletType.NW)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
            AudioSource.PlayClipAtPoint(shot, transform.position, 100.0f);
        }
        else if (type == BulletType.NE)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
            AudioSource.PlayClipAtPoint(shot, transform.position);


        }
        else if (type == BulletType.SE)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
            AudioSource.PlayClipAtPoint(shot, transform.position);


        }
        else if (type == BulletType.SW)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
            AudioSource.PlayClipAtPoint(shot, transform.position);


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
