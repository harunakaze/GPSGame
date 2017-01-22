using UnityEngine;
using System.Collections;

public class Killable : MonoBehaviour {
    public int hitPoints = 1;
    public bool isKillable = true;

    public GameObject powerUp;

    public GameObject art;

    void OnCollisionEnter2D(Collision2D other) {
        if (!isKillable)
            return;

        if(other.gameObject.CompareTag("Projectiles")) {
            hitPoints--;

            if(hitPoints <= 0) {
                Die();
            }
        }
    }

    void Die() {
        if (tag == "Neptune") {
            Instantiate(powerUp, transform.position, transform.rotation);
            Destroy(art);
        } else if(tag == "Kidul") {
            Instantiate(powerUp, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }
}
