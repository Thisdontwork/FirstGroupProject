using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerhealth : MonoBehaviour
{
    public int Health = 10;
    public int lives = 10;
    public Text healthText;
    public Slider healthSlider;
    private void Start()
    {
        healthText.text = "Health" + Health;
        healthSlider.maxValue = Health;
        healthSlider.value = Health;
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Health--;
            healthText.text = "Health" + Health;
            healthSlider.value = Health;
           if(Health < 1)
            {
                if (Health < 1)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    PlayerPrefs.SetInt("lives", lives - 1);
                }
                else
                {

                }
            }
           
        }
    }
}   

    