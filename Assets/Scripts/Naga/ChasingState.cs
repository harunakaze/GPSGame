using UnityEngine;
using System.Collections;

public class ChasingState : PredatorBaseState {
    public float minBeforeShooting = 30.0f;

    private Transform player;
    private AILerp aiLerp;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        aiLerp = GetComponent<AILerp>();
    }

    public override void SEnter() {
        aiLerp.enabled = true;
    }

    public override void SUpdate() {
        if(Vector2.Distance(player.position, transform.position) <= minBeforeShooting) {
            pEngine.SwitchState<ShootingState>();
        }
    }

    public override void SExit() {
        aiLerp.enabled = false;
    }
}
