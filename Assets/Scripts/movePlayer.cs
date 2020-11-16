using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xVelocity = 0;
        float yVelocity = 0;
        float speed = -10;
        float speed2 = 10;
        if (Input.GetKey(KeyCode.A))
        {
            xVelocity = speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            xVelocity = speed2;
        }
        if (Input.GetKey(KeyCode.S))
        {
            yVelocity = speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            yVelocity = speed2;
        }
        rb.velocity = new Vector2(xVelocity, yVelocity);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            transform.position = new Vector2(40, 33);
        }
        if (col.gameObject.tag == "Wall")
        {
            rb.velocity = new Vector2(0, 0);
        }
        if (col.gameObject.tag == "Finish")
        {
            transform.position = new Vector2(-60, -80);
        }
    }
}