using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public int xpos;
    public int zpos;
    public int enemyCount;



    void Start()
    {
        StartCoroutine(spawn());
        // player = GameObject.FindWithTag("Player");

    }

    IEnumerator spawn()
    {
        while (enemyCount < 20)
        {
            xpos = Random.Range(1, 400)-200;
            zpos = Random.Range(1, 300)-150;
            Instantiate(enemy, new Vector3(xpos, 0.4f, zpos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }

   
}
