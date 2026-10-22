using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    [SerializeField] HitByFist hitByFist;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //if (hitByFist.hitByPunch)
        //{
        //    anim.Play("EnemyHit");
        //}
        //else
        //    anim.Play("EnemyIdle");
    }
}
