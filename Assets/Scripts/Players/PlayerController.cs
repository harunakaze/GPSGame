using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour, IAttackable {

    public int hitPoints = 10;

    public void OnDamageReceived() {
        hitPoints--;

        if(hitPoints <= 0) {
            Debug.Log("DIE");
        }
    }
}

internal interface IAttackable {
    void OnDamageReceived();
}