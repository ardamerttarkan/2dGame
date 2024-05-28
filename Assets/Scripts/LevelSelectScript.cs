using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour
{
    
        public void LoadLevel1()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void LoadLevel2()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }

        public void LoadLevel3()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }

        public void LoadLevel4()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }

        public void LoadLevel5()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
        }

        public void LoadLevel6()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
        }



        public void BackMenu(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

        
