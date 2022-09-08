using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroMove : MonoBehaviour
{

    public Rigidbody character;
    float dirX;
    public float sideSpeed = 20f;
    public float forwardSpeed = 3;


    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        

        dirX = Input.acceleration.x * sideSpeed;
        transform.position = new Vector3(Mathf.Clamp (transform.position.x, -7.5f, 7.5f), transform.position.y, transform.position.z);
    }

    void FixedUpdate()
    {
        character.velocity = new Vector3(dirX, 0f, forwardSpeed);
    }
}
