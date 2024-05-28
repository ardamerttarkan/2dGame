using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class marketscript : MonoBehaviour
{
   public void openmarket()
   {
       SceneManager.LoadScene("market");
   }
    public void backmenu()
    {
         SceneManager.LoadScene("MainMenu");
    }
}
