using UnityEngine;
using System.Collections;

public class s_GuardPatrol : MonoBehaviour {

	public bool one, two, three, four;
	public Vector3 Pos1, Pos2, Pos3, Pos4;
	public float MovingSpeed = 2;


	// Use this for initialization
	void Start () {
		one = true;
		two = false;
		three = false;
		four = false;
	}
	
	// Update is called once per frame
	void Update () {
		Patrol ();
	}

	void Patrol(){
		transform.Translate (5 * MovingSpeed * Time.deltaTime, 0, 0);
	}



}
