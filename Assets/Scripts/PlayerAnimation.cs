using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] PlayerMovement movement;
    [SerializeField] PlayerPunch punch;
    [SerializeField] PlayerShout shout;
    [SerializeField] PlayerJump jump;
    Animator anim;
    
    void Start()
    {
        movement = GetComponent<PlayerMovement>();
        punch = GetComponent<PlayerPunch>();
        shout = GetComponent<PlayerShout>();
        jump = GetComponent<PlayerJump>();
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        //Player Direction
        if (movement.facingRight)
        {
            transform.eulerAngles = new Vector2(transform.rotation.x, 0f);
        }
        else if (movement.facingLeft)
        {
            transform.eulerAngles = new Vector2(transform.rotation.x, 180f);
        }

        //Player Animation
        if (punch.isPunching)
        {
            anim?.Play("OuwenPunch");
        }
        else if (shout.isShouting)
        {
            anim?.Play("OuwenShout");
        }
        else if (jump.isJumping)
        {
            anim?.Play("OuwenJump");
        }
        else if (movement.isWalking)
        {
            anim?.Play("OuwenWalk");
        }
        else
        {
            anim?.Play("OuwenIdle");
        }
    }
}
