using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
  
    private Checkpoint[] checkpoints;

    public Vector3 spawnPoint;

    public static CheckpointController instance;

    private void Awake()
    {
        instance = this;

    }






    void Start()
    {
        checkpoints = FindObjectsOfType<Checkpoint>();
        spawnPoint = PlayerController.instance.transform.position;

    }

   
    void Update()
    {
        
    }


    public void DeactivateCheckpoints()
    {
        for(int i = 0; i<checkpoints.Length;  i++)
        {
            checkpoints[i].ResetCheckpoint();
        }
    }


    public void SetSpawnPoint(Vector3 newSpawnPoint)
    {
        spawnPoint = newSpawnPoint;

    }
}
