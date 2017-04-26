using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stalac_spawner : MonoBehaviour
{
    public GameObject stalac;
    public Transform SpawnPoint;

    public float maxTime = 10;
    public float minTime = 1;
    private float spawnTime;
    private float time;

    void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;

        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }
    }

    void SpawnObject()
    {
        time = minTime;
        Instantiate(stalac, SpawnPoint.position, SpawnPoint.rotation);
    }

    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }
}
