using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //reference to the rigidbody component called 'rb'
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public bool inCoroutine = false;
    public float speed;

    // marked this as 'Fixed'Update because we are using it to mess with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //speed that player launches itself with on the z-axis

        if (Input.GetKey(KeyCode.D)) //causes player to move to the right
        {
            rb.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
   
        }

        if (Input.GetKey("a")) //causes player to move to the left
        {
            rb.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
            
        }

        
        if (Input.GetKey("w")) //causes player to move upwards
        {
            rb.MovePosition(transform.position + Vector3.up * speed * Time.deltaTime);
            
        }

        if (Input.GetKey("s")) //causes player to move downwards
        {
            rb.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);
            
        }

        if (Input.anyKey == false) //wanneer er geen key word ingedrukt
        {
            var pos = rb.position; //pakt positie van player rigidbody
            float returnX = 0; // positie waar ie naartoe moet
            
            pos.x = Mathf.Lerp(pos.x, returnX, 7.5f * Time.deltaTime);  // lerp zorg voor smooth transitie van huidige x pos naar x pos 0
            rb.position = pos;
        }

        
        if (rb.position.y < -1f)  //checks if player fell off the ground plane
        {
            FindObjectOfType<GameManager>().EndGame();
        }


    }

 
}
