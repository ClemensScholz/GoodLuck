using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Controller : MonoBehaviour
{
    public float speed;
    private float moveInput;
    private Rigidbody2D rb;
    
    private bool facingRight = true;
    
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public float jumpForce;
    public int maxJumps;

    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
        extraJumps = maxJumps;
    }

    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (!facingRight && moveInput > 0)
        {
            Flip();
        } else if (facingRight && moveInput < 0)
        {
            Flip();
        }
    }

    void Flip() 
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }

    void Update()
    {
        if (isGrounded)
        {
            extraJumps = maxJumps;
        }
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (extraJumps > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                extraJumps--;
            }
        }    
    }
}
