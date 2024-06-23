using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public float minimumDistance;
    public float maximuimDistance;
    private Enemy enemy;
    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }
    void Update()
    {
       float distance = Vector3.Distance(transform.position, target.transform.position);
        if ( distance > minimumDistance && distance < maximuimDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
            transform.LookAt(target.transform);
            enemy.PlayRun();
        }
        else if (distance <= minimumDistance)
        {
            enemy.Attack();
        }
        else 
        {
            enemy.PlayIdle();
        }
        
        
    }
}
