using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMoveSide : MonoBehaviour
{
    int timer;
    Rigidbody2D rb;
    void Start()
    {
        timer = 0;
        rb = GetComponent<Rigidbody2D>();
    }
    int speed;
    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer == 600)
        {
            timer = 0;
            rb.velocity = new Vector2(10, 0);
        }
        if (timer == 300)
        {
            rb.velocity = new Vector2(-10, 0);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Wall")
        {
            speed = -speed;
        }
    }
}