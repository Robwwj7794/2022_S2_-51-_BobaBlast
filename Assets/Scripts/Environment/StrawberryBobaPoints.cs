using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawberryBobaPoints : MonoBehaviour
{
    private ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //when the player touches the boba destroy it and increment score by 1. 
        if (other.gameObject.tag == "Player")
        {
            scoreManager.score += 15;
            //update lastScore field to be the same as score
            scoreManager.lastScore = scoreManager.score;
            Destroy(gameObject);
        }
    }
}
