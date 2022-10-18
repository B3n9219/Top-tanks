using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{   
    public Transform healthBar;
    private Rigidbody2D rb;
    public Transform player;
    public float speed = 0;
    Vector3 lastPosition = Vector3.zero;
    float time;
    float timeDelay;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;

    void FixedUpdate()
    {
        speed = (transform.position - lastPosition).magnitude;
        lastPosition = transform.position;
    }

    void Start ()
    {
        rb = this.GetComponent<Rigidbody2D>();
        time = 0f;
        timeDelay = 1f;

    }

    void Update()
    {   
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        healthBar.transform.rotation = Quaternion.Euler (0.0f, 0.0f, 0.0f);
        healthBar.transform.position = new Vector3(transform.position.x, transform.position.y +1f, 0f);
        time = time+1f*Time.deltaTime;
        if(time >= timeDelay)
        {
            time = 0f;
            if (speed == 0)
            {
                Shoot();
            }
            
        }
        
    }

    void Shoot()
        {   
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        }

        


}


