using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public bool moveAble;
    public Animator anim;


    /// <summary>
    /// I created a boolean to assign which obstacles are animated. If true, the animation is activated.
    /// </summary>


    // Start is called before the first frame update
    void Start()
    {
        if (moveAble == true)
        {
            anim.SetTrigger("Move");
            //Debug.Log("hallo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
