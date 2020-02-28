using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D myrb;

    public float movespeed;
    public float jumpforce;
    private bool facingRight;
    private bool attack;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRaduis;
    public LayerMask whatIsGround;

    private float jumpTimeCounter;
    public float jumpTime;
    private bool IsJumping;


    void Start()
    {
        facingRight = true;

    }

    void Update()
    {
        HandleInput();
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRaduis, whatIsGround );

        if(isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            IsJumping = true;
            jumpTimeCounter = jumpTime;

            myrb.velocity = Vector2.up * jumpforce;
        }

        if(Input.GetKey(KeyCode.Space) && IsJumping == true)
        {
            if(jumpTimeCounter >  0)
            {
                myrb.velocity = Vector2.up * jumpforce;
                jumpTimeCounter -= Time.deltaTime;

            }
            else
            {
                IsJumping = false;
            }
            
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            IsJumping = false;

        }
    }


    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        HandleMovement(horizontal);
        flip(horizontal);
       
        ResetValues();
    }

    private void HandleMovement(float horizontal)
    {
       
        
            myrb.velocity = new Vector2(horizontal * movespeed, myrb.velocity.y);
        


       
    }

  
    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            attack = true;

        }
    }
    private void flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale; // changing player X-axis Scale

            theScale.x *= -1;
            transform.localScale = theScale;


        }
    }

    private void ResetValues()
    {
        attack = false;
    }
}
