using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision)
   {
        if(collision.gameObject.tag == "level 1p")
        {
            SceneManager.LoadScene("Level2");
        }
        if(collision.gameObject.tag == "Level 2p")
        {
            SceneManager.LoadScene("Shop");
        }
        if(collision.gameObject.tag == "Level 3p")
        {
            SceneManager.LoadScene("Level4");
        }
        if(collision.gameObject.tag == "Level 4p")
        {
            SceneManager.LoadScene("shop");
        }
   }
}
