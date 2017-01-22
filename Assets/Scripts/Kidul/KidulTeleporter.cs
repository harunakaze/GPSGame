using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidulTeleporter : MonoBehaviour {

    public Killable killable;

    public Transform kidulPlaces2;
    public Transform kidulPlaces3;

    private int currentPos = 1;

    private void Update() {
        if (killable.hitPoints <= 16 && currentPos == 1) {
            killable.hitPoints = 16;
            transform.position = kidulPlaces2.position;
            currentPos++;
        }
        //} else if(killable.hitPoints <= 16 && currentPos == 2) {
        //    killable.hitPoints = 16;
        //    transform.position = kidulPlaces3.position;
        //    currentPos++;
        //}
    }

}
