using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScript : MonoBehaviour
{
    public Rigidbody character;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the character is touching the ground (not moving on the y axis)
        if (character.position.y <= 1.52f)
        {
            //When screen is touched, Jump by adding force to the rigidbody
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    Debug.Log("Jumping with touch");
                    character.AddForce(Vector3.up * 7, ForceMode.Impulse);
                }
            }

            //When space is pressed, jump by adding force to the rigidbody
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Jumping with spacebar");
                character.AddForce(Vector3.up * 7, ForceMode.Impulse);
            }
        }
    }

}
