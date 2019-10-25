using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void MainMenu()
    {
     
        SceneManager.LoadScene("level 1");
    }
    public void Quitgame()
    {
        Application.Quit();
    }
   
}
