using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float Rspeed;


    private Rigidbody2D rb;
    private PAC pac;
    private Vector2 target;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        pac = GetComponent<PAC>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        UpDateTargetDirection();
        Rotate();
        SetVelocity();
    }

    private void UpDateTargetDirection()
    {
        if (pac.AwareOfPlayer)
        {
            target = pac.DirectionToPlayer;
        }
        else
        {
            target = Vector2.zero;
        }
    }

    private void Rotate()
    {
        if (target == Vector2.zero)
        {
            return;
        }
        Quaternion targetRotation = Quaternion.LookRotation(transform.forward, target);
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Rspeed * Time.deltaTime);
        rb.SetRotation(rotation);
    }

    private void SetVelocity()
    {
        if (target == Vector2.zero)
        {
            rb.velocity = Vector2.zero;
        }
        else
        {
            rb.velocity = transform.up * speed;
        }
    }

}
