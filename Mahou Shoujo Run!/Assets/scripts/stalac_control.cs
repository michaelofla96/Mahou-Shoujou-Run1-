using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stalac_control : MonoBehaviour
{
    public float speed_x = -4.0f;
    public float speed_y = -4.0f;

    void Update()
    {
        transform.Translate(speed_x * Time.deltaTime, speed_y * Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Spell")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.name == "Girl")
        {
            SceneManager.LoadScene("game_over");
        }
    }
}
