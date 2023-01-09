using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundCollectibles : MonoBehaviour
{
    public AudioClip[] audioCLipArray;
    private AudioSource source;
    public GameObject plasticBag;
    public GameObject plasticBottle1;
    public GameObject plasticBottle2;



    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void Start()
    {

        source.clip = audioCLipArray[Random.Range(0, audioCLipArray.Length)];
        source.PlayOneShot(source.clip);
    }



    //void OnTriggerEnter2D(Collider2D other)
    //{
    //  if (other.gameObject.CompareTag("Collectible"))
    // {

    //source.clip = sounds[Random.Range(0, audioCLipArray.Length)];
    //source.PlayOneShot(source.clip);
    //}

    //private void Update()
   // {
     //   if (Input.GetKeyDown(KeyCode.S))
        //{
          //  source.clip = sounds[Random.Range(0, sounds.Length)];
            //source.PlayOneShot(source.clip);
        }
   

