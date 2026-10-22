using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPunch : MonoBehaviour
{
    [SerializeField] public bool isPunching;
    [SerializeField] KeyCode punch;
    [SerializeField] SoundFX sfx;
    [SerializeField] CircleCollider2D fistColllider;
    [SerializeField] GameObject enemy;

    void Start()
    {
        isPunching = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(punch))
        {
            isPunching = true;
            StartCoroutine(PunchSequence());
        }

        if (isPunching) fistColllider.enabled = true;
        else fistColllider.enabled = false;

        if (enemy.GetComponent<HitByFist>().hitByPunch)
            PunchSFXSequence();
    }

    IEnumerator PunchSequence()
    {
        if (!enemy.GetComponent<HitByFist>().hitByPunch)
            sfx.PlaySFX(sfx.woosh);

        yield return new WaitForSeconds(0.25f);
        isPunching = false;
    }

    void PunchSFXSequence()
    {
        enemy.GetComponent<HitByFist>().hitByPunch = false;
        sfx.PlaySFX(sfx.punch_hit);
    }
}
