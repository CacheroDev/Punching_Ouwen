using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShout : MonoBehaviour
{
    [SerializeField] public bool isShouting;
    [SerializeField] KeyCode shout;
    [SerializeField] SoundFX sfx;

    void Start()
    {
        isShouting = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(shout))
        {
            isShouting = true;
            StartCoroutine(ShoutSequence());
        }
    }
    IEnumerator ShoutSequence()
    {
        sfx.PlaySFX(sfx.ha);
        yield return new WaitForSeconds(0.25f);
        isShouting = false;
    }
}
