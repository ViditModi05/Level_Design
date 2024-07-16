using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class EnemyMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody rig;
    [SerializeField] private CapsuleCollider col;
    [SerializeField] private Transform[] waypoints;

    [Header("Settings")]
    [SerializeField] private float eSpeed;
    private int waypointsIndex = 0;
    
    void Start()
    {
        //Setting the position of the enemy to the first waypoint
        transform.position = waypoints[waypointsIndex].transform.position; 
        
    }

    // Update is called once per frame
    void Update()
    {
       Move(); //Moving the enemy 
    }

    private void Move()
    {
        if(waypointsIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position , waypoints[waypointsIndex].transform.position, 
            eSpeed * Time.deltaTime); //Using the move towards method to move the enemy to the next waypoint
        }

        if(transform.position == waypoints[waypointsIndex].transform.position)
        {
            waypointsIndex += 1; //If enemy reaches the waypoint the index value is increased by one
        }
    }

}
