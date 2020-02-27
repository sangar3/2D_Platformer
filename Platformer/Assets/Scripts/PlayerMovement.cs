using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D myrb;
    public float movespeed;
    public Animator myanim;
    private bool facingRight;
    void Start()
    {
        facingRight = true;

    }

    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        HandleMovement(horizontal);
        flip(horizontal);
    }

    private void HandleMovement(float horizontal)
    {
        myrb.velocity = new Vector2(horizontal *movespeed , myrb.velocity.y);
    }

    private void flip(float horizontal)
    {
        if(horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale; // changing player X-axis Scale

            theScale.x *= -1;
            transform.localScale = theScale;


        }
    }
}
