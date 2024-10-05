using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsSpawn : MonoBehaviour
{

    public GameObject Points;
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

        Instantiate(Points, transform.position + new Vector3(X, Y, 0), transform.rotation);
    }
}
