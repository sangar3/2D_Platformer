using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D myrb;
    public float movespeed;
    public Animator myanim;
    private bool facingRight;
    private bool attack;
    void Start()
    {
        facingRight = true;

    }

    void Update()
    {
        HandleInput();
    }


    void FixedUpdate() 
    {
        float horizontal = Input.GetAxis("Horizontal");
        HandleMovement(horizontal);
        flip(horizontal);
        HandleAttacks();
        ResetValues();
    }

    private void HandleMovement(float horizontal)
    {
        if(!this.myanim.GetCurrentAnimatorStateInfo(0).IsTag("Attack"))
        {
            myrb.velocity = new Vector2(horizontal * movespeed, myrb.velocity.y);
        }
       

        myanim.SetFloat("speed", Mathf.Abs(horizontal));
    }

    public void HandleAttacks()
    {
        if(attack && !this.myanim.GetCurrentAnimatorStateInfo(0).IsTag("Attack"))
        {
            myanim.SetTrigger("attack"); //play attack anim
            myrb.velocity = Vector2.zero;
        }
    }

    private void HandleInput()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            attack = true;

        }
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

    private void ResetValues()
    {
        attack = false;
    }
}
