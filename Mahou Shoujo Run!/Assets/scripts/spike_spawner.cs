using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike_spawner : MonoBehaviour
{
    public GameObject Spikes;
    public Transform SpawnPoint;

    public float maxTime = 6;
    public float minTime = 2;
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
        Instantiate(Spikes, SpawnPoint.position, SpawnPoint.rotation);
    }

    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }
}
