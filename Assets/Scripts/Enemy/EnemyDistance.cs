using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistance : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float distanceOnPlayer;
    [SerializeField] float minDist;
    [SerializeField] public bool isFar;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        distanceOnPlayer = transform.position.x - player.transform.position.x;

        if (distanceOnPlayer > minDist || distanceOnPlayer < -minDist)
        {
            isFar = true;
        }
        else isFar = false;
    }
}
