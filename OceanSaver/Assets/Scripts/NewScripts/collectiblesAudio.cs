using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectiblesAudio : MonoBehaviour

    
{
   
    

     AudioSource Collectibles;
    public AudioClip SoundToPlay;
   // public bool alreadyPlayed=false;


    private void Start()
    {
        Collectibles = GetComponent<AudioSource>();
    }


    void OnTriggerEnter2D(Collider2D other)
        {

        

        if (other.gameObject.CompareTag("Player"))
            {

            Collectibles.PlayOneShot(SoundToPlay);
            //alreadyPlayed = true;
            //Collectibles.enabled = true;
        }
        




    }
    



}