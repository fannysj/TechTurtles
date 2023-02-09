using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatiMani : MonoBehaviour
{
    private Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        float dirY = Input.GetAxisRaw("Vertical");
        if (dirX < 0)
        {
            spriteRenderer.flipX = true;
            
        }
        else
        {
            spriteRenderer.flipX = false;
            
        }
        rb.velocity = new Vector2(dirX * 3, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, dirY * 3);

    }

}
