using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script was created using this tutorial: https://www.youtube.com/watch?v=U3sT-T5bKX4&ab_channel=Hooson
// The creating of this script starts at 16:50

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
    }
}
