using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AturMenu : MonoBehaviour {

    public Button play;

    public void mulai()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Application.LoadLevel(2);
        Debug.Log("Mulai");
    }
}
