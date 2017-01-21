using UnityEngine;
using System.Collections;

public class ChaseHide : PredatorBaseState {

    public float minBeforeShooting = 3.12f;

    [Range(0.0f, 1.0f)]
    public float transparentOpacity = 0.56f;

    public Sprite showed;

    private Transform player;
    private AILerp aiLerp;
    public SpriteRenderer sr;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        aiLerp = GetComponent<AILerp>();
    }

    public override void SEnter() {
        aiLerp.enabled = true;
    }

    public override void SUpdate() {
        if (Vector2.Distance(player.position, transform.position) <= minBeforeShooting) {
            pEngine.SwitchState<AttackState>();
        }
    }

    public override void SExit() {
        sr.sprite = showed;
    }
}
