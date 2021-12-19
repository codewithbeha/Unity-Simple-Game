using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bat bat = collision.collider.GetComponent<Bat>();
        if (bat != null)
        {
            Destroy(gameObject);
            return;
        }


        Enemy enemy = collision.collider.GetComponent<Enemy>();

        if (enemy != null)
        {
            return;
        }
        if (collision.contacts[0].normal.y < -0.5)
        {
            Destroy(gameObject);
            return;
        }
    }
}
