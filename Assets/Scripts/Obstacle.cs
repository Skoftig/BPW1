using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public bool moveAble;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        if (moveAble == true)
        {
            anim.SetTrigger("Move");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
