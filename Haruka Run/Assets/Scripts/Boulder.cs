using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    public GameObject holder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            holder.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
