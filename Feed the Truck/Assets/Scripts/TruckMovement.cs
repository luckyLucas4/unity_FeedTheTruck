using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMovement : MonoBehaviour
{
    public float speed;
    public float acclereration;
    public int compostCost;

    private int dirX = 1;
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
        speed += Time.deltaTime * acclereration/100;
        transform.Translate(transform.right * speed*dirX/100);
        //rb.AddForce(new Vector2(1,0) * speed);

        if (dirX < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (dirX > 0)
        {
            spriteRenderer.flipX = false;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Smog"))
        {
            dirX = -dirX;
        }
    }

    public int Feeding(int compost)
    {
        if (compost >= compostCost)
        {
            dirX = 1;
            return compostCost;
        }
        else
        {
            return 0;
        }
    }
}
