using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int r = Random.Range(1, 21);
        float r2 = Random.Range(1.0f, 20.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
