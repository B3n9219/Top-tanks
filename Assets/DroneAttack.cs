using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAttack : MonoBehaviour
{   
    public int damage = 10;
    public GameObject impactEffect;
    public Rigidbody2D rb;

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        PlayerHealth playerHealth = hitInfo.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
        }
        GameObject effect = Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effect, 1);
        //Destroy(gameObject);
    }




}