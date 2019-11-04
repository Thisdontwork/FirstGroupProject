using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class coincollect : MonoBehaviour
{
    public int coinCount = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "coin")
        {
            coinCount++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "badcoin")
        {
            coinCount--;
            Destroy(collision.gameObject);
        }
       
    }
}
