using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMoveUp : MonoBehaviour
{
    Rigidbody2D rb;
    int speed;
    void Start()
    {
        speed = -5;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, 0);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Wall")
        {
            speed = -speed;
        }
    }
}