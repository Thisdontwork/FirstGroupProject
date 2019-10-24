﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemypace : MonoBehaviour
{
    float timer = 0;
    public Vector2 moveDir;
    public float moveSpeed = 3.0f;
    public float paceDuration = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        moveDir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= paceDuration)
        {
            //do someting
            moveDir *= -1;
            timer = 0;
        }
        GetComponent<Rigidbody2D>().velocity = moveDir;
    }
}
