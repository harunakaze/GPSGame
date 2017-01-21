using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelitBulet : MonoBehaviour {

    public GameObject bullet;
    public int waveCount = 3;
    private int currentWave = 0;

    // Bulet
    public float buletDelay = 1.0f;
    public int buletShootCount = 18;


    private Vector3 playerPos;
    public float speed;
    private Rigidbody2D rigidbody;

    private bool isStarted = false;

    void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;

        rigidbody.AddForce(transform.up * speed);
    }

    void Update() {
        if (Vector3.Distance(transform.position, playerPos) <= 0.5f && !isStarted) {
            StartShooting();
            isStarted = true;
        }
    }

    void StartShooting() {
        rigidbody.velocity = Vector3.zero;
        InvokeRepeating("BuletShoot", 0.0f, buletDelay);
    }

    void BuletShoot() {
        int angleIncrement = 360 / buletShootCount;
        int currentAngle = 0;

        for (int i = 0; i < buletShootCount; i++) {
            Quaternion rotation = transform.rotation;
            rotation *= Quaternion.Euler(0, 0, currentAngle);
            currentAngle += angleIncrement;

            Instantiate(bullet, transform.position, rotation);
        }

        currentWave++;

        if(currentWave >= waveCount) {
            Destroy(gameObject);
        }
    }
}
