using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script was created with inspiration from this tutorial: https://www.youtube.com/watch?v=U3sT-T5bKX4&ab_channel=Hooson
//Time in movie when script is created: 10:25
//The collectibles are created the same way as the obsticles


public class SpawnCollectibles1 : MonoBehaviour

{
    public GameObject collectible;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;


    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
        
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(collectible, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

       
    }

}




