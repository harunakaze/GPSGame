using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStuff : MonoBehaviour {

    public bool isRunning = false;
    public float waitTime = 5.5f;
    private float currentTime = 0.0f;

    private void Start() {
        Debug.Log("ASD");
    }

    private void Update() {
        if (!isRunning)
            return;
        currentTime += Time.deltaTime;

        if (Input.anyKeyDown && currentTime >= waitTime) {
            Application.LoadLevel(2);
        }
    }
}
