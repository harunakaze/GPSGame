using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour, IAttackable {

    public int hitPoints = 10;

    public void OnDamageReceived() {
        hitPoints--;

        if(hitPoints <= 0) {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("EProj"))
            OnDamageReceived();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("EProj"))
            OnDamageReceived();
    }
}

internal interface IAttackable {
    void OnDamageReceived();
}