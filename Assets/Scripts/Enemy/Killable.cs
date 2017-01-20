using UnityEngine;
using System.Collections;

public class Killable : MonoBehaviour {
    public int hitPoints = 1;

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("SS");
        if(other.gameObject.CompareTag("Projectiles")) {
            hitPoints--;

            if(hitPoints <= 0) {
                Die();
            }
        }
    }

    void Die() {
        Destroy(gameObject);
    }
}
