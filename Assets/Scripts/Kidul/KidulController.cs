using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidulController : MonoBehaviour {

    // Sadis
    public float fireDelay = 0.1f;
    public float sadisDelay = 10.0f;
    public float rotateSpeed = 2.0f;
    public int bulletSadisCount = 100;

    // Bulet
    public float buletDelay = 2.0f;
    public int buletShootCount = 18;


    public GameObject bullet;
    public GameObject homingBullet;

    public Transform center;
    public Transform bulletNE;
    public Transform bulletSE;
    public Transform bulletNW;
    public Transform bulletSW;

    private bool rotateCenter = false;

    void Start() {
        Invoke("SadisShoot", 10.0f);
        InvokeRepeating("BuletShoot", 0.0f, buletDelay);
    }

    private void Update() {
        if(rotateCenter) {
            center.Rotate(transform.forward * rotateSpeed);
        }
    }

    void BuletShoot() {
        int angleIncrement = 360 / buletShootCount;
        int currentAngle = 0;

        for (int i = 0; i < buletShootCount; i++) {
            Quaternion rotation = transform.rotation;
            rotation *= Quaternion.Euler(0, 0, currentAngle);
            currentAngle += angleIncrement;

            Instantiate(homingBullet, transform.position, rotation);
        }
    }

    void SadisShoot() {
        StartCoroutine(SadisShootCoroutine());
    }

    IEnumerator SadisShootCoroutine() {
        rotateCenter = true;
        for (int i = 0; i < bulletSadisCount; i++) {
            Instantiate(bullet, bulletNE.position, bulletNE.rotation);
            Instantiate(bullet, bulletSE.position, bulletSE.rotation);
            Instantiate(bullet, bulletNW.position, bulletNW.rotation);
            Instantiate(bullet, bulletSW.position, bulletSW.rotation);
            yield return new WaitForSeconds(fireDelay);
        }
        rotateCenter = false;
        yield return new WaitForSeconds(sadisDelay);
        StartCoroutine(SadisShootCoroutine());
    }


}
