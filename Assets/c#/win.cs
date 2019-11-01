using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "next level")
        {
            SceneManager.LoadScene("level 1");
        }
    }
}
