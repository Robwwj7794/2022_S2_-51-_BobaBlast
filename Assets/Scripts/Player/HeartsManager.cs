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

    private bool isInvulnerable = false;
    private float invulnerableDuration = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //character begins each game with a full set of hearts
        life = hearts.Length;
        
    }

    public void Update()
    {
        //the number of hearts reduces by 1 the longer the character has been running.
        if (Section.sectionsPassed == 3)
        {
            numOfHearts = 4;
        }
        else if (Section.sectionsPassed == 7)
        {
            numOfHearts = 3;
        }
        else if (Section.sectionsPassed == 15)
        {
            numOfHearts = 2;
        }


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
            Damage();

            //when the hearts reaches zero then its game over
            if (life < 1)
            {
                PlayerManager.gameOver = true;
            }

        }
    }

    public void Damage()
    {
        //if isInvulnerable is true do not deduct life
        if (isInvulnerable) return;

        //deduct 1 life
        --life;
        //start 1.5 seconds of invulnerability
        StartCoroutine(Invulnerable());
    }

    public void Heal()
    {
        //add 1 life
        ++life;
    }
    
    //adds 1.5 seconds of invulerability to character
    private IEnumerator Invulnerable()
    {
        Debug.Log("Invulnerable!");
        isInvulnerable = true;

        yield return new WaitForSeconds(invulnerableDuration);

        isInvulnerable = false;

        Debug.Log("no longer invulnerable!");
    }

}