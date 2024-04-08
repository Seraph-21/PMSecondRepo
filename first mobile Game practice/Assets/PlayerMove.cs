using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] float moveSpeed = 2;
    [SerializeField] FixedJoystick joystick;
    [SerializeField] bool allowKeyControls = true;
    [Tooltip("true if the game is a top down, flase if its a  platformer")]
    [SerializeField] bool isTopDown = true;
    Collider2D collider;
    [SerializeField] float jumpForce = 15f;
    [SerializeField] Canvas mobileCanvas;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        if (allowKeyControls)
        {
            mobileCanvas.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2(0, 0);
        if (allowKeyControls)
        {
            move.x = Input.GetAxis("Horizontal");
            move.y = Input.GetAxis("Vertical");
            if (Input.GetButtonDown("Jump"))
            { 
                Jump(); 
            }
            
        }
        else
        {
            move.x = joystick.Horizontal;
            move.y = joystick.Vertical;
        }
        if (isTopDown)
        {
            rb2d.velocity = new Vector3(joystick.Horizontal * moveSpeed, joystick.Vertical * moveSpeed, 0);
        }
        else
        {
            rb2d.velocity = new Vector3(move.x * moveSpeed, rb2d.velocity.y, 0);
        }
    }
    public void Jump()
    {
        if (collider.IsTouchingLayers(LayerMask.GetMask("Ground")) && !isTopDown)
        {
            rb2d.AddForce(new Vector2(0, 20 * jumpForce));

        }
    }
}