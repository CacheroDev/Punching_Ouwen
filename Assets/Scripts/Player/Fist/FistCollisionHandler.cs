using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistCollisionHandler : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<IFistHit>().FistHit();
    }
}
