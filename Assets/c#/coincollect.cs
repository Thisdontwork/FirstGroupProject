using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class coincollect : MonoBehaviour
{
    public int coinCount = 0;
    public Text coinText;

    private void Start()
    {
        coinText.text = "Coins: " + coinCount;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "coin")
        {
            coinCount++;
            coinText.text = "Coins: " + coinCount;
            Destroy(collision.gameObject);
        }
        
    }
}
