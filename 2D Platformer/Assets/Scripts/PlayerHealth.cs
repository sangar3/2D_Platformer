using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    
    [Header("InvincibilityNumbers")]
    public float invincibleLength;
    private float invincibleCounter;
    public SpriteRenderer theSR;
    [Header("HealthNumbers")]
    public int currenthealth;
    public int maxHealth;
    public static PlayerHealth instance;
    
    private void Awake()
    {
        instance = this;

    }



    void Start()
    {
        currenthealth = maxHealth;

    }
 
    
    void Update()
    {
        if(invincibleCounter > 0)
        {
            invincibleCounter -= Time.deltaTime;

            if(invincibleCounter <=0)
            {
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 1f);
            }

        }
    }


    public void DealDamage(int damage)
    {
        if(invincibleCounter <=0)
        {
            currenthealth-= damage;

            if (currenthealth <= 0)
            {
                currenthealth = 0;

                Debug.Log("Youre dead");
                gameObject.SetActive(false);
                LevelManager.instance.RespawnPlayer();

            }
            else
            {
                invincibleCounter = invincibleLength;
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, .5f);  //changing alpha color value 
                PlayerController.instance.KnockBack();
            }
            PlayerUIController.instance.UpdateHealthDisplay();
        }
        
    }
}
