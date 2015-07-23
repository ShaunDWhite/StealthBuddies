using UnityEngine;
using System.Collections;

public class s_TriggerTemplate : MonoBehaviour {


	public s_GameManager gameManager;



	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player One") {
			print ("Shiet");
		} else if (col.tag == "Player Two") {
			print ("shiet again");
		}
	}




}
