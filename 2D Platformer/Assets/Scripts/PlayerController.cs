using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Stats")]
    public float movespeed;
    public float jumpForce;
    private bool isGrounded;
    private bool canDoubleJump;

    [Header("Fields")]
    public Rigidbody2D theRB;
    public Transform groundCheckPoint;
    public LayerMask whatIsGround;
    private Animator anim;
    private SpriteRenderer theSR;


    void Start()
    {
        anim = GetComponent<Animator>();
        theSR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        theRB.velocity = new Vector2(movespeed * Input.GetAxis("Horizontal"), theRB.velocity.y); // left/right movement 

        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, whatIsGround);

        if(isGrounded)
        {
            canDoubleJump = true;

        }
        
        if(Input.GetButtonDown("Jump")) //jumping 
        {
            if(isGrounded)
            {
                theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
            }
            else
            {
                if(canDoubleJump)
                {
                    theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
                    canDoubleJump = false;

                }
            }

        }

        if(theRB.velocity.x < 0) //moving left 
        {
            theSR.flipX = true;

        }
        else if(theRB.velocity.x > 0) // moving right 
        {
            theSR.flipX = false;

        }

        anim.SetFloat("moveSpeed", Mathf.Abs(theRB.velocity.x));
        anim.SetBool("isGrounded", isGrounded);
    }
}
