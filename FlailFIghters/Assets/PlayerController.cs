﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{

    Rigidbody2D body;
    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    public float runSpeed = 20;

    public string horizontalInput = "Horizontal";
    public string verticalInput = "Vertical";

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw(horizontalInput);
        vertical = Input.GetAxisRaw(verticalInput);
    }

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0)
            body.velocity = new Vector2((horizontal * runSpeed) * moveLimiter, (vertical * runSpeed) * moveLimiter);
        else
            body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}