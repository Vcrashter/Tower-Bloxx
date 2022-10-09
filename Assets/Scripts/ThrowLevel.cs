using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowLevel : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        AddRigidBody();
    }
    void AddRigidBody()
    {
        rb = gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
    }



    void Update()
    {
        InputSpace();
        InputTouch();
        MovingPosition();
        }

    void InputTouch()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            rb.useGravity = true;
        } 
    }

    void InputSpace()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.useGravity = true;
        }
    }

    void MovingPosition()
    {
        transform.position = new Vector3(200f, 20f, 0f);
    }

}