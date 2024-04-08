using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 100; // int is a integer which is a number such as hp, exp
        float velocity = 0.4f; // float is used for decimals such as velocity, and chances such as crit
        string name = "seraph"; // strings can be as long as you want such as text for items and npc
        bool isAlive = true; // used for true or false senerios 
        // all diffrent ways to change int/float values
        health = health - 1;
        health -= 1;
        health += 25;
        health--; //this spectial funtion does inraments in negative and do positive
        health++; //^same
        if(health <= 0)
        {
            isAlive = false;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
