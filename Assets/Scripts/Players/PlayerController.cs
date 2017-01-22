using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour, IAttackable {

    public int hitPoints = 10;

    public AudioClip getHit;
    public AudioClip mati;

    public void OnDamageReceived() {
        AudioSource.PlayClipAtPoint(getHit, transform.position);

        hitPoints--;

        if(hitPoints <= 0) {
            AudioSource.PlayClipAtPoint(mati, transform.position);
            Destroy(gameObject);
            Application.LoadLevel(4);
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