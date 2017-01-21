﻿using UnityEngine;
using System.Collections;

public class WaitKill : PredatorBaseState {

    public float watchDistance = 10.0f;

    private Transform player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public override void SUpdate() {
        if (Vector2.Distance(player.position, transform.position) <= watchDistance) {
            pEngine.SwitchState<ChaseHide>();
        }
    }
}
