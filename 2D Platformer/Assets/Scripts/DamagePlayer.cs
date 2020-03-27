using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public int DamageToPlayer;

  private void OnTriggerEnter2D(Collider2D other)
  {
        if(other.tag == "Player")
        {
            Debug.Log(DamageToPlayer + "damage dealt");

            PlayerHealth.instance.DealDamage(DamageToPlayer);
            PlayerUIController.instance.UpdateHealthDisplay();

        }
  }
}
