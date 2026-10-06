using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPunch : MonoBehaviour
{
    [SerializeField] public bool isPunching;
    [SerializeField] KeyCode punch;

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
    }

    IEnumerator PunchSequence()
    {
        yield return new WaitForSeconds(0.5f);
        isPunching = false;
    }
}
