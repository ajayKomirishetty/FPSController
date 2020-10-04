using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float timeAlive = 0f;

    // Update is called once per frame
    void Update()
    {
        timeAlive += Time.deltaTime;
        if (timeAlive > 3)
        {
            gameObject.SetActive(false);
            timeAlive = 0f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.log(collission.transform.name);   
        if (collision.transform.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
