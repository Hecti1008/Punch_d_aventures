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
    private bool Grounded;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);

        if (Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
        {
            Grounded = true;
        }
        else Grounded = false;

        if (Input.GetKeyDown(KeyCode.W) && Grounded)
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
