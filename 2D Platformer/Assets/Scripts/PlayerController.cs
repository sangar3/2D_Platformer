using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D theRB;
    public float jumpForce;
    void Update()
    {
        theRB.velocity = new Vector2(movespeed * Input.GetAxis("Horizontal"), theRB.velocity.y); // left/right movement 

        if(Input.GetButtonDown("Jump")) //jumping 
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);

        }



    }
}
