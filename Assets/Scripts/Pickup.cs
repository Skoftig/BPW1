using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pickup : MonoBehaviour
{

    public UnityEvent pickupEvent;
    public PlayerCollision playerColl;


    void OnTriggerEnter(Collider colliderInfo)
    {

        if (colliderInfo.tag == "Player")
        {
            pickupEvent.Invoke();
            
        }
    }
}
