using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByFist : MonoBehaviour, IFistHit
{
    [SerializeField] GameObject player;
    [SerializeField] public bool hitByPunch;
    [SerializeField] SoundFX sfx;
    Animator anim;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    public void FistHit()
    {
        if (player.GetComponent<PlayerPunch>().isPunching)
        {
            hitByPunch = true; Debug.Log("Temp hitbypunch");
            anim.Play("EnemyHit");
            StartCoroutine(PunchSFXSequence());
        } 
    }

    IEnumerator PunchSFXSequence()
    {
        yield return new WaitForSeconds(0.25f);
        anim.Play("EnemyIdle");
        hitByPunch = false;
    }

}
