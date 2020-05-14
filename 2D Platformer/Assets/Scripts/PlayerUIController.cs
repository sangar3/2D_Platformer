using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour //attached on canvashud
{
    public static PlayerUIController instance;
    [Header("Gem Text")]
    public Text gemText;


    [Header("HeartImages")]
    public Image heart1;
    public Image heart2;
    public Image heart3;
    public Sprite heartfull;
    public Sprite heartEmpty;
    public Sprite heartHalf;

    void Start()
    {
        UpdateGemCount();

    }
    private void Awake()
    {
        instance = this;
    }

    public void UpdateHealthDisplay()
    {
       switch(PlayerHealth.instance.currenthealth)
        {
            case 6://full hearts
                heart1.sprite = heartfull;
                heart2.sprite = heartfull;
                heart3.sprite = heartfull;

                break;
            case 5: // two and half hearts
                heart1.sprite = heartfull;
                heart2.sprite = heartfull;
                heart3.sprite = heartHalf;

                break;
            case 4: // two hearts 
                heart1.sprite = heartfull;
                heart2.sprite = heartfull;
                heart3.sprite = heartEmpty;

                break;
            case 3:  // one and half hearts
                heart1.sprite = heartfull;
                heart2.sprite = heartHalf;
                heart3.sprite = heartEmpty;

                break;
            case 2: //one heart 
                heart1.sprite = heartfull;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;

                break;
            case 1: //halfheart
                heart1.sprite = heartHalf;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;

                break;
            case 0: //zero hearts
                heart1.sprite = heartEmpty;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;

                break;
            default:
                heart1.sprite = heartEmpty;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;
                break;

        }
    }


    public void UpdateGemCount()
    {
        gemText.text = LevelManager.instance.gemsCollected.ToString();

    }
}
