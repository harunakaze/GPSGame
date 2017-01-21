using UnityEngine;
using System.Collections;

public class EBullet : MonoBehaviour {
    public int speed;
	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(gameObject);
    }
}
