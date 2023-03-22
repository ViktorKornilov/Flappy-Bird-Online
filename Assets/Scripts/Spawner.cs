using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float nextSpawnTime;
    public float spawnInterval;
    
    
    private void Start()
    {
        nextSpawnTime = Time.time;
    }


    private void Update()
    {
        print(Time.time);
        

        if (Time.time > nextSpawnTime)
        {
            Spawn();
            nextSpawnTime += spawnInterval;
        }
    }


    void Spawn()
    {
        var pos = transform.position;
        pos.y = Random.Range(-1f, 1f);
        var rot = Quaternion.Euler(0, 0, 0);
        
        Instantiate(prefab,pos,rot);
    }
}
