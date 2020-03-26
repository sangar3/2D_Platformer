using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;

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
        
    }


    public void DealDamage()
    {
        currenthealth--;

        if(currenthealth <=0)
        {
            currenthealth = 0;

            Debug.Log("Youre dead");
            gameObject.SetActive(false);
        }

    }
}
