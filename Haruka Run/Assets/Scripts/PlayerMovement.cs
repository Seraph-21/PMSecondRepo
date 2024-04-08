using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float walkSpeed = 5f;
    [SerializeField] float runSpeed = 10f;
    [SerializeField] float jumpSpeed = 5f;
    Vector2 moveInput;
    Rigidbody2D myRigidbody;
    Animator myAnimator;
    CapsuleCollider2D myCapsuleCollider;
    public bool playerHasHorizontalSpeed;
    public float defaultRun;
    public float defaultWalk;
    // [SerializeField] AudioClip jumpSound;


    public float SWaitTime;
    public float SWaitCounter;

    public void Start()
    {
        defaultRun = runSpeed;
        defaultWalk = walkSpeed;
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myCapsuleCollider = GetComponent<CapsuleCollider2D>();
        SWaitCounter = SWaitTime;
    }

    public void Update()
    {
        if (SWaitCounter > 0)
        {
            SWaitCounter -= Time.deltaTime;
        }
        Walk();
        FlipSprite();
        if (SWaitCounter >= 0f && walkSpeed != 0)
        {
            walkSpeed = 5f;
            runSpeed = 10f;
        }
        else if (SWaitCounter <= 0f && walkSpeed == 0)
        {
            walkSpeed = defaultWalk;
            runSpeed = defaultRun;
        }
        
    }

   public  void OnMove(InputValue value)
   {
      moveInput = value.Get<Vector2>();
   }
    public void OnJump(InputValue value)
    {
        if (!myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Ground"))) { return; }

        if(value.isPressed)
        {

           // Camera.main.GetComponent<AudioSource>().PlayOneShot(jumpSound);

           myRigidbody.velocity += new Vector2 (0f, jumpSpeed);
        }
    }

    public void Walk()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, myRigidbody.velocity.y);
            myRigidbody.velocity = playerVelocity;

            bool playerHasHorizontalSpeed = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon;
            myAnimator.SetBool("isRunning", playerHasHorizontalSpeed);
        }
        else
        {
            Vector2 playerVelocity = new Vector2(moveInput.x * walkSpeed, myRigidbody.velocity.y);
            myRigidbody.velocity = playerVelocity;

            bool playerHasHorizontalSpeed = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon;
            myAnimator.SetBool("isRunning", playerHasHorizontalSpeed);
        }

    }

    //possible needs default field so int can return to original int there maybe no solution wthin On L & R  projectile void might just need if register button
    void OnLeftprojectile()
    {

        SWaitCounter = SWaitTime;
        
    }
    void OnRightprojectile()
    {
            SWaitCounter = SWaitTime;
    }

    public void FlipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon;
        if (playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(myRigidbody.velocity.x), 1f);
        }
    }
}
// public void IfProjectileF()
// {

/*
if(Input.GetKey(KeyCode.E))
{
    if (SWaitCounter <= 0f)
    {
        walkSpeed = 0f;
        runSpeed = 0f;
    }
    else if (SWaitCounter >= 1f) 
    {
        walkSpeed = 5f;
        runSpeed = 10f;
    }
}
*/
/* this is wrong 
 * - posible solutiuons
 * -you make the keys / Q & E get the timer not use because timer resets every time you click which switches the int for Q & E
*/

/*
if (Input.GetKey(KeyCode.Q))
{
    if (SWaitCounter <= 0f)
    {
        walkSpeed = 0f;
        runSpeed = 0f;
    }
    else if (SWaitCounter > 0f)
    {
        walkSpeed = 5f;
        runSpeed = 10f;

    }
    SWaitCounter = SWaitTime;
    SWaitCounter -= Time.deltaTime;
}
*/
//}
/*
void OnLeftprojectile()
{
    if (SWaitCounter <= 0f)
    {
        walkSpeed = 0f;
        runSpeed = 0f; 
    }
    else
    {
        walkSpeed = 5f;
        runSpeed = 10f;
    }

    SWaitCounter = SWaitTime;
    SWaitCounter -= Time.deltaTime;
}
void OnRightprojectile()
{
    if (SWaitCounter <= 0f)
    {
        walkSpeed = 0f;
        runSpeed = 0f;
    }
    else
    {
        walkSpeed = 5f;
        runSpeed = 10f;
    }

    SWaitCounter = SWaitTime;
    SWaitCounter -= Time.deltaTime;
}
*/
