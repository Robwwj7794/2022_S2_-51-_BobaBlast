using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //start pick up function if the trigger is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            PickUp(other);
        }
    }

    void PickUp(Collider player)
    {
        //disable meshrender and collider to remove object from game viusally
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        PlayerMove move = player.GetComponent<PlayerMove>();
        HeartsManager life = player.GetComponent<HeartsManager>();
        
        //reduce speed if current move speed is more than the default 5.
        if(move.moveSpeed > 5)
        {
            move.moveSpeed--;
        }
        
        //add 1 life
        life.Heal();

        //fully remove game object from game
        Destroy(gameObject);

    }
}
