using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Animator anim;
    public Collider2D Girl;
    public Collider2D Ground;

    public bool grounded;

    public Transform FirePoint;
    public GameObject Spell;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Girl.IsTouching(Ground))
        {
            anim.Play("running");
        }
        else
        {
            anim.Play("jumping");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * 500f);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        Instantiate(Spell, FirePoint.position, FirePoint.rotation);
    }
}

