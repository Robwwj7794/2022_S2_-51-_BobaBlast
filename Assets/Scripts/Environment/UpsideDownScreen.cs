using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpsideDownScreen : MonoBehaviour
{
    //variables
    private GameObject cam;

    private float xRot = 360.0f;
    private float yRot = 360.0f;
    private float invertRot = 180.0f;
    private float duration = 3;

    void Start()
    {
        cam = GameObject.FindWithTag("MainCamera");
    }

    //when the player collides with the trigger the PickUp function is run
    void OnTriggerEnter (Collider other)
    {
        //start pick up function if the trigger is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            StartCoroutine(PickUp());
        }
    }

    IEnumerator PickUp()
    {
        //add 360 degrees rotation to the x and y axis. add 180 rotation to the z axis to flip the camera upside down
        cam.transform.Rotate(xRot, yRot, invertRot);

        //disable meshrender and collider to remove object from game
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        //effect last for the duration
        yield return new WaitForSeconds(duration);

        //reverses the camera orientation to return to defualt orientation
        cam.transform.Rotate(xRot, yRot, invertRot);

        //fully remove game object from game
        Destroy(gameObject);
    }
}
