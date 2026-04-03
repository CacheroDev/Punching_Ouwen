using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] float jumpForce;
    [SerializeField] KeyCode jump;
    Rigidbody2D rb;
    bool isJumping;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(jump))
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
}
