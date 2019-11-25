using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitch : MonoBehaviour
{
   public void GoUP()
    {
        SceneManager.LoadScene("01");
    }

    public void GoDown()
    {
        SceneManager.LoadScene("main");
    }
    
}
