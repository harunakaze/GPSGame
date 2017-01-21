using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtRotator : MonoBehaviour {

    public SpriteRenderer sr;

    void Update () {
        if (!(transform.rotation.eulerAngles.z > 80 && transform.rotation.eulerAngles.z < 260)) {
            sr.flipY = false;
        } else {
            sr.flipY = true;
        }
    }
}
