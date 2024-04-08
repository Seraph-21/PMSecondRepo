using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class GravDeBuff : MonoBehaviour
{
    public GameObject Boulder;
    private object getComponent;
    public float gravityScale;
    //public float WaitTime = 0f;
    //public float TimeDuration = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Boulder = GetComponent<GameObject>();
       // WaitTime -=Time.deltaTime;
    }

    void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().gravityScale = gravityScale;
;
        }
    }
    void update()
    {
       // if(WaitTime <= TimeDuration)
       //   {
       //     gravityScale == false;
       //   }
       // else
       // {
       //     gravityScale == true;
       // }
    }
}   
