using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    [SerializeField] HitByFist hitByFist;
    [SerializeField] bool initKnockback;
    [SerializeField] GameObject player;
    [SerializeField] bool goRight;
    [SerializeField] float forceMultiplier;
    Rigidbody2D rb;

    void Start()
    {
        initKnockback = true;
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (hitByFist.hitByPunch && initKnockback)
        {
            initKnockback = false;
            Debug.Log("Initialize");
            StartCoroutine(KnockbackVector());
        }
        if (transform.position.x - player.transform.position.x > 0)
        {
            goRight = true;
        }
        else goRight = false;
    }

    IEnumerator KnockbackVector()
    {
        if (goRight)
            rb.velocity = new Vector2(forceMultiplier, rb.velocity.y);
        else 
            rb.velocity = new Vector2(-forceMultiplier, rb.velocity.y);
        yield return new WaitForSeconds(1f);
    }
}
