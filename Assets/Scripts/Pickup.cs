using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pickup : MonoBehaviour
{

    public UnityEvent pickupEvent;
    public PlayerCollision playerColl;


    /// <summary>
    /// In this script the pickup checks if the player character with the 'Player' tag collides with the pickup.
    /// If true, the pickupEvent is invoked which causes the pickup to disappear after the player collides with it.
    /// </summary>

    void OnTriggerEnter(Collider colliderInfo)
    {

        if (colliderInfo.tag == "Player")
        {
            pickupEvent.Invoke();

        }
    }
}
