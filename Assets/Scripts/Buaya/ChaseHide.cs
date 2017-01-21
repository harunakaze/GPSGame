using UnityEngine;
using System.Collections;

public class ChaseHide : PredatorBaseState {

    public float minBeforeShooting = 3.12f;

    [Range(0.0f, 1.0f)]
    public float transparentOpacity = 0.56f;

    private Transform player;
    private AILerp aiLerp;
    private SpriteRenderer sr;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        aiLerp = GetComponent<AILerp>();
        sr = GetComponent<SpriteRenderer>();
    }

    public override void SEnter() {
        aiLerp.enabled = true;

        Color transparent = sr.color;
        transparent.a = transparentOpacity;

        sr.color = transparent;
    }

    public override void SUpdate() {
        if (Vector2.Distance(player.position, transform.position) <= minBeforeShooting) {
            pEngine.SwitchState<AttackState>();
        }
    }

    public override void SExit() {
        Color fullColor = sr.color;
        fullColor.a = 1.0f;

        sr.color = fullColor;
    }
}
