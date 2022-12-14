using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script was created using this tutorial: https://www.youtube.com/watch?v=U3sT-T5bKX4&ab_channel=Hooson
// The creating of this script starts at 16:50

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject); //This distroys the obstacle when it hits the side border to the left of the screen
        }

        else if(collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }
}
