﻿using UnityEngine;
using System.Collections;

public class AttackState : PredatorBaseState {


    public float attackSpeed = 0.73f;

    public PlayerController pc;
    private bool isAttacking = false;
    private float timer = 0;

    public override void SEnter() {
        Debug.Log("WWW");
    }

    public override void SUpdate() {
        // Good old timer
        if (isAttacking) {
            timer += Time.deltaTime;

            if (timer >= attackSpeed) {
                Attack();
                timer = 0;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) {
            // First attack
            Attack();

            StartAttacking();
        }
    }

    void OnCollisionStay2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) {
            StartAttacking();
        }
    }

    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) {
            StopAttacking();
        }
    }

    void Attack() {
        pc.OnDamageReceived();
    }

    void StartAttacking() {
        isAttacking = true;
    }

    void StopAttacking() {
        isAttacking = false;

        // Reset timer
        timer = 0;
    }
}
