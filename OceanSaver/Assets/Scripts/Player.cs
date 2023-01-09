using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script was created with inspiration from this tutorial: https://www.youtube.com/watch?v=U3sT-T5bKX4&ab_channel=Hooson


public class Player : MonoBehaviour
{
    public float DieTimeCollectible;
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
        
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }

    //The collision with collectibles in made with this tutorial: https://www.youtube.com/watch?v=DZ-3g31jk90&t=96s&ab_channel=Xlaugts
    // Adding to the player script starts at 1:40

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Collectible"))
        {
            Destroy(other.gameObject, DieTimeCollectible);
        }
    }
}
