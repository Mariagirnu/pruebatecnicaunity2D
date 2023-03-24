using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovi : MonoBehaviour
{
    public float runspeed = 2;

    public float jumpspeed = 3;

    Rigidbody2D rigid2D;


    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

        
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) && Input.GetKey("right") 
        {
               
        }
    }
}
