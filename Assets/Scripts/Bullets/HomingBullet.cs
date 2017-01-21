using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingBullet : MonoBehaviour {

    public float speed;
    private Rigidbody2D rigidbody;

    void Start() {
        rigidbody = GetComponent<Rigidbody2D>();

        //rigidbody.velocity = transform.forward * speed;
        rigidbody.AddForce(transform.up * speed);
    }

    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }
}
