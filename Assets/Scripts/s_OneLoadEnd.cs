using UnityEngine;
using System.Collections;

//Metrics
using CobaltMetrics;
using CobaltMetrics.DataTypes;
using CobaltMetrics.DataTypes.Unity;

public class s_OneLoadEnd : MonoBehaviour {

	public bool One, Two;
	public s_GameManager gameManager;


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

	//METRICS : Called when one player enters the next room.
	void LoadEnd(){
		if (One == true) {
			gameManager.EndOne = true;
			CMetricNative.String("endType", "p1Only"); //Metrics
			CobaltMetrics.Metrics.StopMetrics();
			Application.LoadLevel("EndGame");
				} else if (Two == true) {
			gameManager.EndTwo = true;
			CMetricNative.String("endType", "p2Only"); //Metrics
			CobaltMetrics.Metrics.StopMetrics();
			Application.LoadLevel("EndGame");
				}
	}
}
