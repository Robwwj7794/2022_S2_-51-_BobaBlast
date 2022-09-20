using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text bobaScore;
    public int score = 0;
    public int lastScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        //set score to zero at the start of the game
        bobaScore.text = score.ToString() + " Bobas";
    }

    // Update is called once per frame
    void Update()
    {
        //if statement to check if score has changed since last update
        if(lastScore == score)
        {
            //updates the UI with the current score
            bobaScore.text = score.ToString() + " Bobas";
        }
    }
}
