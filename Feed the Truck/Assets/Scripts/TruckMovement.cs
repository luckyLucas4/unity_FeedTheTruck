using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMovement : MonoBehaviour
{
    public int speed;
    private Rigidbody2D rb;

    public bool m_FacingRight { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector2(1,0) * speed);

        if (speed < 0)
        {
            m_FacingRight = false;
            transform.localScale = transform.localScale * -1;
        }
    }
}
