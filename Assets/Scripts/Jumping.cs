using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    public float jumpingPower;

    void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.relativeVelocity.y <= 0f)
            {
                Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    Vector2 vel = rb.velocity;
                    vel.y = jumpingPower;
                    rb.velocity = vel;
                }
            }
        }
    }
}
