using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool isGem;
    private bool isCollected;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           if(isGem)
           {
                LevelManager.instance.gemsCollected++;

                isCollected = true;
                Destroy(gameObject);

           }
        }
    }

}
