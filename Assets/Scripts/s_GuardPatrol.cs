using UnityEngine;
using System.Collections;

public class s_GuardPatrol : MonoBehaviour {

	public bool one, two, three, four;
	public Vector3 Pos1, Pos2, Pos3, Pos4;
	public float MovingSpeed = 2;


	// Use this for initialization
	void Start () {	
		one = true;
	}
	
	// Update is called once per frame
	void Update () {
		Patrol ();
	}

	void Patrol(){
		if(one)
			transform.Translate (5 * MovingSpeed * Time.deltaTime, 0, 0);


		if(two)
			transform.Translate (-(5 * MovingSpeed * Time.deltaTime), 0, 0);

		if(three)
			transform.Translate (0, 5 * MovingSpeed * Time.deltaTime, 0);

		if(four)
			transform.Translate (0, -(5 * MovingSpeed * Time.deltaTime), 0);

	}


	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "Post One") {		
			two = true;
			four = false;
			one = false;
		}
		if (col.gameObject.name == "Post Two") {
			three = true;
			two = false;
		}
		if (col.gameObject.name == "Post Three") {
			one = true;
			three = false;
		}
		if (col.gameObject.name == "Post Four") {
			four = true;
			one = false;
		}




	}





}
