using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int speed;
    private Rigidbody2D rb;
    private int direction = -1;
    private bool facingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    public void TurnAround()
    {
        rb.velocity = new Vector2(speed * direction, rb.velocity.y);
        direction *= -1;
        Flip();
    }

    void Awake()
    {
        Physics2D.IgnoreCollision(FindObjectOfType<Controller>().GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }
    
    void Flip() 
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
