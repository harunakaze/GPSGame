using UnityEngine;
using System.Collections;

public class ShootingState : PredatorBaseState {
    public float minBeforeMoving = 15.0f;

    public GameObject blt;

    private Transform player;

    float d=0;
    bool s = true;

    public Transform shot; 
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public override void SUpdate() {
        transform.up = player.position - transform.position;
        d = d + Time.deltaTime;
        Debug.Log(d);
        if (d%2>=1&&s==true)
        {
            Shoot();
            s = false;
        }
        else if (d%2<1&&s!=true)
        {
            s = true;
            
        }

        

        if (Vector2.Distance(player.position, transform.position) >= minBeforeMoving) {
           
            pEngine.SwitchState<ChasingState>();
        }
    }

    void Shoot() {
        //Vector3 shootpos = new Vector3(this.transform.position.x - (0.1f * Mathf.Sin(this.transform.rotation.z)), this.transform.position.y + (0.1f * Mathf.Cos(this.transform.rotation.z)), this.transform.position.z);

        Instantiate(blt, shot.position,this.transform.rotation);

    }
}
