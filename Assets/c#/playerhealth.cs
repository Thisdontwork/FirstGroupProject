using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerhealth : MonoBehaviour
{
    public int health = 10;
    public Text healthText;
    public Slider healthSlider;
  

    private void Start()
    {
        healthText.text = "Health" + health;
        healthSlider.maxValue = health;
        healthSlider.value = health;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Enemy"))
        {
            health--;
            healthText.text = "Health: " + health;
            healthSlider.value = health;
            if (health < 1)
            {

                SceneManager.LoadScene("lose");
            }
        }
    }
}   

    