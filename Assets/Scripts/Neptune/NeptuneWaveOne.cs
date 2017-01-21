using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeptuneWaveOne : MonoBehaviour {

    public Transform bulletPlace;
    public GameObject bullet;

    private Transform player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update() {
        ShootShotgun();
    }

    void ShootShotgun() {
        LookAt2D();
    }

    void LookAt2D() {
        //    Vector3 dir = player.position - transform.position;
        //    float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //    transform.rotation = Quaternion.Euler(0f, 0f, angle - 90);

        transform.up = player.position - transform.position;
    }
    
}
