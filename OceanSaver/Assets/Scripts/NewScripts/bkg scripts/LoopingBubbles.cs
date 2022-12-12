using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// looping background bubbles prefabs with instantiate (clone and destroy):https://www.youtube.com/watch?v=gNVzlJOW7sM&t=661s

public class LoopingBubbles : MonoBehaviour
{
    public float speed = 4f;
    public Vector3 StartPosition,rotacao;

    public GameObject Bubble1;

    void Start()
    {
        StartPosition = transform.position;
       
        
    }


    void Update()
    {
       
        transform.Translate(translation: Vector3.up * speed * Time.deltaTime);
        if (transform.position.y >= 3f)
        {
            Destroy(gameObject);
           
        }
        if (transform.position.y >= 3f)
        {
            GameObject Air=(GameObject)Instantiate(Bubble1,StartPosition,Quaternion.Euler(rotacao));
            Air.GetComponent<LoopingBubbles>().enabled = true;
        }
        



    }

 }
