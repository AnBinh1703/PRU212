using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectFruit : MonoBehaviour
{
    private int apples = 0;

     
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
             Destroy(collision.gameObject);
            apples++;
         }
    }
}
