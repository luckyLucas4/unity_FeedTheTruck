using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMovement : MonoBehaviour
{
    public bool facingRight { get; set; }
    public int speed;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector2(1,0.01f) * speed);

        if (speed < 0)
        {
            Debug.Log("flipping");
            spriteRenderer.flipX = false;
        }
        
    }
}
