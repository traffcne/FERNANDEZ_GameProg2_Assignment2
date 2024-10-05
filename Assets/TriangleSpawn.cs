using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleSpawn : MonoBehaviour
{

    public GameObject Triangle;
    public float minX, minY, maxX, maxY;
    public float TimeBewteenSpawn;
    private float SpawnTime;
    void Update()
    {
        if (Time.time > SpawnTime) 
        {
            Spawn();
            SpawnTime = Time.time + TimeBewteenSpawn;
        }   
    }

    void Spawn()
    {
        float X = Random.Range(minX, maxY);
        float Y = Random.Range(minY, maxY);

        Instantiate(Triangle, transform.position + new Vector3(X, Y, 0), transform.rotation);
    }
}
