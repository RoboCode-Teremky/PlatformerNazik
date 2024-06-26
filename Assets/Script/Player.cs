using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2;
    public float jumpForce = 5f;
    Rigidbody2D rb;
    void Start()
    {
        rb  = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        
    }
}
