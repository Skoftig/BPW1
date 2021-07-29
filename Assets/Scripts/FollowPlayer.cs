
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;
    public float yOffset;


    /// <summary>
    /// this script is for the Main camera to follow the player's position. This is done by making the camera's position
    /// equal to that of the player, with an offset added on the y-axis. This offset is a public float to make it 
    /// easily accessible in the Unity Editor.
    /// </summary>

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
