using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AturMenu : MonoBehaviour {

    public Button play;

    public float timer = 2.0f;
    private float currentTimer = 0.0f;

    void Update() {
        //currentTimer += Time.deltaTime;

        //if (Input.anyKeyDown && currentTimer >= timer)
        //    Application.LoadLevel(2);
    }
}
