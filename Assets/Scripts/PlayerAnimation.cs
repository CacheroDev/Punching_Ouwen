using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator anim;
    PlayerMovement movement;

    void Start()
    {
        anim = GetComponent<Animator>();
        movement = GetComponent<PlayerMovement>();
    }

    
    void Update()
    {
        if (movement.isWalking && movement.facingRight)
        {
            anim?.Play("OuwenWalk");
        }
        else if (movement.facingLeft)
        {
            anim?.Play("OuwenWalk");
            transform.Rotate(new Vector3())
        }
    }
}
