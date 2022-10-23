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
    private int highScore = 0;
    public TMP_Text bobaHighScore; 
    // Start is called before the first frame update
    void Start()
    {
        //set score to zero at the start of the game
        bobaScore.text = "Current: " + score.ToString() + " Bobas";
        highScore = PlayerPrefs.GetInt("Highscore");
    }

    // Update is called once per frame
    void Update()
    {
        bobaHighScore.text = "High Score: " + highScore.ToString() + " Bobas";
        //if statement to check if score has changed since last update
        if(lastScore == score)
        {
            //updates the UI with the current score
            bobaScore.text = "Current: " + score.ToString() + " Bobas";
        }

        if(score > highScore)
        {
            bobaHighScore.text = "High Score: " + score.ToString() + " Bobas";
            PlayerPrefs.SetInt("Highscore", score);
        }
    }


}
