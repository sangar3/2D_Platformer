using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Stats")]
    public float movespeed;
    public float jumpForce;
    private bool isGrounded;

    [Header("Fields")]
    public Rigidbody2D theRB;
    public Transform groundCheckPoint;
    public LayerMask whatIsGround;

    void Update()
    {
        theRB.velocity = new Vector2(movespeed * Input.GetAxis("Horizontal"), theRB.velocity.y); // left/right movement 

        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, whatIsGround);


        if(Input.GetButtonDown("Jump")) //jumping 
        {
            if(isGrounded)
            {
                theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
            }
            

        }



    }
}
