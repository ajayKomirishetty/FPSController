using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObject : MonoBehaviour
{
    public static EnemyObject sharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject enemy;
    public int amountToPool;
    public float distance = 6f;

    //public GameObject player;


    private void awake()
    {
        sharedInstance = this;
      //  player = GameObject.FindWithTag("Player");
    }



    void Start()
    {
        //  pooledObjects = new List<GameObject>();
        //  for (int i = 0; i < amountToPool; i++)
        // {
        //     GameObject obj = (GameObject)Instantiate(enemy, new Vector3(0, 0, 0), transform.rotation);
        // obj.SetActive(true);
        //pooledObjects.Add(obj);
   // }
    }

    public GameObject getPooledObjects()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
                return pooledObjects[i];
        }
        return null;
    }

    void Update() 
    {
      //  transform.LookAt(player.transform);
        //transform.position += transform.forward * 1f * Time.deltaTime;
    }
}
