using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{


    public float waitToRespawn;

    public int gemsCollected;

    
    
    public static LevelManager instance;

    private void Awake()
    {
        instance = this;

    }
    
  

    public void RespawnPlayer()
    {
        StartCoroutine(RespawnCoroutine());
        
    }
    

    private IEnumerator RespawnCoroutine()
    {
        PlayerController.instance.gameObject.SetActive(false);
        Debug.Log("Respawning..");
        yield return new WaitForSeconds(waitToRespawn);
        PlayerController.instance.gameObject.SetActive(true);

        PlayerController.instance.transform.position = CheckpointController.instance.spawnPoint;

        PlayerHealth.instance.currenthealth = PlayerHealth.instance.maxHealth;

        PlayerUIController.instance.UpdateHealthDisplay();
        Debug.Log("Respawned!");

    }
}
