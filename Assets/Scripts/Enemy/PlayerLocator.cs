using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocator : MonoBehaviour {

    private AILerp aiLerp;

    private void Start() {
        aiLerp = GetComponent<AILerp>();

        aiLerp.target = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
