using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMoveUp : MonoBehaviour
{
    Rigidbody2D rb;
    int speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = -10;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, speed);
    }
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Wall")
        {
            speed = -speed;
        }
    }
}