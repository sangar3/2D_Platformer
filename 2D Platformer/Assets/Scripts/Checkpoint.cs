using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public SpriteRenderer theSR; 
    
    public Sprite cpON;
    public Sprite cpOFF;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            CheckpointController.instance.DeactivateCheckpoints();

            theSR.sprite = cpON;
            CheckpointController.instance.SetSpawnPoint(transform.position);

        }
    }



    public void ResetCheckpoint()
    {
        theSR.sprite = cpOFF;

    }
}
