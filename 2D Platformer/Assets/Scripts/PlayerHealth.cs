using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;
    [Header("InvincibilityNumbers")]
    public float invincibleLength;
    private float invincibleCounter;
    public SpriteRenderer theSR;
    [Header("HealthNumbers")]
    public int currenthealth;
    public int maxHealth;
   
    
    
    
    void Start()
    {
        currenthealth = maxHealth;

    }

    private void Awake()
    {
        instance = this;

    }
    
    void Update()
    {
        if(invincibleCounter > 0)
        {
            invincibleCounter -= Time.deltaTime;


        }
    }


    public void DealDamage()
    {
        if(invincibleCounter <=0)
        {
            currenthealth--;

            if (currenthealth <= 0)
            {
                currenthealth = 0;

                Debug.Log("Youre dead");
                gameObject.SetActive(false);
            }
            else
            {
                invincibleCounter = invincibleLength;
                theSR.color = new Color(theSR.color.r, theSR.color.g, )
            }
            PlayerUIController.instance.UpdateHealthDisplay();
        }
        
    }
}
