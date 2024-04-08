using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
            if (collision.gameObject.tag == "coin")
        {
            Debug.Log("i got coin");

        }
        Destroy(collision.gameObject);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "coin")
        {
           Debug.Log("i got coin");
           Destroy(collision.gameObject);
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}

