using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttableObjects : MonoBehaviour
{
   void OnCollisionEnter2D (Collision2D collision)
    // identifying if the object is getting cut
    {
        if(collision.gameObject.tag == "Cut")
        {
            Destroy(gameObject);
        }
            
    }


}
