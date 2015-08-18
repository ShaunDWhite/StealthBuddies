using UnityEngine;
using System.Collections;

using CobaltMetrics.DataTypes;

public class s_TriggerTemplate : MonoBehaviour {

	//Copy and paste this into a new script for use on other objects. 

	public s_GameManager gameManager;
	public bool One, Two;



	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager").GetComponent<s_GameManager> ();
		One = false;
		Two = false;
	}
	
	// Update is called once per frame
	void Update () {
		LoadEnd ();
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			One = true;
		}
		if(col.gameObject.name == "PlayerTwoTest"){
			Two = true;
		}
	}
	
	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.name == "PlayerOneTest"){
			One = false;
		}
		if(col.gameObject.name == "PlayerTwoTest"){
			Two = false;
		}
	}

	//METRICS - Both players made ending.
	void LoadEnd(){
		if ((One == true) && (Two == true)) {
			gameManager.EndBoth = true;

			//Metrics
			CMetricNative.String("endType", "p1andp2"); //Metrics
			CobaltMetrics.Metrics.StopMetrics();

			Application.LoadLevel("EndGame");
		}
	}





//	void OnTriggerEnter(Collider col)
//	{
//		if (col.tag == "Player One") {
//			print ("Shiet");
//		} else if (col.tag == "Player Two") {
//			print ("shiet again");
//		}
//	}




}
