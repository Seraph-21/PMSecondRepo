using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanOperations : MonoBehaviour
{
    bool hasCakeMix = true;
    bool hasEggs = true;
    bool hasFlour = true;
    bool hasOil = true;
    bool hasSugar = true;
    bool hasMoney = true;

    // Start is called before the first frame update
    void Start()
    {
        if (hasMoney)
        {
            Debug.Log("Uber Eats gonna bring me some cake");
        }
        else if (hasCakeMix)
        {
            Debug.Log("Making this betty  crockercake mix!");
        }
        else if (hasEggs && hasFlour && hasOil && hasSugar)
        {
            Debug.Log("its a bit of work but i still got cake");
        }
        else
        {
            Debug.Log(" we are sad");

        }

        if (hasMoney || hasCakeMix|| hasEggs && hasOil && hasSugar && hasFlour)
        {
            Debug.Log("lets eat the cake");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
