﻿using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Vector2 startingVelocity;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
        Destroy(gameObject, 5);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<Enemy>();
        enemy?.Die();

        Destroy(gameObject);
    }
}
