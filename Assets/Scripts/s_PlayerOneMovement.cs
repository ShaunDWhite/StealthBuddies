using UnityEngine;
using System.Collections;

public class s_PlayerOneMovement : MonoBehaviour {

	/*
	 * Edit - Project setting - Input
	 * Horizontal:
	 * 		Gravity: 1
	 * 		Dead:	0.2
	 * 		Sensitivity: 1
 	 * 		Type: Joystick Axis
	 * 		Axis: X
	 * 		Joy num: all joysticks
	 * 
	 *  Vertical:
	 * 		Gravity: 1
	 * 		Dead:	0.2
	 * 		Sensitivity: 1
	 * 		Type: Joystick Axis
	 * 		Axis: Y
	 * 		Joy num: all joysticks 
	 * */

	public float MovementSpeed = 5;

	// Use this for initialization
	void Start () {

	}

	void Update(){
		Movement();	
	}
	public void Movement(){
		transform.Translate(0,-(Input.GetAxis("Vertical") * Time.deltaTime * MovementSpeed),0);			//Vertical movement
		transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * MovementSpeed, 0, 0); 		// Horizontal movement
	}		
}
