using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This script is created using this tutorial: https://www.youtube.com/watch?v=DZ-3g31jk90&t=96s&ab_channel=Xlaugts
//The creation of the script starts at 5:35
//In the tutorial the script is called "coin" but I named it ""Collectible"" to better fit our game 

public class Collectible : MonoBehaviour
{
    public int CoinValue = 1; //It needs to be named "CoinValue" to fit to the ScoreManager script (I think)

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(CoinValue);
            
        }

        if (other.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
    }
}
