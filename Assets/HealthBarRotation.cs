using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarRotation : MonoBehaviour
{   
    public Transform healthBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.transform.rotation = Quaternion.Euler (0.0f, 0.0f, 0.0f);
        healthBar.transform.position = new Vector3(transform.position.x, transform.position.y +1f, 0f);
    }
}
