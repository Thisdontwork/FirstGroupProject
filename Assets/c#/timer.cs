using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    float timeleft = 60.0f;

    private void Update()
    {
        timeleft -= Time.deltaTime;
        if ( timeleft < 0)
        {

        }
    }
}
