using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class LIstLooping : MonoBehaviour
{
    [SerializeField] List<int> integers;
    // Start is called before the first frame update
    void Start()
    {
        integers.Add(47);
        integers.Add(42);
        integers.Add(43);
        integers.Add(-10);
        integers.Add(0);
        integers.Sort();
        for (int i = 0; i < integers.Count; i++)
        { 
            Debug.Log(integers[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
