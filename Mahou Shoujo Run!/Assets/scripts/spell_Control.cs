using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell_Control : MonoBehaviour
{
    public float speed_x;
    public float speed_y;

    void Update ()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed_x, speed_y);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("stalac"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
