using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour

{

    public static bool isGameOver;

 
    public GameObject GameOverMenu;
   

    
    
    

    public void Awake()
    {
        isGameOver = false;
       
    }

    public void Update()
    {
        if (isGameOver)
        {
            GameOverMenu.SetActive(true);
            Time.timeScale = 0f;
            
            
        }

        else{
            GameOverMenu.SetActive(false);
            Time.timeScale = 1f;
        }

     
    }
}
