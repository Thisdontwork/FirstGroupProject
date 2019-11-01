using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    float timeleft = 60.0f;
    public GameObject prefab;

    private void Update()
    {
        timeleft -= Time.deltaTime;
        if ( timeleft < 0)
        {
            
        }
    }
}
