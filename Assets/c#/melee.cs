﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melee : MonoBehaviour
{
    public GameObject prefab;
    public float meleetime = 0.01f;
    public float meleedelay = 1.0f;
    float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButton("Fire1") && timer > meleedelay)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Debug.Log(mousePosition);
            Vector2 shootDir = new Vector2(mousePosition.x - transform.position.x,
                mousePosition.y - transform.position.y);
            shootDir.Normalize();
            bullet.transform.up = shootDir;
            Destroy(bullet, meleetime);
        }
    }
}
