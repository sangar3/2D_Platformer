using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;

    public Transform farbackground, middleBackground;
    public float minHeight;
    public float maxHeight;



    private Vector2 lastpos;

    void Start()
    {
        lastpos = transform.position;


    }

   
    void Update()
    {
      

        transform.position = new Vector3(target.position.x, Mathf.Clamp(target.position.y, minHeight, maxHeight), transform.position.z);



       
        Vector2 amountToMove = new Vector2(transform.position.x - lastpos.x, transform.position.y - lastpos.y);


        farbackground.position = farbackground.position + new Vector3(amountToMove.x, amountToMove.y, 0f);
        middleBackground.position += new Vector3(amountToMove.x, amountToMove.y, 0f) * .5f;

        lastpos = transform.position;



    }
}
