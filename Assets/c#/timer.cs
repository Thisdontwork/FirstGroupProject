using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    float timeleft = 15.0f;
    public GameObject prefab;

    private void Start()
    {
        
    }

    private void Update()
    {
        timeleft -= Time.deltaTime;
        if ( timeleft < 0)
        {
            SceneManager.LoadScene("lose");
        }
    }
}
