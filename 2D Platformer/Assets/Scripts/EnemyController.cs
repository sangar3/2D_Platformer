using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;
    public Transform leftpoint;
    public Transform rightpoint;

    private bool movingRight;
    private Rigidbody2D theRB;

    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
        leftpoint.parent = null;
        rightpoint.parent = null;

    }

    
    void Update()
    {
        
    }
}
