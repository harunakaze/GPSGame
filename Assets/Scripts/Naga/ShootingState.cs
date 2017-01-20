using UnityEngine;
using System.Collections;

public class ShootingState : PredatorBaseState {
    public float minBeforeMoving = 15.0f;

    private Transform player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public override void SUpdate() {
        Debug.Log(Vector2.Distance(player.position, transform.position));
        if (Vector2.Distance(player.position, transform.position) >= minBeforeMoving) {
           
            pEngine.SwitchState<ChasingState>();
        }
    }
}
