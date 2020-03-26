using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
  
  private void OnTriggerEnter2D(Collider2D other)
  {
        if(other.tag == "Player")
        {
            Debug.Log("Player hit");

            PlayerHealth.instance.DealDamage();
            PlayerUIController.instance.UpdateHealthDisplay();

        }
  }
}
