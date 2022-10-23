using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section : MonoBehaviour
{
    GenerateLevel generateLevel;
    PlayerMove playerMove;
    public static int sectionsPassed = 0;

    void Start()
    {
        generateLevel = GameObject.FindObjectOfType<GenerateLevel>();
        playerMove = GameObject.FindObjectOfType<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        //Destroys section 1 sec after player exits
        Destroy(gameObject, 1);

    }

    private void OnTriggerEnter(Collider other)
    {
        //if object that triggers is "Player" tag call SpeedUp method
        if(other.gameObject.tag == "Player")
        {
            sectionsPassed ++;
            generateLevel.GenerateSection();
            playerMove.SpeedUp();

            Debug.Log("Sections passed: " + sectionsPassed);
        }
    }
}
