using UnityEngine;
using System.Collections;

public class s_GuardPatrol : MonoBehaviour {

	public bool one, two, three, four;
	public float MovingSpeed = 2;
	RaycastHit hit;
	public float SightDistance = 7.5f;
	public Transform node1, node2, node3, node4;
	public Transform target;

	// Use this for initialization
	void Start () {
		node1 = GameObject.Find ("Post One").transform;
		node2 = GameObject.Find ("Post Two").transform;
		node3 = GameObject.Find ("Post Three").transform;
		node4 = GameObject.Find ("Post Four").transform;
		target = node1;
		two = true;
	}
	
	// Update is called once per frame
	void Update () {
		Patrol ();
		Sight ();
		//transform.LookAt (target);
	}

	void Patrol(){
		if(one)
//			transform.Translate (5 * MovingSpeed * Time.deltaTime, 0, 0);
			transform.Translate(transform.right * 5 * MovingSpeed * Time.deltaTime);
//
		if(two)
//			transform.Translate (-(5 * MovingSpeed * Time.deltaTime), 0, 0);
			transform.Translate(-transform.right * 5 * MovingSpeed * Time.deltaTime);
//
		if(three)
//			transform.Translate (0, 5 * MovingSpeed * Time.deltaTime, 0);
			transform.Translate(-transform.up * 5 * MovingSpeed * Time.deltaTime);
//
		if(four)
//			transform.Translate (0, -(5 * MovingSpeed * Time.deltaTime), 0);
			transform.Translate(transform.up * 5 * MovingSpeed * Time.deltaTime);
	}


	void Sight(){
		Vector3 forward = transform.TransformDirection(-Vector3.right) * SightDistance;
		Debug.DrawRay(transform.position, forward, Color.green);

		Physics.Raycast (transform.position, -transform.right, out hit, SightDistance);
		if (hit.collider != null && hit.collider.tag == "Player") {
			Debug.Log("You been seen");
		}
	}


	void OnTriggerEnter(Collider col){
		transform.Rotate(transform.forward, -90.0f);
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

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Player") {
			Debug.Log("you been caught");
				}
	}









}
