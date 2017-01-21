using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeptuneWave : MonoBehaviour {

    public int bulletOneCount = 20;
    public Transform bulletPlace;
    public GameObject bullet;

    private Transform player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        InvokeRepeating("ShootShotgun", 0.1f, 2.0f);
    }

    private void Update() {
        LookAt2D();
    }

    void ShootShotgun() {
        bool playerTargeted = false;
        const int angleIncrement = 10;
        int currentAngle = 0;

        for (int i = 0; i < bulletOneCount; i++) {
            Quaternion rotation = transform.rotation;

            //if(!playerTargeted && Random.Range(0.0f, 1.0f) > 0.5f || i == bulletOneCount - 1) {
            //    rotation *= Quaternion.identity;
            //    playerTargeted = true;
            //} else {
            //    rotation *= Quaternion.Euler(0, 0, currentAngle);
            //}
            rotation *= Quaternion.Euler(0, 0, currentAngle);
            Instantiate(bullet, bulletPlace.position, rotation);

            currentAngle += angleIncrement;

            rotation = transform.rotation;
            rotation *= Quaternion.Euler(0, 0, currentAngle);
            Instantiate(bullet, bulletPlace.position, rotation);

            rotation = transform.rotation;
            rotation *= Quaternion.Euler(0, 0, -currentAngle);
            Instantiate(bullet, bulletPlace.position, rotation);
        }
    }

    void LookAt2D() {
        //    Vector3 dir = player.position - transform.position;
        //    float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //    transform.rotation = Quaternion.Euler(0f, 0f, angle - 90);
        if (player == null)
            return;

        transform.up = player.position - transform.position;
    }
    
}
