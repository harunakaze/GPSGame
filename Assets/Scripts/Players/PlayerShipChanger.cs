using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipChanger : MonoBehaviour {

    public PlayerController pc;
    public Animator ar;

    void Update() {
        //if(pc.hitPoints >= 20) {
        //    sr.sprite = duaPuluh;
        //} else if(pc.hitPoints >= 10) {
        //    sr.sprite = sepuluh;
        //} else if(pc.hitPoints >= 5) {
        //    sr.sprite = lima;
        //}
        if(pc.hitPoints <= 15) {
            ar.enabled = true;
        }
    }
}
