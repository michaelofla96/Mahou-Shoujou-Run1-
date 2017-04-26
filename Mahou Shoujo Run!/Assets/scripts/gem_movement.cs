using UnityEngine;
using System.Collections;

public class gem_movement : MonoBehaviour
{
    public float speed = -4.0f;
    public int scoreToGive = 5;
    private score_manager ScoreManager;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Girl")
        {
            ScoreManager.ScoreCounter += scoreToGive;
            Destroy(gameObject);
        }
    }

    void Start()
    {
        ScoreManager = FindObjectOfType<score_manager>();
    }
}
