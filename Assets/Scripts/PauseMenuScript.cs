using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
   
    [SerializeField] GameObject PauseMenu;
    

  public void Pause()
    {
      PauseMenu.SetActive(true); 
      Time.timeScale = 0f;
      
    }

    public void Resume()
    {
        
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }


    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

   
}
