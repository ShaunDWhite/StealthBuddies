﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AI_Behaviour : MonoBehaviour {

	//The player
    public GameObject target;

    //A list of waypoints
	public List<GameObject> waypoints = new List<GameObject>();
    int waypointIDX;

    //The speed at which the AI moves
    [Range(1.0f, 400.0f)]
	public float speed;

	//The distance from player before being spotted
	[Range(0.1f, 100.0f)]
	public float dist;
    
    //The AI's field of view
   [Range(1.0f,90.0f)]
   public float scanFOV;

    //Keeps track of how long the AI is in the LOOK state for
    [Range(0.1f, 5.0f)]
    public float lookTimer;
	private float timer;

    //The various AI states
	enum AIState
	{
		PATROL,
		LOOK,
		CHASE
	};

	AIState currState;

	// Use this for initialization
	void Start ()
	{
        waypointIDX = 0;
		currState = AIState.PATROL;
        transform.LookAt(waypoints[waypointIDX].transform.position);
	}
	
	// Update is called once per frame
	void Update () 
	{     
        //Switches the state of the AI when certain conditions are met
        switch(currState)
		{
			case AIState.PATROL:
			OnPatrol();
			break;

			case AIState.LOOK:
			OnLook();
			break;

			case AIState.CHASE:
			OnChase();
			break;
		}

		if(currState == AIState.LOOK)
		{
			timer += Time.deltaTime;
		}

       //Debug.Log(Vector3.Dot(Vector3.Normalize(this.transform.forward), Vector3.Normalize(target.transform.position - this.transform.position)) > Mathf.Cos(scanFOV * Mathf.Deg2Rad));
       //Debug.Log(Vector3.Dot(Vector3.Normalize(this.transform.forward), Vector3.Normalize(target.transform.position - this.transform.position)));



        if (Vector3.Dot(Vector3.Normalize(this.transform.forward), Vector3.Normalize(target.transform.position - this.transform.position)) > Mathf.Cos(scanFOV * Mathf.Deg2Rad) && (target.transform.position - this.transform.position).magnitude < dist)
        {
            currState = AIState.CHASE;
        }

        //The lhs and rhs of the field of view
        Vector3 leftHS = transform.forward * 100.0f;
        Vector3 rightHS = transform.forward * 100.0f;

        //Uses a euclidian vector the calculate the lhs and rhs and draws them
		leftHS = new Vector3(leftHS.x * Mathf.Cos(scanFOV * Mathf.Deg2Rad) - leftHS.z * Mathf.Sin(scanFOV * Mathf.Deg2Rad), leftHS.x * Mathf.Sin(scanFOV * Mathf.Deg2Rad) + leftHS.z * Mathf.Cos(scanFOV * Mathf.Deg2Rad),0f);
		rightHS = new Vector3(rightHS.x * Mathf.Cos(-scanFOV * Mathf.Deg2Rad) - rightHS.z * Mathf.Sin(-scanFOV * Mathf.Deg2Rad), rightHS.x * Mathf.Sin(-scanFOV * Mathf.Deg2Rad) + rightHS.z * Mathf.Cos(-scanFOV * Mathf.Deg2Rad),0f);
        Debug.DrawLine(this.transform.position, this.transform.position + leftHS);
        Debug.DrawLine(this.transform.position, this.transform.position + rightHS);
        //Debug.DrawLine(this.transform.position, target.transform.position, new Color(0.0f, 1.0f, 0.0f));

	}

    /// <summary>
    /// Moves from one waypoint to another in a random order
    /// </summary>
	void OnPatrol()
	{
       this.transform.position = Vector3.MoveTowards(this.transform.position, waypoints[waypointIDX].transform.position, speed * Time.deltaTime);
       transform.LookAt(transform.position + Vector3.RotateTowards(transform.forward, waypoints[waypointIDX].transform.position - transform.position, 6.0f * Time.deltaTime, 0.0f));
       if ((this.transform.position - waypoints[waypointIDX].transform.position).magnitude < 1.0f)
       {
           int tempIDX = waypointIDX;
			//Nic tried to add its waypoint system to reset once it reaches the last point. ***********************************Look Here for Fuck Up***************************************
           do
           {
				if(waypointIDX <= 3){
               waypointIDX +=1;
				} else if (waypointIDX > 3)
				{
					waypointIDX = 0;
				}
           }
           while (waypointIDX == tempIDX);
		    currState = AIState.LOOK;
       }
    }

    /// <summary>
    /// The player looks around until the timer hits 0
    /// </summary>
	void OnLook()
	{
		if(timer < lookTimer)
		{
            transform.Rotate(0, (Time.deltaTime * 6.28f) * Mathf.Rad2Deg, 0);
		}
		else if(timer >= lookTimer)
		{
			timer = 0f;
			currState = AIState.PATROL;
		}
	}

    /// <summary>
    /// Moves towards the player
    /// </summary>
	void OnChase()
	{
       this.transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position, speed * Time.deltaTime);
	}
}
