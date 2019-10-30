using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10.0f;
 
    void Update()
    {
     float x = Input.GetAxis("Horizontal");
     float y = Input.GetAxis("Vertical");
     Vector2 moveDir = new Vector2(x, y);
     GetComponent<Rigidbody2D>().velocity = moveDir * moveSpeed;
    }
}
