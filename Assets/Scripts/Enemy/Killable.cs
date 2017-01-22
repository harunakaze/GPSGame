using UnityEngine;
using System.Collections;

public class Killable : MonoBehaviour {
    public int hitPoints = 1;
    public bool isKillable = true;

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
            Destroy(art);
        }
        else {
            Destroy(gameObject);
        }
    }
}
