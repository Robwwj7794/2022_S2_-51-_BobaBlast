using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsManager : MonoBehaviour
{
    public int life;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    // Start is called before the first frame update
    void Start()
    {
        //character begins each game with a full set of hearts
        life = hearts.Length;
    }

    public void Update()
    {
        //To make sure that the amount of lives do not exceed the amount of heart containers.
        if (life > numOfHearts)
        {
            life = numOfHearts;
        }


        for (int i = 0; i < hearts.Length; i++)
        {
            //checks the number of lives are equal to the full hearts 
            if (i < life)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                //changes the hearts to empty if a life is lost
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            //Hearts reduce each time the character hits an obstacle
            --life;

            //when the hearts reaches zero then its game over
            if (life < 1)
            {
                PlayerManager.gameOver = true;
            }

        }
    }

}