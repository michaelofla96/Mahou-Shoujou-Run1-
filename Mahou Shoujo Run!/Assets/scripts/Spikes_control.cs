using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes_control : MonoBehaviour
{
    public float speed = -4.0f;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Girl")
        {
            SceneManager.LoadScene("game_over");
        }
        if (other.gameObject.name == "SpikeEnd")
        {
            Destroy(gameObject);
        }
    }
}
