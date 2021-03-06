﻿using System.Collections;
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
    public float buletWait = 2.5f;
    public int buletDelayEvery;
    private int buletCounter = 0;

    // Satelit
    public float satelitDelay = 7.0f;
    public float satelitTime = 15.0f;
    public GameObject satelitBulet;
    public Transform satlitShooter;

    private Transform player;

    public GameObject bullet;
    public GameObject homingBullet;

    public Transform center;
    public Transform bulletNE;
    public Transform bulletSE;
    public Transform bulletNW;
    public Transform bulletSW;

    private bool rotateCenter = false;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        Invoke("SadisShoot", 10.0f);
        InvokeRepeating("BuletShoot", 0.0f, buletDelay);
        InvokeRepeating("SatelitShot", 7.0f, satelitTime);
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

        buletCounter++;

        if(buletCounter >= buletDelayEvery) {
            CancelInvoke("BuletShoot");
            StartCoroutine(StartBuletAgain());
        }
    }

    void SatelitShot() {
        satlitShooter.up = player.position - transform.position;
        Instantiate(satelitBulet, satlitShooter.position, satlitShooter.rotation);
    }

    void SadisShoot() {
        StartCoroutine(SadisShootCoroutine());
    }

    void StopShooting() {
        CancelInvoke("BuletShoot");
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

    IEnumerator StartBuletAgain() {
        yield return new WaitForSeconds(buletWait);
        InvokeRepeating("BuletShoot", 0.0f, buletDelay);
    }
}
