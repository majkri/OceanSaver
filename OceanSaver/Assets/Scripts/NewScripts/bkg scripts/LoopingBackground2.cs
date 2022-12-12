using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// looping background different from sample scene tutorial: https://www.youtube.com/watch?v=U72trwZ7AT8


public class LoopingBackground2 : MonoBehaviour
{
    public float speed = 4f;
    private Vector3 StartPosition;

    void Start()
    {
        StartPosition = transform.position;
    }


    void Update()
    {
        transform.Translate(translation: Vector3.left * speed * Time.deltaTime);
        if (transform.position.x <= -30f)
        {
            transform.position = StartPosition;

        }
    }
}