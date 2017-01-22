using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnnouncer : MonoBehaviour
{


    void OnMouseDown()
    {
        // this object was clicked - do something
        Destroy(this.gameObject);
    }
    void OnDestroy()
    {
        EventManager.TriggerEvent("Die");
    }
}
