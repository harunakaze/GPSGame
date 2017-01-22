using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour {

    public float timer = 10.0f;
    private float currentTimer = 0.0f;
	// Update is called once per frame
	void Update () {
        currentTimer += Time.deltaTime;

        if (Input.anyKeyDown && currentTimer >= timer)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Application.LoadLevel(1);
            Debug.Log("Selesai");
        }
    }
}
