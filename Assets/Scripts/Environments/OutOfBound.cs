using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBound : MonoBehaviour {

    void OnColliderEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player")
        {
            Destroy(other.gameObject);

        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag != "Player") {
            Destroy(other.gameObject);

        }
    }
}
