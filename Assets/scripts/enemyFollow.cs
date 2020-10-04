//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        transform.LookAt(player.transform);
       // transform.position += transform.forward * 1f * Time.deltaTime;

        if ((Vector3.Distance(transform.position, player.transform.position) > 20) && !((Vector3.Distance(transform.position, player.transform.position)) < 8))
        {
           // transform.position += transform.forward * 1f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, .5f);
        }
    }
}
