
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;
    public float yOffset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + new Vector3(offset.x,yOffset,offset.z); //the position of the camera is equal to the players position, but with an offset added.
    }

    private void Start()
    {
        offset = transform.position;
        //Debug.Log(offset + " | " + player.position + " | " + offset + player.position);
    }
}
