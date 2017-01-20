using UnityEngine;
using System.Collections;

public class Killable : MonoBehaviour {
    public int hitPoints = 1;

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Projectile")) {

        }
    }
}
