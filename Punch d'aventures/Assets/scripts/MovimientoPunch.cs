using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPunch : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private float Horizontal;

    public float jumpForce;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb2D.AddForce(Vector2.up * jumpForce);
    }

    private void FixedUpdate()
    {
        rb2D.velocity = new Vector2(Horizontal, rb2D.velocity.y);
    }
}
