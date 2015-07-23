using UnityEngine;
using System.Collections;

public class s_PlayerTwoMovement : MonoBehaviour {

	public float MovementSpeed = 5f;
	
	// Update is called once per frame
	void Update () {
		Movement();
	}

	public void Movement(){
		if(Input.GetKey(KeyCode.W)){
			transform.Translate (0, Time.deltaTime * MovementSpeed, 0);
		}		
		if(Input.GetKey(KeyCode.A)){
			transform.Translate (-(Time.deltaTime * MovementSpeed), 0, 0);
		}		
		if(Input.GetKey(KeyCode.D)){
			transform.Translate (Time.deltaTime * MovementSpeed, 0, 0);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate (0, -(Time.deltaTime * MovementSpeed), 0);
		}
	}
}
