using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialPlatforms : MonoBehaviour
{
    public bool moving;
    public bool falling;
    public int speed;
    
    private int direction = -1;

    private Rigidbody2D rb;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
            rb.gravityScale = 0;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            rb.bodyType = RigidbodyType2D.Kinematic;
            
            if (falling)
            {
                rb.bodyType = RigidbodyType2D.Dynamic;
            }

            if (moving)
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }
        }
    }

    public void TurnAround()
    {
        rb.velocity = new Vector2(speed * direction, rb.velocity.y);
        direction *= -1;
    }
}
