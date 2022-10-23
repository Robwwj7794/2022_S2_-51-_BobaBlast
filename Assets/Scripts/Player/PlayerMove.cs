using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //variables
    public float moveSpeed = 5.0f;
    public float leftRightSpeed = 5.0f;
    private float maxSpeed = 20.0f;

    //updates every frame
    void Update()
    {
        //Moves Forward indefinitely
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        
        //Basic Left movement on keyboard
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if(this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }

        //Basic Right movement on keyboard
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if(this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
        }
    }

    public void SpeedUp()
    {
        //if moveSpeed is less that maxSpeed increment moveSpeed by 0.5
        if (moveSpeed < maxSpeed)
        {
           moveSpeed++;
        }
    }

}
