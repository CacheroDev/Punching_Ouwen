using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float horizontalInput;
    [SerializeField] float speed;
    public bool isWalking;
    public bool facingRight;
    public bool facingLeft;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        if (horizontalInput > 0)
        {
            facingRight = true;
            facingLeft = false;
            isWalking = true;
        }
        else if (horizontalInput < 0)
        {
            facingLeft = true;
            facingRight = false;
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }
    }

    private void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
    }
}
