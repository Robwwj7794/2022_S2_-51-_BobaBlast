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
        //sets bounds of possible x positions
        transform.position = new Vector3(Mathf.Clamp (transform.position.x, -3.7f, 3.7f), transform.position.y, transform.position.z);
    }

    void FixedUpdate()
    {
        //constant forward movement
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed, Space.World);
        //applies gyro position to x axis
        transform.Translate(Vector3.right * Time.deltaTime * dirX);
    }
}
