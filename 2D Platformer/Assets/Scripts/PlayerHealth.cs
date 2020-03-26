using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

            if(invincibleCounter <=0)
            {
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 1f);
            }

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
                SceneManager.LoadScene("Gameover");
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
