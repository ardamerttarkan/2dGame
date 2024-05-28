using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTarget : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("target"))
        {
          CompleteManager.isCompleted = true;

          GameObject popi = GameObject.Find("Popi");
            if (popi != null)
            {
                Destroy(popi);
            }
          
        }
    }
}
