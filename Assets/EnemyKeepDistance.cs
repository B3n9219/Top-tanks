using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKeepDistance : MonoBehaviour
{
    public Transform Player;
    public float speed;
    public float t;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(0f, 0f, 0f);
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        Debug.Log(distance);
        if(distance <= 4)
        {
            //transform.position = new Vector3 (0f,0f,0f);
            Vector3 difference = Player.position - transform.position;
            Vector3 target = transform.position - difference;
            transform.position = Vector3.MoveTowards(transform.position, Vector3.Lerp(transform.position,target,t), speed);
            
        }
    }
}
