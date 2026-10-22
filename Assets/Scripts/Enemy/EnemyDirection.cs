using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDirection : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] public bool isFacingLeft;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.x - player.transform.position.x > 0)
        {
            isFacingLeft = true;
        }
        else isFacingLeft = false;
    }
}
