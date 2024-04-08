using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;

public class ArryLoops : MonoBehaviour
{
    [SerializeField] int[] integers;
    [SerializeField] bool[] switches;
    [SerializeField] string[] names;
    [SerializeField] string[] dialogue;
    void Start()
    {
        integers[0] = 7; 
        for( int i = 0; i < integers.Length; i++)
        {
            Debug.Log(integers[i]);
        }
        names = new string[5];
        names[0] = "Robert";
        names[1] = "Fedrick";
    }
}
