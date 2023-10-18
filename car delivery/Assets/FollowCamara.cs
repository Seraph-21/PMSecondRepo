using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamara : MonoBehaviour
{
    //should have same position as car

    [SerializeField] GameObject thingToFollow;
    void LateUpdate()
    {
        transform.position =thingToFollow.transform.position + new Vector3 (0,0, -15);
    }
}
