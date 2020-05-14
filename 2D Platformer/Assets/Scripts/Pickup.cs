using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [Header("Pickupeffect")]
    public GameObject pickupeffect;


    [Header("CehckWhichObject")]
    public bool isGem;
    public bool isHeal;
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

                Instantiate(pickupeffect, transform.position, transform.rotation);

                PlayerUIController.instance.UpdateGemCount();

           }
           if(isHeal)
           {
                if(PlayerHealth.instance.currenthealth != PlayerHealth.instance.maxHealth)
                {
                    PlayerHealth.instance.HealthPlayer();
                    isCollected = true;
                    Destroy(gameObject);

                    Instantiate(pickupeffect, transform.position, transform.rotation);
                }
           }
        }
    }

}
