using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public int Health = 10;
    public GameObject Prefab;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Arrow")
        {
            Health--;

            if(Health < 1)
            {
                Destroy(gameObject);
                GameObject Coin = Instantiate(Prefab, transform.position, Quaternion.identity);
            }
        }
    }
}
