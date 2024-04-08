using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Mathematics;
using UnityEngine;


public class ProjectTileLaunch : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform launchPoint;
    public float shootTime;
    public float shootCounter;
    // Start is called before the first frame update
    void Start()
    {
        shootCounter = 0;
        shootCounter = shootTime;
    }
    // Update is called once per frame
    void Update()
    {
        shootCounter -= Time.deltaTime; 
    }
    void OnLeftprojectile( )
    {

        if (shootCounter < 0)
        {
            Instantiate(projectilePrefab, launchPoint.position, Quaternion.identity);
            shootCounter = shootTime;
            shootCounter -= Time.deltaTime;
        }
    }
    void OnRightprojectile()
    {
        
        if (shootCounter < 0)
        {
            Instantiate(projectilePrefab, launchPoint.position, Quaternion.identity);
            shootCounter = shootTime;
            shootCounter -= Time.deltaTime;
        }
    }
}