using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] float jumpForce;
    [SerializeField] KeyCode jump;
    [SerializeField] public bool isJumping;

    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(jump))
        {
            rb.AddForce(Vector2.up * jumpForce);
            isJumping = true;
            StartCoroutine(JumpSequence());
        }
    }

    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.5f);
        isJumping = false;
    }
}
