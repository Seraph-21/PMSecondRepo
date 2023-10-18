using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackagecolor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackagecolor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;
    bool hasPackage = false;
    [SerializeField] float destoryDelay = 0.5f;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    
    
    }
   void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("license revoked");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package Picked Up");
            hasPackage = true;
            spriteRenderer.color=hasPackagecolor;
            Destroy(other.gameObject, destoryDelay);
           
           
        }
        if (other.tag == "customer" && hasPackage)
        {
            Debug.Log("Package Deliverd");
            hasPackage = false;
            spriteRenderer.color=noPackagecolor;
        }
    }
}
