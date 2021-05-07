using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punchmovemement : MonoBehaviour
{

    public float jumpForce;
    public float speed;

    private float horizontal;
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
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
        rb2D.velocity = new Vector2(horizontal, rb2D.velocity.y);
    }
}
