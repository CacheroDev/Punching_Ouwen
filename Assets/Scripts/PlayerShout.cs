using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShout : MonoBehaviour
{
    [SerializeField] public bool isShouting;
    [SerializeField] KeyCode shout;

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
        yield return new WaitForSeconds(0.5f);
        isShouting = false;
    }
}
