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

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer == 600)
        {
            timer = 0;
            rb.velocity = new Vector2(10, 0);
            Debug.Log(timer);
        }
        if (timer == 300)
        {
            rb.velocity = new Vector2(-10, 0);
        }
    }
}