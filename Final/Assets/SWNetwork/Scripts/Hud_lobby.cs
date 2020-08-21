using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hud_lobby : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void CerrarRaves()
    {
        Application.Quit();
    }
}
