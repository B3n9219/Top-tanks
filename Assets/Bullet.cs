using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        EnemyHealth enemyHealth = hitInfo.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damage);
        }

        PlayerHealth playerHealth = hitInfo.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
        }

        GameObject effect = Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effect, 1);
        Destroy(gameObject);
    }
}
