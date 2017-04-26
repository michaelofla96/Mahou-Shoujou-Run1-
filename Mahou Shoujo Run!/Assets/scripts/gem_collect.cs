using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem_collect : MonoBehaviour
{
    public GameObject Gem;
    public Transform SpawnPoint;

    private float nextActionTime = 0.0f;
    public float period = 2.0f;

    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            Instantiate(Gem, SpawnPoint.position, SpawnPoint.rotation);
        }
    }
}
