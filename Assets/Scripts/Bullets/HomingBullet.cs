using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingBullet : MonoBehaviour {

    public float startHoming = 0.23f;
    public float homingSpeed;
    public float speed;
    private Rigidbody2D rigidbody;
    private Transform player;

    void Start() {
        rigidbody = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if(player == null) {
            return;
        }

        //rigidbody.velocity = transform.forward * speed;
        rigidbody.AddForce(transform.up * speed);

        Invoke("StartHoming", startHoming);
    }

    void StartHoming() {
        if (player == null) {
            return;
        }

        rigidbody.velocity = Vector2.zero;
        Vector2 direction = player.position - transform.position;

        rigidbody.AddForce(direction.normalized * homingSpeed);
    }

    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }
}
