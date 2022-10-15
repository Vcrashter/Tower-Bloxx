using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowLevel : MonoBehaviour
{
    private FloorsPool floorsPool;
    Rigidbody rb;

    [SerializeField] private float speed = 2;
    private bool canMove = true;

    private direction _direction;
    private enum direction
    {
        Left,
        Right
    }

    void Start()
    {
        GetRigidBody();
        StartDirection();
    }

    private void StartDirection()
    {
        int randomRange = UnityEngine.Random.Range(0, 2);
        if (randomRange == 0)
        {
            _direction = direction.Left;
        }
        else
        {
            _direction = direction.Right;
        }
    }

    void GetRigidBody()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void Update()
    {
        InputTouch();
        MovingDirection();
    }

    private void MovingDirection()
    {
        if (canMove)
        {
            if (_direction == direction.Left)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed * -1);
            }

            if (_direction == direction.Right)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }

            if (transform.position.x >= 1)
            {
                _direction = direction.Left;
            }

            if (transform.position.x <= -1)
            {
                _direction = direction.Right;
            }
        }
    }

    void InputTouch()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.useGravity = true;
            canMove = false;
        } 
    }
    
    public void AssignFloorPool(FloorsPool fp)
    {
        floorsPool = fp;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (floorsPool == null)
        {
            return;
        }
        floorsPool.MakeTrue();
        floorsPool = null;
    }

}