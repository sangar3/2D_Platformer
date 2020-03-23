using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;

    public Transform farbackground, middleBackground;
    public float minHeight;
    public float maxHeight;

    private float lastXPos;


    void Start()
    {
        lastXPos = transform.position.x;

    }

   
    void Update()
    {
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);


        float ClampedY = Mathf.Clamp(transform.position.y, minHeight, maxHeight); 
        transform.position = new Vector3(transform.position.x, ClampedY, transform.position.z);
        
        float amountToMoveX = transform.position.x - lastXPos;


        farbackground.position = farbackground.position + new Vector3(amountToMoveX, 0f, 0f);
        middleBackground.position += new Vector3(amountToMoveX * .5f, 0f, 0f);

        lastXPos = transform.position.x;


    }
}
