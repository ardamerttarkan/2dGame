using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteManager : MonoBehaviour
{
   
   public static bool isCompleted;
   public GameObject MissionCompleteCanvas;

   private void Awake()
   {
       isCompleted = false;
   }

   void Update()
   {
       if (isCompleted)
       {
           MissionCompleteCanvas.SetActive(true);
           
       }
       else
       {
           MissionCompleteCanvas.SetActive(false);
           
       }
   }
}
